using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Urun urun1 = new Urun();
			urun1.Adi = "Elma";
			urun1.Fiyati = 20;
			urun1.Aciklama = "Amasya Elmasi";

			Urun urun2 = new Urun();
			urun2.Adi = "Karpuz";
			urun2.Fiyati = 30;
			urun2.Aciklama = "Diyarbakır karpuzu";

			Random rnd = new Random();
			
			Urun[] urunler = new Urun[] { urun1, urun2 };

			//type safe -- tip güvenli
			foreach (Urun urun in urunler)
			{
				int sayi = rnd.Next(0,100);
				Console.WriteLine(sayi);
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.Fiyati);
				Console.WriteLine(urun.Aciklama);
				Console.WriteLine("----------------------");
			}
            Console.WriteLine();
			Console.WriteLine("----------------Metodlar-----------------");
			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(urun1);
			sepetManager.Ekle(urun2);
			sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
			sepetManager.Ekle2("Yeni DünyA", "Yeşil Dünya", 112);


			Console.ReadLine();
		}
	}
}

//Dont repeat yourself