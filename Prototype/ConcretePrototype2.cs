using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Prototype
{
    /// <summary>
    /// A 'ConcretePrototype' class
    /// </summary>
    class ConcretePrototype2 : AbstractPrototype
    {
        // Constructor
        public ConcretePrototype2(string id)
            : base(id)
        {
        }
        // Returns a shallow copy
        public override AbstractPrototype Clone()
        {
            return (AbstractPrototype)this.MemberwiseClone();
        }
    }
}
