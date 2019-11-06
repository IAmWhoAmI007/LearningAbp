using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Timing;
using AutoMapper;
using LearningAbp.Tasks.Dto;

namespace LearningAbp.Tasks
{
    public class TaskAppService : LearningAbpAppServiceBase, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;

        public TaskAppService(IRepository<Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            var query = _taskRepository.GetAll();

            if (input.AssignedPersonId.HasValue)
            {
                query = query.Where(t => t.AssignedPersonId == input.AssignedPersonId.Value);
            }

            if (input.State.HasValue)
            {
                query = query.Where(t => t.State == input.State.Value);
            }

            //var config = new MapperConfiguration(cfg => cfg.CreateMap<Task, TaskDto>());
            //var mapper = config.CreateMapper();

            //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
            return new GetTasksOutput
            {
                Tasks = ObjectMapper.Map<List<TaskDto>>(query.ToList())
            };
        }

        //public async Task<TaskDto> GetTaskByIdAsync(int taskId)
        //{
        //    var task = await _taskRepository.GetAsync(taskId);

        //    return task.MapTo<TaskDto>();
        //}

        public TaskDto GetTaskById(int taskId)
        {
            var task = _taskRepository.Get(taskId);

            return task.MapTo<TaskDto>();
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a task for input: " + input);

            //Retrieving a task entity with given id using standard Get method of repositories.
            var task = _taskRepository.Get(input.Id);

            //Updating changed properties of the retrieved task entity.

            if (input.State.HasValue)
            {
                task.State = input.State.Value;
            }
        }

        public int CreateTask(CreateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a task for input: " + input);

            //Creating a new Task entity with given input's properties
            var task = new Task
            {
                AssignedPersonId = input.AssignedPersonId,
                Description = input.Description,
                Title = input.Title,
                State = input.State,
                CreationTime = Clock.Now
            };

            //Saving entity with standard Insert method of repositories.
            return _taskRepository.InsertAndGetId(task);
        }

        public void DeleteTask(int taskId)
        {
            var task = _taskRepository.Get(taskId);
            if (task != null)
            {
                _taskRepository.Delete(task);
            }
        }

        public IList<TaskDto> GetAllTask()
        {
            var tasks = _taskRepository.GetAll().OrderByDescending(t => t.CreationTime).ToList();

            return ObjectMapper.Map<IList<TaskDto>>(tasks);
        }
    }
}
