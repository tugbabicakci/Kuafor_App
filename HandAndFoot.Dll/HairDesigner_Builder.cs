using System;
using System.Collections.Generic;

namespace SacTasarım.Dll
{


    public class Director
    {
        public void Call(TopuzModelTasarım topuzModelTasarım)
        {
            topuzModelTasarım.SacTara();
            topuzModelTasarım.SpreySık();
            topuzModelTasarım.TokaTak();
        }
    }


    public abstract class TopuzModelTasarım
    {
        public abstract void SacTara();
        public abstract void SpreySık();
        public abstract void TokaTak();
        public abstract Product ProductGetResult();

    }

     public class DugunTopuz : TopuzModelTasarım
    {
        private Product _product = new Product();

        public override Product ProductGetResult()
        {
            return _product;
        }

        public override void SacTara()
        {
          _product .Add("Dugun Topuz Sac Tara");
        }

        public override void SpreySık()
        {
           _product.Add("Dugun Topuz Sprey Sık");
        }

        public override void TokaTak()
        {
          _product.Add("Dugun Topuz Toka Tak");
        }
    }

   public   class DagınıkTopuz : TopuzModelTasarım
    {
        private Product _product = new Product();

        public override Product ProductGetResult()
        {
            return _product;
        }

        public override void SacTara()
        {
            _product.Add("Dagınık Topuz Sac Tara");

        }
        

        public override void SpreySık()

        {
            _product.Add("Dagınık Topuz Sprey Sık");
               }

        public override void TokaTak()
        {
            _product.Add("Dagınık Topuz Toka Tak");
        }
    }

    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {

            _parts.Add(part);

        }

        public List<string> Show()
        {
            return _parts;
        }
           
        
       
    }
}
