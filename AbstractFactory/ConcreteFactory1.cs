namespace AbstractFactory
{
    /// <summary>
    /// The concrete factory 1.
    /// </summary>
    class ConcreteFactory1 : AbstractFactory
    {
        /// <summary>
        /// The create product a.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractProductA"/>.
        /// </returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        /// <summary>
        /// The create product b.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractProductB"/>.
        /// </returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}