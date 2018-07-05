using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Builder
{
    public class ConcreteBuilder1 : AbstarctBuilder
    {
        private Product _product = new Product();
        /// <summary>
        /// Builds the part A.
        /// </summary>
        public override void BuildPartA()
        {
            this._product.Add("PartA");
        }
        /// <summary>
        /// Builds the part B.
        /// </summary>
        public override void BuildPartB()
        {
            this._product.Add("PartB");
        }
        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns></returns>
        public override Product GetResult()
        {
            return this._product;
        }
    }
}
