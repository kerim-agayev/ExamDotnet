using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Manager
{
    internal class ProductManager : IProductManager
    {
        //add product
        public async Task  AddProduct(ExamDbContext context)
        {

            Product newProduct = new()
            {
                ProductName = "Dell",
                ProductCount = 1,
                CategoryId = 1,
                ProductPrice = 600

            };
            await context.Products.AddAsync(newProduct);
            await context.SaveChangesAsync();
            Console.WriteLine($"{newProduct.ProductName} adli Product ugurla elave olundu");
            
          
        }
        //get product by categoryid
        public async Task GetProductByCategoryIdAsync(ExamDbContext context, int categoryId)
        {
            try
            {
                List<Product>? products = await context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();

                if (products != null && products.Count > 0)
                {
                    foreach (var item in products)
                    {
                        Console.WriteLine($"istediyiniz kategoriyaya aid mehsullar bunlardir: id-{item.Id}, name-{item.ProductName}");
                    }
                }
                else
                {
                    Console.WriteLine("bele bir kategoriya yoxdur");
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
           
        }
        //delete product

        public async Task DeleteProductAsync(ExamDbContext context, int id)
        {
            try {
                Product? product = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
                if (product != null)
                {
                    context.Products.Remove(product);
                    await context.SaveChangesAsync();
                    Console.WriteLine($"{product!.Id} id-li product silindi...");
                }
            } catch {
                Console.WriteLine($"product yoxdur...");
            }
           
        }
        //get all products
        public async Task GetAllProductsAsync(ExamDbContext context)
        {
            List<Product> products = await context.Products.ToListAsync();
            foreach (var item in products)
            {
                Console.WriteLine($"id:{item.Id}, name:{item.ProductName}, count:{item.ProductCount}, price: {item.ProductPrice} categoryId:{item.CategoryId}");
            }
        }

       
        //get product by id
        public async Task GetProductById(ExamDbContext context, int id)
        {
            try
            {
                Product? product = await context.Products.FirstOrDefaultAsync(u => u.Id == id);
                Console.WriteLine($"id:{product!.Id}, name:{product.ProductName}, count:{product.ProductCount}, price: {product.ProductPrice} categoryId:{product.CategoryId}");
            }
            catch
            {

            }
        }
        //update product
        public async Task UpdateProduct(ExamDbContext context, int id)
        {
            Product? product = await context.Products.FindAsync(id);
            Console.WriteLine($"name:{product!.ProductName}, count:{product.ProductCount}, price:{product.ProductPrice}, categoryId:{product.CategoryId}");
            if (product == null)
            {
                Console.WriteLine("mehsul yoxdur...");
                return;
            }
            else
            {
                Console.Write("mehsul adi daxil edin:");
                var productName = Console.ReadLine();
                Console.Write("Mehsul sayi daxil edin: ");
                var productCountInput = Console.ReadLine();
                if (!int.TryParse(productCountInput, out int productCount))
                {
                    Console.WriteLine("sehv daxil etdiniz...");
                    return;
                }
                Console.Write("mehsul qiymeti daxil edin:");
                var productPriceInput = Console.ReadLine();
                if (!int.TryParse(productPriceInput, out int productPrice))
                {
                    Console.WriteLine("sehv daxil etdiniz...");
                    return;
                }
                Console.Write("Mehsul categoriya id-i daxil edin: ");
                var categoryIdInput = Console.ReadLine();
                if (!int.TryParse(categoryIdInput, out int categoryId))
                {
                    Console.WriteLine("sehv daxil etdiniz...");
                    return;
                }



                product!.ProductName = productName;
                product.ProductPrice = productPrice;
                product.ProductCount = productCount;
                product.CategoryId = categoryId;
                await context.SaveChangesAsync();
                Console.WriteLine("mehsul ugurla deyisdirildi...");
            }


           




        }
    }
}
