using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using System.Threading;

namespace HairDesigner.Dll
{
    public interface IImageGoster
    {
        string ShowImage();
    }

    public class ImageGoster : IImageGoster
    {
        public string ShowImage()
        {
            return  @"C: \Users\tugba.bicakci\source\repos\KuaforSalonApp\KuaforSalonForm\img\Kua.jpg";
        }
    }

    public class ImageProxy : IImageGoster
    {
        private ImageGoster _generator;
        private Timer t;
        private bool LoadRealObject = false;
        private void ShowRealImage(object o)
        {
            _generator = new ImageGoster();
            _generator.ShowImage();
            LoadRealObject = true;
        }

        public string ShowImage()
        {
            if (_generator == null)
            {
                //burada başka bir threadda asıl nesnenin yüklenmesinin başlatıldığını düşünebiliriz.
                t = new System.Threading.Timer(new TimerCallback(ShowRealImage), this, 20000, 0);


            }

            if (!LoadRealObject) //gerçek nesne yüklenmesi tamamlanmamış ise önizleme resmi gösterilsin.
                return @"C:\Users\tugba.bicakci\source\repos\KuaforSalonApp\KuaforSalonForm\img\timer.jpg";

            return "Hoşgeldin !";
        }


    }


}
