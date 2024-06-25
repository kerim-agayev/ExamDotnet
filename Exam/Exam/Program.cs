// See https://aka.ms/new-console-template for more information
using Exam.Manager;
using Exam.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
ExamDbContext examDbContext = new ExamDbContext();
ProductManager manager = new();


//1. add product
//await manager.AddProduct(examDbContext);

//2. delete product by id
//await manager.DeleteProductAsync(examDbContext, 6);

//3. get all products

//await manager.GetAllProductsAsync(examDbContext);

//4. get product by id
//await manager.GetProductById(examDbContext, 7);

//5. update product
//await manager.UpdateProduct(examDbContext, 5);

//6. get product by category id
//await manager.GetProductByCategoryIdAsync(examDbContext, 4);
//------------------------------------------------------------
UserManager userManager = new();
//add user
await userManager.addUser(examDbContext);

//remove user


//await userManager.removeUser(examDbContext, 4);













