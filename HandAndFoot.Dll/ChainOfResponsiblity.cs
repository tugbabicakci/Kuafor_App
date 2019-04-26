using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HairDesigner.Dll
{
    public abstract class PlayerHandler
    {
        protected PlayerHandler _SonrakiHandler;

        public PlayerHandler SonrakiHandler
        {
            set { _SonrakiHandler = value; }
        }

        public abstract string Play(string filePath);
    }

    public class ConcreteHandlerMp4 : PlayerHandler
    {
        public override string Play(string filePath)
        {
            /*.mp4 uzantılı dosya ise bu sınıf cevap verir*/
            if (filePath.EndsWith(".mp4"))

              return ".. dosyası oynatılıyor(mp4 player)..."+ filePath;
            else
            {
                /*.mp4 uzantılı dosya değil ise _SonrakiHandler a isteği gönder*/
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Play(filePath);
            }

            return "sonraki";
        }
    }

    public class ConcreteHandlerMpg : PlayerHandler
    {
        public override string Play(string filePath)
        {
            /*.mpg uzantılı dosya ise bu sınıf cevap verir*/
            if (filePath.EndsWith(".mpg"))
              return " ..  dosyası oynatılıyor(mpg player)..."+ filePath;
            else
            {
                /*.mpg uzantılı dosya değil ise _SonrakiHandler a isteği gönder*/
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Play(filePath);
            }

            return "Sonraki";
        }

    }

    public class ConcreteHandlerAvi : PlayerHandler
    {
        public override string Play(string filePath)
        {
            /*.avi uzantılı dosya ise bu sınıf cevap verir*/
            if (filePath.EndsWith(".avi"))
                return ".. dosyası oynatılıyor(avi player)..."+
            filePath;
            else /*isteğe cevap verebilecek son sınıf bu olduğundan .avi uzantılı değil ise hata ver*/
               return ".. Geçersiz Dosya Formatı"+filePath;

            return "sonraki";
        }
    }
}