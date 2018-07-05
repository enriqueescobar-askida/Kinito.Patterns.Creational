using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public sealed class EagerSingleton
    {
        #region AttributeMembers
        #region PublicAttributes
        #endregion
        #region PrivateAttributes
        private static readonly EagerSingleton singleton = new EagerSingleton();  // eager
        #endregion
        #region ProtectedAttributes
        #endregion
        #endregion
        #region AttributeAccessors
        #region Getters
        #endregion
        #region Setters
        #endregion
        #region Mutators
        #endregion
        #endregion
        #region Constructors
        /// <summary>
        /// Initializes the <see cref="EagerSingleton"/> class.
        /// </summary>
        static EagerSingleton()
        {
            Console.WriteLine("Singleton instantiated");
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EagerSingleton"/> class.
        /// </summary>
        private EagerSingleton() { } // private constructor
        #endregion
        #region Destructor
        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="EagerSingleton"/> is reclaimed by garbage collection.
        /// </summary>
        ~EagerSingleton()
        {
        }
        #endregion
        #region MethodMembers
        #region PrivateMethods
        #endregion
        #region PublicMethods
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static EagerSingleton GetInstance()
        {
            //if (singleton == null)
            //{
            //    singleton = new EagerSingleton(); //lazy
            //    Console.WriteLine ("EagerSingleton instantiated");
            //}
            return singleton;
        }
        #region PublicAbstractMethods
        #endregion
        #region PublicOverrideMethods
        #endregion
        #region PublicVirtualMethods
        #endregion
        #endregion
        #endregion
    }
}
