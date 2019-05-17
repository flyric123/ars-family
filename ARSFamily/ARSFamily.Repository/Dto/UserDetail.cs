using ARSFamily.Repository.Enum;
using ARSFamily.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARSFamily.Repository.Dto
{
    public class UserDetail
    {
        public static UserDetail CreateUserDetailFromUser(User user)
        {
            return new UserDetail
            {
                UserID = user.UserID,

                FirstName = user.FirstName,
                LastName = user.LastName,

                Gender = user.Gender
            };
        }

        public int UserID { get; private set; }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Gender Gender { get; private set; }

        private UserDetail() { }
    }
}
