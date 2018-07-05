using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Builder
{
    public class ConcreteBuilder2 : AbstarctBuilder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            this._product.Add("PartX");
        }
        public override void BuildPartB()
        {
            this._product.Add("PartY");
        }
        public override Product GetResult()
        {
            return this._product;
        }
    }
}
