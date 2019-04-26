using System;

namespace KuaforCostumer
{
    public class Client
    {
        public string Name;
        public string Surname;

     

        public Client ShallowCopy()
        {
            return (Client)this.MemberwiseClone();
        }

        public Client DeepCopy()
        {
            Client clone = (Client)this.MemberwiseClone();
            clone.Name = String.Copy(Name);
         

            return clone;
        }



    }

  
}
