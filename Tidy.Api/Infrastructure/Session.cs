using Tidy.Core.Domain.Identity;
using Tidy.Core.Infrastructure;
using Tidy.Core.Repository.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Infrastructure
{
    public class Session : ISession
    {
        private readonly IUserRepository _userRepository;

        public Session(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CurrentUser
        {
            get
            {
                string name = HttpContext.Current.GetOwinContext().Request.User.Identity.Name;
                return _userRepository.FirstOrDefault(u => u.UserName == name);
            }
        }
    }
}