using System;
using System.Net.Http.Headers;

namespace HandAndFoot.Dll
{
    public interface IHandAndFoot
    {
        INailCare CreateNail();
        ISkinCare CreateSkinCare();

    }



    public class ModernFactory : IHandAndFoot
    {
        public INailCare CreateNail()
        {
            return new ModernNailCare();
        }

        public ISkinCare CreateSkinCare()
        {
            return new ModernSkinCare();
        }
    }

    public class ClassicFactory : IHandAndFoot
    {
        public INailCare CreateNail()
        {
            return new ClassicNailCare();
        }

        public ISkinCare CreateSkinCare()
        {
            return new ClassicSkinCare();
        }
    }

    public interface INailCare
    {
        string NailArt();
    }

    public class ModernNailCare : INailCare
    {
        public string NailArt()
        {
            return "Modern tırnak uygulaması gerçekleşti";
        }
    }

    public class ClassicNailCare : INailCare
    {
        public string NailArt()
        {
            return "Classic tırnak uygulaması gerçekleşti";
        }
    }

    public interface ISkinCare
    {
        string SkinCare();
    }

    public class ModernSkinCare : ISkinCare
    {
        public string SkinCare()
        {
            return "Modern Cilt bakımı yapıldı";
        }
    }

    public class ClassicSkinCare : ISkinCare
    {
        public string SkinCare()
        {
            return "Classic cilt bakımı yapıldı";
        }
    }

    public class Costum
    {


        public string CostumMethod(IHandAndFoot handAndFoot)
        {
            var m = handAndFoot.CreateNail();
            var a = handAndFoot.CreateSkinCare();
          string s=  m.NailArt()+"-daha sonrasında-"+a.SkinCare();
          return s;

        }
    }

}
