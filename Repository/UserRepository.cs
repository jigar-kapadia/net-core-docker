using System.Collections.Generic;
using core_api_docker.Models;

namespace core_api_docker.Repository
{
    public class UserRepository
    {
        public List<User> GetUsers(){
            var users = new List<User>();
            users.Add(new User(){ Id = 101, Email = "jigar@gmail.com", Password = "1234" });
            users.Add(new User(){ Id = 102, Email = "admin@gmail.com", Password = "0991" });
            users.Add(new User(){ Id = 103, Email = "johndoe@gmail.com", Password = "2233" });
            return users;
        }
    }
}