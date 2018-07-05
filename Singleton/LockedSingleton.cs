using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public sealed class LockedSingleton
    {
        #region AttributeMembers
        #region PublicAttributes
        #endregion
        #region PrivateAttributes
        private static LockedSingleton singleton = null;
        private static readonly object singletonLock = new object();
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
        /// Initializes a new instance of the <see cref="LockedSingleton"/> class.
        /// </summary>
        private LockedSingleton()
        {
        }
        #endregion
        #region Destructor
        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="LockedSingleton"/> is reclaimed by garbage collection.
        /// </summary>
        ~LockedSingleton()
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
        public static LockedSingleton GetInstance()
        {
            lock (singletonLock)
            {
                if (singleton == null)
                {
                    singleton = new LockedSingleton();
                }
                return singleton;
            }
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
