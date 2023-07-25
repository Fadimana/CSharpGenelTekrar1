using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma1
{
    internal class Rectangle
    {
        double wid, len;
        public void setValues()
        {
            wid = 3.2; len = 5.0;
        }
        public double getArea()
        {
            return wid * len;

        }
        public void displayArea()
        {
            Console.WriteLine("Length: {0}", len);
            Console.WriteLine("Width: {0}", wid);
            Console.WriteLine("Area: {0}", getArea());
        }
        //sınıfın somutlaştırılması için :Mainclass sınıfı Main metodunu içerir ve Rextangle sınıfını somutlaştırır.
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.setValues();
            rectangle.getArea();
            rectangle.displayArea();


            /*Tip dönüşümü */
            double d = 5648.55;
            int i;
            //cast double to int
            i = (int)d;
            Console.WriteLine(i);

            Console.WriteLine(d.ToString());


            /*const örneği*/
            const double pi = 3.14159;
            double r;
            Console.WriteLine("Yaricapi girin :");
            r = Convert.ToDouble(Console.ReadLine());

            double alan = pi * r * r;
            Console.WriteLine("\nYariçap {0}\nAlan:{1}", r, alan);


            //foreach döngüsü
            string[] sayi = { "1", "2", "3", "4", "5" };
            foreach (string say in sayi)
            {
                Console.WriteLine(say);
            }

            //Girilen N sayısının ort bulan program
            int a;
            double sayı, toplam = 0;
            Console.WriteLine("Kaç sayı girilecek ?");
            a = Convert.ToInt32(Console.ReadLine());

            for (int k = 1; k <= a; k++)
            {
                Console.Write("{0}. sayı:", k);
                sayı = Convert.ToDouble(Console.ReadLine());
                toplam += sayı;
            }
            Console.WriteLine("ortalama ={0}", toplam / a);

            //Girilen bir sayı dizisinin elemanlarına foreach döngüsü ile erişilen örnek;
            int[] dizi = new int[] { 99, 98, 62, 100, 92, 97, 95, -20, 50 };
            int enkucuk = dizi[0], enbuyuk = dizi[0];
            foreach(int k in dizi)
            {
                if (k < enkucuk)
                    enkucuk = k;
            }
            Console.WriteLine("En kucuk:{0}",enkucuk);
            foreach(int k in dizi)
            {
                if (k > enbuyuk)
                    enbuyuk = k;
            }
            Console.WriteLine("En buyuk:{0}", enbuyuk);

            //diziler ile ilgili örnek:
            int[] n = new int[10];
            int m, j;

            for (m = 0; m < 10; m++) //dizi elemanı başlatma
            {
                n[m] = m + 100;
            }
            for(j= 0; j < 10;j++)// her elemanın değerini gösterme
            {
                Console.WriteLine("Element[{0}]={1}", j, n[j]); 
            }


            //string örneği 
            string fname, lname;
            fname = "Bill";
            lname = "Gates";

            char[] letters = { 'H', 'E', 'L', 'L', 'O' };
            string[] sarray = { "Hello", "From", "C#", "Programming" };

            string fullname = fname + lname; //operatörü string ile birleştirdik
            Console.WriteLine("Full Name:{0}",fullname);

            //string constructor kullanma {'H','e','l','l','o'};
            string greetings = new string(letters);
            Console.WriteLine("Greetings:{0}", greetings);

            //string dödüren method{"hello,"from","C#","Progtamming"};
            string message=String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //bir değeri stirnge dönüştürmek 
            DateTime waiting = new DateTime(2021,10,14,11,30,1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message :{0}", chat);



            Console.ReadKey();
        }

        

    }
}
