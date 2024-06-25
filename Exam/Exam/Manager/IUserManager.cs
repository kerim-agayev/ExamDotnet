using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Manager
{
    internal interface IUserManager
    {
        public Task addUser(ExamDbContext context);
        public Task removeUser(ExamDbContext context, int userId);
    }
}
