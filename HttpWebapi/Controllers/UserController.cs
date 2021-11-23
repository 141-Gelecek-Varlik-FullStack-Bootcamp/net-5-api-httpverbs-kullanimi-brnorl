using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HttpWebapi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]

    public class UserController : ControllerBase
    {
        private static List<User> UserList = new List<User>()
        {
            new User{
                Id = 1,
                Name = "Baransel",
                Surname = "Oral",
                Email = "brnorl47@gmail.com",
                PhoneNumber = "123567893"
            },
            new User{
                Id = 2,
                Name = "Umut",
                Surname = "bozbek",
                Email = "umud@gmail.com",
                PhoneNumber = "123567893"
            },
            new User{
                Id = 3,
                Name = "Efe",
                Surname = "Karahanlı",
                Email = "efe13@gmail.com",
                PhoneNumber = "123567893"
            },
            new User{
                Id = 4,
                Name = "Üstün",
                Surname = "Kısa",
                Email = "kısa123@gmail.com",
                PhoneNumber = "123567893"
            },
            new User{
                Id = 5,
                Name = "Fethi",
                Surname = "Güngördü",
                Email = "brnorl47@gmail.com",
                PhoneNumber = "123567893"
            },
            new User{
                Id = 6,
                Name = "Arda",
                Surname = "Turan",
                Email = "arda123@gmail.com",
                PhoneNumber = "123567893"
            },
        };

        [HttpGet]
        public List<User> getUsers()
        {
            var userList = UserList.OrderBy(x => x.Id).ToList<User>();
            return userList;
        }

        [HttpGet("{id}")]
        public User GetById(int id)
        {
            var user = UserList.Where(user => user.Id == id).SingleOrDefault();
            return user;
        }

    }
}