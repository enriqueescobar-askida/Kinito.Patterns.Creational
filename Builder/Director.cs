using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public class Director
    {
        // Builder uses a complex series of steps
        /// <summary>
        /// Constructs the specified builder.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public void Construct(AbstarctBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
