using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MyABPTest.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyABPTest.Tasks
{
    public class Task : Entity, IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024;

        public long? AssignedPersonId { get; set; }

        [F]
        public User AssignedPerson { get; set; }

    }
}
