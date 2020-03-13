using System;
using System.Collections.Generic;
using Bookish.Models.Users;
using Dapper;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Bookish.Models
{
    public interface IDbServices
    {
        public static MySqlConnection ConnectToDb() { 
            var server = "localhost";
            var database = "bookishdb";
            var uid = "EmmFox";
            var password = "Astrid2014";
            string serverConnection = "Server=" + server + ";" + "Database=" + 
                                      database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            using MySqlConnection connection = new MySqlConnection(serverConnection);
            return connection;
        }
       
    }
   
   
}