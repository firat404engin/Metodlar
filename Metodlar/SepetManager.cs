using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
	internal class SepetManager
	{
		//naming convention 
		public void Ekle(Urun urun)
		{
			Console.WriteLine("Sepete Eklendi:  " + urun.Adi);
		}

		public void Ekle2(string urunAdi, string aciklama , double fiyat)
		{
            Console.WriteLine("Sepete Eklendi:  " + urunAdi);
            Console.WriteLine("Sepete Eklendi:  " + aciklama);
            Console.WriteLine("Sepete Eklendi:  " + fiyat);
		}
	}
}
