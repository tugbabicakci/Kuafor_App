using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HairDesigner.Dll
{
    public class XBankReadCart
    {
        public string ReadFromCart()
        {
            return "X POS makinesi çalışıyor";
        }
    }

    public class YBankReadCart
    {
        public string ReadFromCart()
        {
            return "Y POS makinesi çalışıyor";
        }
    }


    public interface ICartReaderAdapter
    {
        string ReadCartData();
    }

   

    public class XBankCartReader : ICartReaderAdapter
    {
        public string ReadCartData()
        {
           XBankReadCart xBank=new XBankReadCart();
           return xBank.ReadFromCart();

        }
    }

    public class YBankCartReader : ICartReaderAdapter
    {
        public string ReadCartData()
        {
           YBankReadCart yBank=new YBankReadCart();
           return yBank.ReadFromCart();
        }
    }
}
