using System;

namespace Constructor
{
    public static class Connection
    {
        public static Lazy<NeuralNetworkConstructorEntities> Db { get; set; }

        static Connection()
        {
            Db = new Lazy<NeuralNetworkConstructorEntities>();
        }
    }
}
