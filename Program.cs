using System;
namespace Diziler
{
    class Program
    {
        static void Main(string[]args)
        {
            string[] renkler= new string[5];

            string[] hayvanlar ={"Kedi","Köpek","Balina","Kanarya"};

            int [] dizi;
            dizi= new int [10];

            renkler[0]="Siyah";
            dizi[5]=12;

            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[5]);
            Console.WriteLine(hayvanlar[3]); 

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziEleman= Convert.ToInt32(Console.ReadLine());

            int [] sayiDizisi=new int [diziEleman];

            for (int i = 0; i < diziEleman; i++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz: ", i+1);
                sayiDizisi[i]=Convert.ToInt32(Console.ReadLine());
                
            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)
                toplam += sayi;

            Console.WriteLine("Dizinizin ortalaması: "+toplam/diziEleman);
            


        }
    }
}