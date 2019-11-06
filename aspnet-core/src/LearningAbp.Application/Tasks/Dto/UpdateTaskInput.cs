using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LearningAbp.Tasks.Dto
{
    [AutoMapTo(typeof(Task))] // 定义单向映射
    public class UpdateTaskInput : ICustomValidate
    {
        [Range(1, Int32.MaxValue)]
        public int Id { get; set; }

        public long? AssignedPersonId { get; set; }

        public TaskState? State { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            if (AssignedPersonId == null && State == null)
            {
                context.Results.Add(new ValidationResult("Both of AssignedPersonId and State can not be null in order to update a Task!", 
                    new [] { "AssignedPersonId", "State" }));
            }
        }

        public override string ToString()
        {
            return string.Format("[UpdateTaskInput > TaskId = {0}, AssignedPersonId = {1}, State = {2}]", Id, AssignedPersonId, State);
        }
    }
}
