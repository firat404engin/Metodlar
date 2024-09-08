using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.Id = 1;
			product1.CategoryId = 2;
			product1.ProductName = "Masa";
			product1.UnitPrice = 500;
			product1.UnitsInStock = 3;

			Product product2 = new Product {Id=2,CategoryId=3,
				ProductName="Masa", UnitPrice=5,
				UnitsInStock=73 };

			// PascalCase    // camelCase
			// case sensitive

			// int , double , bool değer tip
			// diziler , class , interface, abstract  referans tip


			ProductManager productManeger = new ProductManager();
			productManeger.topla2(2, 3);
			Console.ReadLine();
		}
	}
}
