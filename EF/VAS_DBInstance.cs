using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class VAS_DBInstance
    {
        public VAS_DBEntities Database { get; private set; }
        private static VAS_DBInstance instance;
        private VAS_DBInstance()
        {
            Database = new VAS_DBEntities();
        }
        public static VAS_DBInstance Instance => instance ?? (instance = new VAS_DBInstance());
    }
}
