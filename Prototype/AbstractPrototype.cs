using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Prototype
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class AbstractPrototype
    {
        private string _id;
        // Constructor
        public AbstractPrototype(string id)
        {
            this._id = id;
        }
        // Gets id
        public string Id
        {
            get { return _id; }
        }
        public abstract AbstractPrototype Clone();
    }
}
