using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Dll
{
 

    public interface IHandAndFoot
        {
            INailArt CreateNail();
            ISkinCare CreateSkinCare();

        }



        public class ModernFactory : IHandAndFoot
        {
            public INailArt CreateNail()
            {
                return new ModernNailArt();
            }

            public ISkinCare CreateSkinCare()
            {
                return new ModernSkinCare();
            }
        }

        public class ClassicFactory : IHandAndFoot
        {
            public INailArt CreateNail()
            {
                return new OmbreNailArt();
            }

            public ISkinCare CreateSkinCare()
            {
                return new ClassicSkinCare();
            }
        }

        public interface INailArt
        {
            string NailArt();
        }

        public class ModernNailArt : INailArt
        {
            public string NailArt()
            {
                return "Modern tırnak uygulaması gerçekleşti";
            }
        }

        public class OmbreNailArt : INailArt
        {
            public string NailArt()
            {
                return "Omre tırnak uygulaması gerçekleşti";
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

    }

