﻿/*
 *  Copyright (c) 2015-2016 Vitaleks
 *  Copyright (c) 2015 Edmundas919
 *  Copyright (c) 2015 mc3dcm
 * 
 *  This file is part of NFS World Server.
 *
 *  NFS World Server is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *  
 *  NFS World Server is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with NFS World Server.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalServerSolution
{
    class MsSQL
    {
        private static MsSQL instance;

        private MySqlConnection connection;
        private MySqlConnection connection2;

        public static string connetionString = "";

        private MsSQL()
        {
            connection = new MySqlConnection(connetionString);
            connection2 = new MySqlConnection(connetionString);
            OpenConnection();
        }

        public static MsSQL Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new MsSQL();
                }
                return instance;
            }
        }

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }
        }

        public MySqlConnection Connection2
        {
            get
            {
                return connection2;
            }
        }

        public void OpenConnection()
        {
            connection.Open();
            connection2.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
