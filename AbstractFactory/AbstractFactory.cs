namespace AbstractFactory
{
    /// <summary>
    /// The abstract factory.
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// The create product a.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractProductA"/>.
        /// </returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary>
        /// The create product b.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractProductB"/>.
        /// </returns>
        public abstract AbstractProductB CreateProductB();
    }
}