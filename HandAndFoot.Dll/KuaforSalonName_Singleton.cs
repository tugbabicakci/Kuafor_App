using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuaforSalonForm
{
   public class KuaforSalonName_Singleton
    {

        private KuaforSalonName_Singleton(){}

        public static KuaforSalonName_Singleton _instance=null;
        public static KuaforSalonName_Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                  
                        if (_instance == null)
                        {
                            _instance = new KuaforSalonName_Singleton();
                        }
                    
                }
                return _instance;
            }
        }

        public string GetName()
        {
            return "Abidik Gubidik Kuaforre Hoşgeldin";
        }

    }
}
