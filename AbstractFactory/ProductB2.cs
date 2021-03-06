﻿namespace AbstractFactory
{
    using System;

    /// <summary>
    /// The product b 2.
    /// </summary>
    class ProductB2 : AbstractProductB
    {
        /// <summary>
        /// The interact.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}