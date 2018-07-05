using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public class Product
    {
        private List<string> _parts = new List<string>();
        /// <summary>
        /// Adds the specified part.
        /// </summary>
        /// <param name="part">The part.</param>
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        /// <summary>
        /// Shows this instance.
        /// </summary>
        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in this._parts)
                Console.WriteLine(part);
        }
    }
}
