using System;

namespace KuaforCostumer
{
    public class Client
    {
        public string Name;
        public string Surname;

        public Client()
        {
            
        }
        public Client(string name,string lastname)
        {
            var retVal = new Client
            {
                Name = name,
                Surname = lastname
            };
        }

        public Client ShallowCopy()
        {
            return (Client)this.MemberwiseClone();
        }

        public Client DeepCopy()
        {
            Client clone = (Client)this.MemberwiseClone();
            clone.Name = String.Copy(Name);
            clone.Surname=String.Copy(Surname);
         

            return clone;
        }

        public string GetFullName()
        {
            return string.Format("{0} {1}", this.Name, this.Surname);
        }

        
    }

  
}
