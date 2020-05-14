using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Quick.SQLInterface;
using System.Security.Cryptography;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.Win32;

namespace DatabaseSandbox {
    public class StaffDAO: SQLInterface<Staff> {
        public List<Staff> getAll() {
            line("FROM [Staff]");
            

            return execute();
        }

        public Staff getById(int id) {
            line("SELECT *");
            line("FROM [Staff]");
            line("WHERE [StaffNumber] = @id");

            param("id", id);

            return execute()[0];
        }

        private List<Staff> processJoin(List<Record> records) {
            List<Staff> myList = new List<Staff>();

            foreach (Record record in records) {
                myList.Add(new Staff() {
                    name = (string) record["StaffRole"],
                    salt = (int) record["StaffSalt"],
                    role = (string) record["StaffName"],
                });
            }

            return myList;
        }

        // Default processing behaviour
        protected override Staff processRecord(Record record) { 
            return new Staff() {
                name = (string) record["StaffName"],
                salt = (int) record["StaffSalt"],
                role = (string) record["StaffRole"]
            };
        }
    }
}
