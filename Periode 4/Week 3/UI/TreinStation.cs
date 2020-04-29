using System;

namespace Model {
    public class TreinStation {
        public string name { get; set; }
        public string platform { get; set; }
        public DateTime arrivalTime { get; set; }
        public DateTime departureTime { get; set; }

        public TreinStation(string name, string platform, DateTime arrivalTime, DateTime departureTime) {
            this.name = name;
            this.platform = platform;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
        }
    }
}
