using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Mutable_Immutable
{
    class Program
    {
        class Deneme
        {
            private string name;
            private int yas;

            public string Name
            {
                get => name;
                set => name = value;
            }

            public int Yas
            {
                get => yas;
                set => yas = value;
            }
        }

        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();
            Deneme deneme2 = new Deneme();
            deneme.Name = "tugba";
            deneme2.Name = "tugba2";


            //Referans tipinde sadece adresler eşitlendi.Yani değer değişimi her iki nesneyi etkiler.
            deneme2 = deneme;

            deneme2.Yas = 44;


            deneme.Yas = 55;
            //Değer tipi sadece kopyalama işi yapar .Daha sonraki değişikler iki değişkeni etkilemez
            // Değiştirilen değişken değişir sadece .

            int yas = deneme.Yas;
            yas = 66;

            Console.WriteLine(deneme.Yas);
            Console.WriteLine(deneme2.Yas);
            Console.WriteLine(yas);
            Console.WriteLine(deneme.Name);
            Console.WriteLine(deneme2.Name);

        }
    }
}
