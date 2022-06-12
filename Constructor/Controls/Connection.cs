using System;

namespace Constructor
{
    public static class Connection
    {
        public static Lazy<NeuralNetworkConstructorEntities> db { get; set; }

        static Connection()
        {
            db = new Lazy<NeuralNetworkConstructorEntities>();
        }
    }
}
