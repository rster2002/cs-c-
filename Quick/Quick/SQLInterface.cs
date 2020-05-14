using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Quick {
    namespace SQLInterface {
        public class SQLInterface {
            private string config;
            private string queryString;
            private static string globalConfigString = "";

            private Dictionary<string, string> sqlParams = new Dictionary<string, string>();

            public SQLInterface() {
                config = globalConfigString;
            }

            public SQLInterface(string connectionString) {
                config = connectionString;
            }

            public static void setGlobalConfigString(string input) {
                globalConfigString = input;
            }

            public SQLInterface param(string key, object value) {
                sqlParams.Add(key, value.ToString());
                return this;
            }

            public SQLInterface query(string queryString) {
                this.queryString = queryString;
                return this;
            }

            public SQLInterface line(string queryLine) {
                queryString += " " + queryLine;
                return this;
            }

            public SQLInterface clear() {
                queryString = null;
                sqlParams = new Dictionary<string, string>();

                return this;
            }

            private void evaluateParameters(SqlCommand command) {
                foreach (KeyValuePair<string, string> parameter in sqlParams) {
                    command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
                }

                sqlParams = new Dictionary<string, string>();
            }

            public void executeCommand() => executeCommand(queryString);
            public void executeCommand(string query) {
                using (SqlConnection sqlConnection = new SqlConnection(config)) {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);

                    evaluateParameters(command);

                    command.ExecuteNonQuery();

                    clear();
                }
            }

            public List<Dictionary<string, object>> executeSelect() => executeSelect(queryString);
            public List<Dictionary<string, object>> executeSelect(string query) {
                using (SqlConnection sqlConnection = new SqlConnection(config)) {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);

                    List<Dictionary<string, object>> records = new List<Dictionary<string, object>>();

                    evaluateParameters(command);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) {
                        Dictionary<string, object> record = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++) {
                            record[reader.GetName(i)] = reader.GetValue(i);
                        }

                        records.Add(record);
                    }

                    clear();

                    return records;
                }
            }

            public List<Dictionary<string, object>> execute() => execute(queryString);
            public List<Dictionary<string, object>> execute(string query) {
                List<Dictionary<string, object>> returnValue = new List<Dictionary<string, object>>();

                if (queryString.Contains("SELECT") && queryString.Contains("FROM")) {
                    returnValue = executeSelect(query);
                } else {
                    executeCommand(query);
                }

                return returnValue;
            }
        }
    }
}
