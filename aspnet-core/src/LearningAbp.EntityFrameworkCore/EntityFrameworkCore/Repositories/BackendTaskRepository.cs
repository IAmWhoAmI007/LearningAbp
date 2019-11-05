using Abp.EntityFrameworkCore;
using LearningAbp.IRepositories;
using LearningAbp.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace LearningAbp.EntityFrameworkCore.Repositories
{
    public class BackendTaskRepository : LearningAbpRepositoryBase<Task>, IBackendTaskRepository
    {
        public BackendTaskRepository(IDbContextProvider<LearningAbpDbContext> dbContextProvider) : base(dbContextProvider)
        { }

        public List<Task> GetTaskByAssignedPersonId(long personId)
        {
            var query = GetAll();

            if(personId > 0)
            {
                query = query.Where(t => t.AssignedPersonId == personId);
            }

            return query.ToList();
        }
    }
}
