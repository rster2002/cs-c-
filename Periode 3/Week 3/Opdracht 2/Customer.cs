using System;

namespace Opdracht_2 {
    class Customer {
        // Actual properties
        private DateTime dateOfRegistration = DateTime.Now;
        private DateTime dateOfBirth;
        private string name;

        // Interface properties
        public DateTime DateOfRegistration {
            get {
                return dateOfRegistration;
            }
        }
        public string Name {
            get {
                return name;
            }
            set { 
                if (value.Length > 0) {
                    name = value;
                }
            }
        }
        public DateTime DateOfBirth {
            get { return dateOfBirth; }
            set {
                DateTime now = DateTime.Now;
                TimeSpan result = now - value;

                if (result.TotalDays > 0 && result.TotalDays > 365 * 4 && result.TotalDays < 365 * 100) {
                    dateOfBirth = value;
                }
            }
        }
        public int Age {
            get {
                DateTime now = DateTime.Now;
                TimeSpan result = now - dateOfBirth;

                return (int) result.TotalDays / 365;
            }
            private set { }
        }
        public bool Discount {
            get {
                DateTime now = DateTime.Now;
                TimeSpan result = now - dateOfRegistration;

                return result.TotalDays > 365;
            }
            private set { }
        }
    }
}
