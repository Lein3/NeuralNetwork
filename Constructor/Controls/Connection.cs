using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
