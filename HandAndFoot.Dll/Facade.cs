using System;
using System.Collections.Generic;
using System.Text;

namespace HairDesigner.Dll
{
    public class SalonKapanisİslemleri
    {
        protected SalonSupur _salonSupur;
        protected SalonSil _salonSil;
        protected SalonMalzemeBakım _salonMalzemeBakım;

        public SalonKapanisİslemleri(SalonSupur salonSupur,SalonSil salonSil,SalonMalzemeBakım salonMalzemeBakım)
        {
            _salonSupur = salonSupur;
            _salonSil = salonSil;
            _salonMalzemeBakım = salonMalzemeBakım;
        }

        public string Operations()
        {
            string result = "Salon Kapanış işleri : \n";
            result += this._salonSupur.Operation() +"\n";
            result += this._salonSil.Operation() + "\n";
            result += this._salonMalzemeBakım.Operation() + "\n";

            return result;
        }

    }


    public class SalonSupur
    {
        public string Operation()
        {
            return "Temizlik gerçekleşti";
        }

      
    }

    public class SalonSil
    {
        public string Operation()
        {
            return "Salon Silme Gerçekleşti .";
        }
    }

    public class SalonMalzemeBakım
    {
        public string Operation()
        {
            return "Salon Malzeme Bakım Gerçekleşti";
        }

    }





}
