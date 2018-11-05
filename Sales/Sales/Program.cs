using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Category Phone = new Category() { ID = 7, Name = "Phone", Photo = "img1.jpg" };
            Category Computer = new Category() { ID = 8, Name = "Computer", Photo = "img2.jpg" };
            List<Product> Product = new List<Product>();
            List<Category> category = new List<Category>();
            category.Add(Phone);
            category.Add(Computer);
            Product.Add(new Product() { Name = "IPhone5", Barcode = 123456789, ID = 1, category = Phone });
            Product.Add(new Product() { Name = "IPhon6", Barcode = 987654321, ID = 2, category = Phone });
            Product.Add(new Product() { Name = "IPhone7", Barcode = 456123789, ID = 3, category = Phone });
            Product.Add(new Product() { Name = "IPhone8", Barcode = 789123456, ID = 4, category = Phone });
            Product.Add(new Product() { Name = "Samsung", Barcode = 963852741, ID = 5, category = Computer });
            Product.Add(new Product() { Name = "Sony", Barcode = 741852963, ID = 6, category = Computer });
            Console.WriteLine("1.Mehsulu secmek ucun 1");
            Console.WriteLine("2.Mehsul elave etmek 2-ni secin");
            Console.WriteLine("3.Kateqoriya elave etmek ucun 3-u secin");
            var secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Mehsulu secin!");

                Console.WriteLine("1. Phone");
                Console.WriteLine("2. Computer");

                int switc = int.Parse(Console.ReadLine());

                switch (switc)
                {
                    case 1:
                        var Complist = Product.Where(pr => pr.category.ID == 8).ToList();
                        foreach (var pr in Complist)
                        {
                            Console.WriteLine(pr.Name);
                        }
                        break;

                    case 2:
                        var Phonelist = Product.Where(pr => pr.category.ID == 7).ToList();
                        foreach (var pr in Phonelist)
                        {
                            Console.WriteLine(pr.Name);
                        }
                        break;
                }
            }
            if (secim == "2")
            {
                Product product = new Product();
                Console.WriteLine("Mehsulun adini daxil edin.");
                product.Name = Console.ReadLine();
                Console.WriteLine("Barkodu daxil edin.");
                product.Barcode = int.Parse(Console.ReadLine());
                Console.WriteLine("Kategoriya ID-ni secin");
                foreach (var b in category)
                {
                    Console.WriteLine(b.ID + " " + b.Name);
                }

                var id = int.Parse(Console.ReadLine());
                var secilmiwcategory = category.FirstOrDefault(f => f.ID == id);
                product.category = secilmiwcategory;
            }

            if (secim == "3")
            {
                Category cate = new Category();
                Console.WriteLine("Yeni kategoriya adini daxil edin.");
                cate.Name = Console.ReadLine();
                category.Add(cate);
            }

        }

    }

    public class Product
    {
        public string Name { get; set; }
        public int Barcode { get; set; }
        public int ID { get; set; }
        public Category category { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}