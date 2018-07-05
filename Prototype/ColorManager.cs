using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Prototype_
{
    /// <summary>
    /// Prototype manager
    /// </summary>
    class ColorManager
    {
        private Dictionary<string, AbstractColor> _colors =
          new Dictionary<string, AbstractColor>();
        // Indexer
        public AbstractColor this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
