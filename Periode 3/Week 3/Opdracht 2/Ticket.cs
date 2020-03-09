using System;
using System.Collections.Generic;

namespace Opdracht_2 {
    class Ticket {
        // Actual properties
        private string movieName;
        private int screen;
        private DateTime startDate;
        private int minAge;
        private double internalPrice;

        // Constant properties
        private List<int> viewingAges = new List<int>() { 0, 6, 9, 12, 16 };

        // Interface properties
        public double Price {
            get {
                double price = internalPrice;

                return Discount ? price * 0.95 : price;
            }
            set {
                internalPrice = value;
            }
        }
        public string MovieName {
            get { return movieName; }
            set {
                if (value.Length > 0) {
                    movieName = value;
                } else {
                    throw new Exception($"Invalid movie name ({value})");
                }
            }
        }
        public int Screen {
            get { return screen; }
            set {
                if (value >= 1 && value <= 5) {
                    screen = value;
                } else {
                    throw new Exception($"Invalid screen number ({value})");
                }
            }
        }
        public DateTime StartDate {
            get { return startDate; }
            set {
                if (value.Minute == 0 || value.Minute == 30) {
                    startDate = value;
                } else {
                    throw new Exception($"Invalid start time ({value})");
                }
            }
        }
        public int MinAge {
            get { return minAge; }
            set {
                if (viewingAges.Contains(value)) {
                    minAge = value;
                } else {
                    throw new Exception($"Invalid minimum age ({value})");
                }
            }
        }
        public bool Discount {
            get {
                return startDate.DayOfWeek == DayOfWeek.Monday || startDate.DayOfWeek == DayOfWeek.Tuesday;
            }
        }

        public void printTicket() {
            Console.WriteLine(
                "Movie: '{0}', Start Time: {1}, Price: {2}, Minimum age: {3}+",
                MovieName,
                StartDate,
                Price,
                MinAge
            );
        }
    }
}
