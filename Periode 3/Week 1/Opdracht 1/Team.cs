using System.Collections.Generic;

namespace Opdracht_1 {
    class Team {
        public List<Programmer> members;

        public Team() {
            members = new List<Programmer>();
        }

        public Team(List<Programmer> members) {
            this.members = new List<Programmer>(members);
        }

        public void printAllMembers() {
            foreach (Programmer programmer in members) {
                programmer.print();
            }
        }

        public void addProgrammer(Programmer programmer) {
            members.Add(programmer);
        }
    }
}
