using System;

namespace Opdracht_3 {
    public class Robot {
        public string controller;

        public void moveByPerson(string controller) {
            Console.WriteLine($"Robot is moved by {controller}");
            this.controller = controller;
        }

        public void walkForward(int steps) {
            Console.WriteLine($"Robot walks {steps} steps forward");
        }

        public void bashWithHands() {
            Console.WriteLine("Robot causes damage with hands");
        }
    }
}
