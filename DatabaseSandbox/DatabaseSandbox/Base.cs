using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseSandbox {
    class BaseSQL {
        private string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        private string queryString;
        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void param(string key, object value) {
            parameters.Add(key, value);
        }

        private void clearParams() {
            parameters.Clear();
        }

        private void query(string queryString) {
            this.queryString = queryString;
        }

        private void clearQuery() {
            queryString = null;
        }

        private void clear() {
            clearParams();
            clearQuery();
        }

        private List<Dictionary<string, object>> execute() {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString)) {
                List<Dictionary<string, object>> records = new List<Dictionary<string, object>>();

                sqlConnection.Open();
                SqlCommand command = new SqlCommand(queryString, sqlConnection);

                foreach (KeyValuePair<string, object> keyValue in parameters) {
                    command.Parameters.AddWithValue(keyValue.Key, keyValue.Value);
                }

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
    }
}
