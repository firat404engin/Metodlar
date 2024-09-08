using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Koleksiyonlar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string[] isimler = new string[] {"firat","engin","gamze","demir" };
			//Console.WriteLine(isimler[0]);
			//Console.WriteLine(isimler[1]);
			//Console.WriteLine(isimler[2]);
			//Console.WriteLine(isimler[3]);


			List<string> isimler2 = new List<string>{"gamze", "demir"};
			Console.WriteLine(isimler2[0]);
			Console.WriteLine(isimler2[1]);
			isimler2.Add("firat");
			isimler2.Add("engin");
			Console.WriteLine(isimler2[2]);
			Console.WriteLine(isimler2[1]);

			Console.ReadLine();
		}
	}
}
