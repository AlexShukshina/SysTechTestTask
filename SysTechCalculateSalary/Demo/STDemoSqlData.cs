using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows;

namespace SysTechCalculateSalary
{
    public class STDemoSqlData
    {
        
        private static string db_name = "Employees.db3";
        private static string db_connection_string = "data source = Employees.db3;FailIfMissing=True;";
        public static void CreateDemoDataBase()
        {
            string createGroupsQuery = @"CREATE TABLE SysTechGroups (
                                       id INTEGER PRIMARY KEY ASC AUTOINCREMENT,
                                       name STRING
                                       ); ";

            string createEmployeesQuery = @"CREATE TABLE Employees (
                                   id INTEGER PRIMARY KEY ASC AUTOINCREMENT,
                                   name  VARCHAR(100)   NOT NULL,
                                   [group] INTEGER REFERENCES SysTechGroups (ID),
                                   baserate      DOUBLE,
                                   datestart     DATE,
                                   parent_id      INTEGER
                                  );";

            string insertGroupsData = @"INSERT INTO SysTechGroups (id, name)
                                      VALUES (1, 'Employee'),
                                             (2, 'Manager'),
                                             (3, 'Salesman');";


            string insertEmployeesData = @"INSERT INTO Employees (id, name, [group], baserate, datestart, parent_id)
                                      VALUES (1, 'employee1', 1, 4500, '1996-03-26', 7),
                                             (2, 'employee2', 1, 4500, '1996-03-26', 7),
                                             (3, 'employee3', 1, 4500, '1996-03-26', 8),
                                             (4, 'employee4', 1, 4500, '2016-03-26', 9),
                                             (5, 'employee5', 1, 4500, '2016-03-26', 9),
                                             (6, 'employee6', 1, 4500, '1996-03-17', 10),
                                             (7, 'manager1', 2, 17200, '1996-03-17', 8), 
                                             (8, 'salesman1', 3, 17200, '1996-03-17', 11),
                                             (9, 'manager2', 2, 17200, '1996-03-17', 11),
                                             (10, 'manager3', 2, 17200, '1996-03-17', 11),
                                             (11, 'manager4', 2, 17200, '2016-03-25', NULL);";



            try 
            { 
                    using (SQLiteConnection conn = new SQLiteConnection(db_connection_string)) 
                         conn.Open();
            }
            catch(SQLiteException dbnotfoundEx) 
            {
                SQLiteConnection.CreateFile(db_name);
                using (SQLiteConnection conn = new SQLiteConnection(db_connection_string)) {
                    using (SQLiteCommand cmd = new SQLiteCommand(conn)) {
                        conn.Open();
                        cmd.CommandText = createGroupsQuery;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = createEmployeesQuery;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = insertGroupsData;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = insertEmployeesData;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            
          
        }

        public static DataTable GetDataFromDataBase()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection cnn = new SQLiteConnection(db_connection_string))
            {
                cnn.Open();
                SQLiteCommand getComm = new SQLiteCommand(cnn);
                getComm.CommandText = "Select * from Employees";
                using (SQLiteDataReader reader = getComm.ExecuteReader())
                {
                    dt.Load(reader);
                }
                cnn.Close();
            }
            return dt;
        }

        public static void InsertEmployeeInDataBase(string name, int group, double baserate, DateTime datestart, int? parent_id) 
        {
            string values = string.Format("'{0}',{1},{2},'{3}',{4}", name, group, baserate, datestart.ToString("yyyy-MM-dd"), parent_id);
            if (parent_id == null)
                values = string.Format("'{0}',{1},{2},'{3}',null", name, group, baserate, datestart.ToString("yyyy-MM-dd"));
            string Query = string.Concat("INSERT INTO Employees (name, [group], baserate, datestart, parent_id) VALUES (",
                                                                     values,
                                                                     ");");


                using (SQLiteConnection conn = new SQLiteConnection(db_connection_string)) {
                    using (SQLiteCommand cmd = new SQLiteCommand(conn)) {
                        conn.Open();
                        cmd.CommandText = Query;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
   


        }



    }
}
