using System;
using System.Collections.Generic;
using System.Text;

namespace HairDesigner.Dll
{
    //Subject
   public abstract class absUrun
    {
        public string UrunAdi { get; set; }
        private decimal _Fiyat;

       

        public List<IUye> TakipList = new List<IUye>();
        public absUrun(string UrunAd, decimal UrunFiyat)
        {
            this.UrunAdi = UrunAd;
            this._Fiyat = UrunFiyat;
        }
        public decimal Fiyat
        {
            get { return _Fiyat; }
            set
            {
                //fiyat düşmüşse üyelere haber ver

                if (_Fiyat > value)
                    NotifyUrun();
                _Fiyat = value;
            }
        }
        public void NotifyUrun()
        {
            foreach (IUye item in TakipList)
            {
                item.Update(this);
            }
        }
    }
    //ConcreteSubject
   public class Urun : absUrun
    {
        public Urun(string UrunAd, decimal Fiyat)
            : base(UrunAd, Fiyat)
        {
        }
    }
    //Observer
 public   interface IUye
    {
        string Update(absUrun urun);
    }
    //ConcreteObserver
  public  class Uye : IUye
    {
        public string E_Mail { get; set; }
        public string Update(absUrun u)
        {
          return " email adresine gönderildi."+ u.UrunAdi+"-"+ u.Fiyat.ToString("C2")+"-"+E_Mail;
        }
    }
}
