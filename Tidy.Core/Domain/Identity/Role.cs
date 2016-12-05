using $safeprojectname$.Infrastructure.Interfaces;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace $safeprojectname$.Domain.Identity
{
    public class Role : IRole<int>, ICreatedDate
    {
        public Role()
        {
            Users = new Collection<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<UserRole> Users { get; set; }
    }
}
