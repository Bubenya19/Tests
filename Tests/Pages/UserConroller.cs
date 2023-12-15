using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.model;

namespace Tests
{
    public class UserConroller
    {
        Connection connection = new Connection();


        public List<Users> GetUsers()
        {

            try
            {
                var users = connection.auth.Users.ToList();

                return users;
            }
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message}");
            }


        }


        public Users SignIn(string username, string password)
        {
            try
            {
                var user = connection.auth.Users.Where(x => x.UserName == username && x.UserPassword == password).First();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
