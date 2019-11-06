using System;
using System.Collections.Generic;
using System.Text;

namespace LearningAbp.Tasks.Dto
{
    public class GetTasksInput
    {
        public TaskState? State { get; set; }
        public long? AssignedPersonId { get; set; }
    }
}
