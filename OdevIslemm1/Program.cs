using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OdevIslemm1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Random rnd = new Random();
           int[]sayilar=new int[6];
            int i, sayi, hedef, cift,giris,onay=1;
            while (onay ==1)
            {
                Console.Write("Random icin 1 - manuel için 2 giriniz:");
                giris = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------------");
                if (giris == 1)
                {
                    for (i = 0; i < 5; i++)
                    {
                        sayi = rnd.Next(1, 9);
                        sayilar[i] = sayi;
                        Console.WriteLine("Sayilar:" + sayi);

                    }

                    cift = rnd.Next(10, 100);
                    cift -= cift % 10;
                    sayilar[5] = cift;
                    Console.WriteLine("cift:" + cift + "\n");
                    hedef = rnd.Next(100, 1000);
                    Console.WriteLine("hedef:" + hedef + "\n");
                    Islem yeni = new Islem();

                    if (yeni.Coz(sayilar, sayilar.Length, hedef))
                    {
                        Console.WriteLine("Çözüm:");
                        yeni.Yazdır();
                        Console.WriteLine("=" + hedef);
                        Console.WriteLine("Çözüm başarılı");


                    }
                    else
                    {
                        Console.WriteLine("Çözüm başarısız");

                    }
                }



                else if (giris == 2)
                {
                    for (i = 0; i < 5; i++)
                    {
                        Console.Write("Rakam gir:");
                        int rakam = Convert.ToInt32(Console.ReadLine());
                        sayilar[i] = rakam;

                    }
                    Console.Write("Çift haneli sayi giriniz");
                    cift = Convert.ToInt32(Console.ReadLine());
                    sayilar[5] = cift;
                    Console.Write("hedef sayi giriniz");
                    hedef = Convert.ToInt32(Console.ReadLine());
                    Islem yeni = new Islem();

                    if (yeni.Coz(sayilar, sayilar.Length, hedef))
                    {
                        Console.WriteLine("Çözüm:");
                        yeni.Yazdır();
                        Console.WriteLine("=" + hedef);
                        Console.WriteLine("Çözüm başarılı");


                    }
                    else
                    {
                        Console.WriteLine("Çözüm başarısız");

                    }
                }
                
            }
            

        


            Console.ReadKey();
            }



          
        }
    }

