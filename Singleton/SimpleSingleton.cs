using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public sealed class SimpleSingleton
    {
        private SimpleSingleton() { }
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static SimpleSingleton GetInstance()
        {
            return NestedSingleton.singleton;
        }
        /// <summary>
        /// 
        /// </summary>
        class NestedSingleton
        {
            internal static readonly SimpleSingleton singleton = new SimpleSingleton();
            /// <summary>
            /// Initializes the <see cref="NestedSingleton"/> class.
            /// </summary>
            static NestedSingleton() { }
        }
    }
}
