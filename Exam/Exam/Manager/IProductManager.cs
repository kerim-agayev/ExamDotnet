using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Manager
{
    internal interface IProductManager
    {

        public Task GetAllProductsAsync(ExamDbContext context);
        public Task GetProductById(ExamDbContext context, int id);
        public Task AddProduct(ExamDbContext context);
        public Task DeleteProductAsync(ExamDbContext context, int id);
        public Task UpdateProduct(ExamDbContext context, int id);
        public Task GetProductByCategoryIdAsync(ExamDbContext context, int categoryId);
    }
}
