using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OdevIslemm1
{
    public class Islem
    {
        private static IOperant[] Operantlar = { new Toplama(), new Cıkarma(), new Carpma(), new Bolme() };
        private ArrayList islemler = new ArrayList();
        public bool Coz(int[] DiziS, int uzunluk, int h_sayi)
        {
            for (int i = 0; i < uzunluk; i++)
            {
                if (DiziS[i] == h_sayi)
                {
                    return true;
                }
                for (int j = i + 1; j <uzunluk; j++)
                {
                    for (int k = 0; k < Operantlar.Length; k++)
                    {
                        int res = Operantlar[k].islem(DiziS[i], DiziS[j]);
                        if (res != 0)
                        {
                            int tut1 =DiziS[i], tut2 = DiziS[j];
                           DiziS[i] = res;
                            DiziS[j] = DiziS[uzunluk - 1];
                            if (Coz(DiziS,uzunluk - 1, h_sayi))
                            {
                                islemler.Add(Math.Max(tut1, tut2) + " " + Operantlar[k].sembol() + " " + Math.Min(tut1,tut2));
                                return true;
                            }
                            DiziS[i] = tut1;
                            DiziS[j] = tut2;
                        }
                    }
                }
            }
            return false;
        }
        public void Yazdır()
        {
            for (int i = islemler.Count- 1; i >= 0; i--)
            {
                Console.WriteLine(islemler[i].ToString());
               
               
            }

        }
    }
}
