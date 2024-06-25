using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Manager
{
    internal class UserManager : IUserManager
    {
        public async  Task addUser(ExamDbContext context)
        {
            User newUser = new()
            {
                UserName = "user 1",
                UserType = "user",
                UserPassword = "user1234"
            };
            User newUser2 = new()
            {
                UserName = "user 2",
                UserType = "user",
                UserPassword = "user1234"
            };
            User newUser3 = new()
            {
                UserName = "user 3",
                UserType = "user",
                UserPassword = "user1234"
            };
            User newUser4 = new()
            {
                UserName = "user 4",
                UserType = "user",
                UserPassword = "user1234"
            };
            await context.Users.AddRangeAsync(newUser, newUser2, newUser3, newUser4);
            await context.SaveChangesAsync();
            Console.WriteLine("user elave olundu...");
            
        }

        public async Task removeUser(ExamDbContext context, int userId)
        {
            try
            {
                User? findUser = await context.Users.FirstOrDefaultAsync(p => p.Id == userId);
                if (findUser != null && findUser.Id != 1)
                {
                    context.Users.Remove(findUser);
                    await context.SaveChangesAsync();
                    Console.WriteLine("user silindi...");
                }
                else if (findUser == null)
                {
                    Console.WriteLine($"{findUser!.Id} idli user yoxdur");

                }
                
                   
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
