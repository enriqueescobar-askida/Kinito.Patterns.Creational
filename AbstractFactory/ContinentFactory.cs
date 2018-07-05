namespace AbstractFactory
{
    /// <summary>
    /// The continent factory.
    /// </summary>
    abstract class ContinentFactory
    {
        /// <summary>
        /// The create herbivore.
        /// </summary>
        /// <returns>
        /// The <see cref="Herbivore"/>.
        /// </returns>
        public abstract Herbivore CreateHerbivore();

        /// <summary>
        /// The create carnivore.
        /// </summary>
        /// <returns>
        /// The <see cref="Carnivore"/>.
        /// </returns>
        public abstract Carnivore CreateCarnivore();
    }
}