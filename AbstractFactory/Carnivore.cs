namespace AbstractFactory
{
    /// <summary>
    /// The carnivore.
    /// </summary>
    abstract class Carnivore
    {
        /// <summary>
        /// The eat.
        /// </summary>
        /// <param name="h">
        /// The h.
        /// </param>
        public abstract void Eat(Herbivore h);
    }
}
