using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Prototype_
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class AbstractColor
    {
        public abstract AbstractColor Clone();
    }
}
