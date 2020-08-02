using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAppV1._1
{
    class AccessSQLite
    {
        public static List<Items_products> LoadItems()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Items_products>("SELECT * FROM items_products", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveItems(Items_products items_Products)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into items_products (name, barcode, price, quantity) values (@name, @barcode, @price, @quantity)", items_Products);
            }

        }
        public static void UpdateDatabase(Items_products store_inventory)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE items_products SET quantity = " + store_inventory.quantity + " WHERE id = " + store_inventory.id + ";");
            }
        }

        public static List<Items_products> searchDatabase(string search)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Items_products>("SELECT * FROM items_products" + search, new DynamicParameters());
                return output.ToList();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {//added the name of the SQLite database in the App.Configuration file
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;

        }
    }
}
