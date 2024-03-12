using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;
using System.Data.SQLite;

namespace StorageInterface
{
    public class SQLiteCommander : IDisposable
    {
        private bool disposed = false;

        SQLiteConnection sQLiteConnection = null;

        // The path to the SQLite Database
        private  readonly string sqlPath = @"Data Source=H:\SQLite\Lagerverwaltung\Lagerverwaltung.db;Version=3;";
        // The table name in the Database
        private  readonly string table = "Material";
        // Defines the SQLite SELECT statements by column. Lookup is only done via Key.
        // "AS" alias is for user benefit and display.
        private  static readonly ImmutableDictionary<string, string> columns = ImmutableDictionary.CreateRange(
            new Dictionary<string, string>
            {
                { "id", "itemID AS ID" },
                { "name", "name AS Description" },
                { "amount", "amount AS \"In Storage\"" }
            });

        // Defines the possible collumn & operator values for conditional SQLite lookup querries.
        // Keys are also shown as choices to the user.
        public  readonly ImmutableDictionary<string, Condition> SelectionChoices = ImmutableDictionary.CreateRange(
            new Dictionary<string, Condition>
            {
                { "Storage ID:", id },
                { "Description contains:", name },
                { "Amount greater than:", amountLarger },
                { "Amount less than:", amountLess },
                { "Amount equal to:", amountEqual }
            });
        private static readonly Condition id = new Condition(columns["id"].Split(' ')[0], "=", typeof(int));
        private static readonly Condition name = new Condition(columns["name"].Split(' ')[0], "LIKE", typeof(string));
        private static readonly Condition amountLarger = new Condition(columns["amount"].Split(' ')[0], ">=", typeof(int));
        private static readonly Condition amountLess = new Condition(columns["amount"].Split(' ')[0], "<=", typeof(int));
        private static readonly Condition amountEqual = new Condition(columns["amount"].Split(' ')[0], "=", typeof(int));


        #region Connection Pooling
        public SQLiteCommander()
        {
            sQLiteConnection = new SQLiteConnection(sqlPath);
        }

        public void CloseConnection()
        {
            sQLiteConnection.Close();
        }

        #endregion

        #region Readout
        /* Starts the process of building an SQL Request based on user selections,
         * then executes the request. If nothing is selected, gets the whole table,
         * but without the primary key.
         * The results of the request are returned.
         */
        public SQLiteDataReader ReadoutSQLite(
            IEnumerable<string> selectionCriteria = null, IEnumerable<GenericValueCondition> conditions = null)
        {   
            if (selectionCriteria == null || selectionCriteria.Count() == 0)
            {
                selectionCriteria = new string[] { SQLiteCommander.columns["id"],
                    SQLiteCommander.columns["name"], SQLiteCommander.columns["amount"] };
            }

            SQLiteDataReader dataReader;
            sQLiteConnection.Open();
            using (SQLiteCommand command = BuildSQLiteReadout(selectionCriteria, conditions))
            {
                    dataReader = command.ExecuteReader();
            }
            
            return dataReader;
        }

        /* Collects and formats the parameters for the SQL Request,
         * which are added to the command argument.
         * Which columns are read from the database can be adjusted,
         * possible conditions can be selected through user interaction
         * but are not required to be specified.
         */
        private SQLiteCommand BuildSQLiteReadout( 
            IEnumerable<string> selectionCriteria, IEnumerable<GenericValueCondition> optionalConditions = null)
        {
            SQLiteCommand command = new SQLiteCommand(sQLiteConnection)
            {
                CommandText = "SELECT " + string.Join(", ", selectionCriteria) + " FROM " + table
            };

            if (optionalConditions != null && optionalConditions.Count() > 0)
            {
                GenericValueCondition[] conditions = optionalConditions.ToArray();
                string[] formatedConditions = new string[conditions.Length];
                for (int i = 0; i < conditions.Length; i++)
                {
                    GenericValueCondition genericCondition = conditions[i];

                    formatedConditions[i] = genericCondition.Column + " " + genericCondition.Operator + " :param" + i;

                    SQLiteParameter parameter = command.CreateParameter();
                    command.Parameters.Add(parameter);
                    parameter.ParameterName = "param" + i;
                    parameter.SourceColumn = genericCondition.Column;

                    if (genericCondition.Type.Equals(typeof(string)))
                    {
                        parameter.Value = (genericCondition as ValueCondition<string>).Value;
                    }
                    else if (genericCondition.Type.Equals(typeof(int)))
                    {
                        parameter.Value = (genericCondition as ValueCondition<int>).Value;
                    }
                    else
                        throw new NotImplementedException("Condition Value-Type not implemented");
                }

                command.CommandText += " WHERE " + string.Join(" AND ", formatedConditions);
            }
            return command;
        }
        #endregion

        #region Update

        public int PushSQLiteUpdate(Item[] items)
        {
            int result = 0;

            if (items is null || items.Length == 0)
                return result;

            {
                sQLiteConnection.Open();
                foreach (Item element in items)
                {
                    using (SQLiteCommand command = BuildSQLiteUpdate(element))
                    {
                        result += command.ExecuteNonQuery();
                    }
                }
                sQLiteConnection.Close();
            }

            return result;
        }

        private SQLiteCommand BuildSQLiteUpdate(Item item)
        {
            string identifier = columns["id"].Split(' ')[0] 
                + " = " + item.StorageId;

            // This part could become dynamic
            string column = columns["amount"].Split(' ')[0];
            int value = item.Amount;

            string sumClause = "";
            if (!item.Overwrite)
                sumClause = column + " + ";

            SQLiteCommand command = new SQLiteCommand(sQLiteConnection)
            {
                CommandText = "UPDATE " + table 
                    + " SET " + column + " = " + sumClause + value
                    + " WHERE " + identifier
            };

            return command;
        }

        #endregion

        #region Insert

        public string AddNewEntry(int storageId, string name, int amount = 0)
        {
            string error = "";
            sQLiteConnection.Open();
            SQLiteCommand command = BuildSQLiteInsert(storageId, name, amount);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                error = e.Message;
            }
            sQLiteConnection.Close();

            return error;
        }

        private SQLiteCommand BuildSQLiteInsert(int storageId, string name, int amount)
        {
            SQLiteCommand command = new SQLiteCommand(sQLiteConnection)
            {
                CommandText = "INSERT INTO " + table + " ("
                    + columns["id"].Split(' ')[0] + ", "
                    + columns["name"].Split(' ')[0] + ", "
                    + columns["amount"].Split(' ')[0] + ")\n"
                    + "VALUES ("
                    + storageId + ", "
                    + "'" + name + "', "
                    + amount + ");"
            };

            return command;
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // clean up managed objects
                    if (!(sQLiteConnection is null))
                        sQLiteConnection.Dispose();
                }

                // clean up unmanaged objects

                disposed = true;
            }
        }
        #endregion
    }
}
