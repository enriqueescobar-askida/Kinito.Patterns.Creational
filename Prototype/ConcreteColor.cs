using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Prototype_
{
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class ConcreteColor : AbstractColor
    {
        private int _red;
        private int _green;
        private int _blue;
        // Constructor
        public ConcreteColor(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }
        // Create a shallow copy
        public override AbstractColor Clone()
        {
            Console.WriteLine(
              "Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);
            return this.MemberwiseClone() as AbstractColor;
        }
    }
}
