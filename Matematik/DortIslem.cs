  using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
	internal class DortIslem
	{
		public void Topla(int sayi1 , int sayi2)
		{
			int sonuc = sayi1+sayi2;
            Console.WriteLine(" sayıların toplamı "+sonuc);
		}
		public void Cıkar(int sayi1, int sayi2)
		{
			int sonuc = sayi1 - sayi2;
			Console.WriteLine(" sayıların farkı " + sonuc);
		}
		
	}
}
