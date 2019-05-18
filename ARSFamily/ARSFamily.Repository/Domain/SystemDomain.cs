using ARSFamily.Repository.Context;
using ARSFamily.Repository.Dto;
using ARSFamily.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARSFamily.Repository.Domain
{
    public static class SystemDomain
    {
        public static List<UserDetail> GetAllUsers()
        {
            using (var db = new SystemContext())
            {
                return db.Users.Select(u => UserDetail.CreateUserDetailFromUser(u))
                                .ToList();
            }
        }

        public static void AddOrUpdateUser(UserDetail user_detail)
        {
            using (var db = new SystemContext())
            {
                var userEntity = db.Users.FirstOrDefault(u => u.UserID == user_detail.UserID);

                if (userEntity == null)
                {
                    userEntity = new User();
                    db.Users.Add(userEntity);
                }

                userEntity.FirstName = user_detail.FirstName;
                userEntity.LastName = user_detail.LastName;
                userEntity.Gender = user_detail.Gender;

                db.SaveChanges();
            }
        }

        public static void RemoveUser(UserDetail user_detail)
        {
            using (var db = new SystemContext())
            {
                var userEntity = db.Users.FirstOrDefault(u => u.UserID == user_detail.UserID);

                if (userEntity != null)
                {
                    db.Users.Remove(userEntity);
                    db.SaveChanges();
                }
            }
        }
    }
}
