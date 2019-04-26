using System;
using System.Collections.Generic;
using System.Text;

namespace HairDesigner.Dll
{

   public enum enPozisyon
    {
        GenelMudur = 1,
        Mudur = 2,
        DepartmanSorumlusu = 3,
        Isci = 4
    }

    public abstract class Calisan
    {
        public string Ad;
        public string Soyad;
        public enPozisyon Pozisyon;

        public Calisan(string ad, string soyad,enPozisyon pozisyon)
        {
            Ad = ad;
            Soyad = soyad;
            Pozisyon = pozisyon;

        }

        public abstract string Goster();

    }
    public class LeafCalisan:Calisan
    {
        public LeafCalisan(string ad, string soyad, enPozisyon pozisyon) : base(ad, soyad, pozisyon)
        {
        }

        public override string Goster()
        {
          return "Pozisyon :"+base.Pozisyon+" ad , soyad :" + base.Ad + base.Soyad +"\n";
        }
    }

    public class CompositeCalisan:Calisan
    {
        List<Calisan> Calisanlari;

        public CompositeCalisan(string ad, string soyad, enPozisyon pozisyon) : base(ad, soyad, pozisyon)
        {
            Calisanlari=new List<Calisan>();
        }
        public void Ekle(Calisan c)
        {
            Calisanlari.Add(c);
        }

        public void Sil(Calisan c)
        {
            Calisanlari.Remove(c);
        }

        public override string Goster()
        {
            string g = "Pozisyon :" + base.Pozisyon + " ad , soyad :" + base.Ad + base.Soyad + "\n";

            StringBuilder sb=new StringBuilder();

            foreach (var item in Calisanlari)
            {
                sb.Append(item.Goster()+"\n");
            }

            return g+sb.ToString();
        }



    }
}
