﻿using MySql.Data.MySqlClient;

namespace User_Interface.ExtendedTool.Connect_and_query
{
    internal interface IConnect
    {
        
        void CreateConnectionString();
        MySqlConnection GetConnection();

    }
}