namespace AbstractFactory
{
    /// <summary>
    /// The client.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The _abstract product a.
        /// </summary>
        private readonly AbstractProductA abstractProductA;

        /// <summary>
        /// The _abstract product b.
        /// </summary>
        private readonly AbstractProductB abstractProductB;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="factory">
        /// The factory.
        /// </param>
        public Client(AbstractFactory factory)
        {
            this.abstractProductB = factory.CreateProductB();
            this.abstractProductA = factory.CreateProductA();
        }

        /// <summary>
        /// The run.
        /// </summary>
        public void Run()
        {
            this.abstractProductB.Interact(this.abstractProductA);
        }
    }
}