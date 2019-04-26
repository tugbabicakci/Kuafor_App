using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforCostumer;

namespace KuaforSalonForm
{
    public class MemoApp
    {

        public List<KuaforCostumer.Client> Test(List<KuaforCostumer.Client> clients)
        {
            var test = clients;

            foreach (Client usr in test)
            {
                usr.Name = "memo";
            }

            return test;
        }

        public string Test(string name)
        {
            var test = name;

            test = "memo";

            return test;
        }

    }


}
