using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace HairDesigner.Dll
{
    public interface ISacKesim
    {
        string SacKesim();

    }

    public class DuzSacKesim : ISacKesim
    {
        public string SacKesim()
        {
            return "Kısa Boyut düz saç kesim";
        }


    }

    public class KatliSacKesim : ISacKesim
    {
        public string SacKesim()
        {
            return "Kısa Boyut katlı saç kesim";
        }


    }

    public class SacKesimBoya
    {
        public ISacKesim SacKesim { get; private set; }

        public SacKesimBoya(ISacKesim _SacKesim)
        {
            SacKesim = _SacKesim;
        }
       
        public virtual string BoyamaIslemi()
        {
           return SacKesim.SacKesim();

        }

    }

    public class KesimOmbre:SacKesimBoya
    {
        public KesimOmbre(ISacKesim _SacKesim) : base(_SacKesim)
        {
        }

        public override string BoyamaIslemi()
        {
            return "Düz saç kesim + Ombre Uygulaması";
            base.BoyamaIslemi();
        }
    }

    public class KesimIsilti:SacKesimBoya
    {
        public KesimIsilti(ISacKesim _SacKesim) : base(_SacKesim)
        {
        }

        public override string BoyamaIslemi()
        {
            return "Katlı Kesim +Isıltı Uygulaması";
            base.BoyamaIslemi();
        }
    }
}
