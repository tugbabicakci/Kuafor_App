using System;
using System.Collections.Generic;
using System.Text;

namespace HandAndFootAbstract.Dll
{
    public interface INail
    {
        string CreateNail();

    }

    public class NailArt : INail
    {
        public string CreateNail()
        {
            return "Nail art üretildi";
        }
    }

    public class NailPaint : INail
    {
        public string CreateNail()
        {
            return "Nail Paint üretildi";
        }
    }


    public abstract class Creator
    {
        public abstract INail Nail();

        public string Operation()
        {
            var pr = Nail();
            var result = "Sonuc : " + pr.CreateNail();
            return result;
        }
    }

    public class NailArtConcreate : Creator
    {
        public override INail Nail()
        {
            return new NailArt();
        }
    }

    public class NailPaintConcreate : Creator
    {
        public override INail Nail()
        {
            return new NailPaint();
        }
    }


    public class NailClient
    {
        public string ClientMethod(Creator creator)
        {
            return  creator.Operation();
        }
    }

}
