using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RestTECService.Data
{
    public class SQLite
    {
        public SQLiteConnection connection { get; set; }
        public SQLiteCommand cmd { get; set; }
        public SQLiteDataReader reader { get; set; }

    }
}
