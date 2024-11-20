using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Interface.ExtendedTool.Connect_and_query
{




    internal class RealConnect : IConnect
    {
        public string CreateConnectionString()
        {
            throw new NotImplementedException();
        }

        //public string CreateConnectionString()
        //{
        //    DBdata? dBdata = JSONReader.bdata();
        //    if (dBdata != null)
        //    {
        //    }
        //    else { 
        //    }
        //}

        public MySqlConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
