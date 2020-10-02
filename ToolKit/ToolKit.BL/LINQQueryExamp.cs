using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit.BL
{
    class LINQQueryExamp
    {
        public void QueryUsers()
        {
            var users = new string[] { "Joe", "Mike", "Bob" };

            var usersQuery = 
                from user in users 
                where user.Contains("o") 
                orderby user.Length ascending
                select user;

            Console.WriteLine(usersQuery.Count()); //would return 2.
        }

        public void QueryUsersWithGroupBy()
        {
            var users = new string[] { "Joe", "Mike", "Bob" };

            var usersQuery =
                from user in users
                group user by user.Length into userGroup
                select userGroup;

            foreach (var userGroup in usersQuery)
            {
                Console.WriteLine("{0} characters long", userGroup.Key);
                foreach(var user in userGroup)
                {
                    Console.WriteLine(user);
                }
            }

            Console.WriteLine(usersQuery.Count()); //would return 2.
        }
    }
}
