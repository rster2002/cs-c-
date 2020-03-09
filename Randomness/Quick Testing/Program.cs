using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.NodeNetwork;

namespace Quick_Testing {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            List<Node> network = getNodeNetwork();

            performDijkstasAlgorith(network, network[4]);

            Console.ReadKey();
        }

        List<Node> getNodeNetwork() {
            Node nodeA = new Node("A", 0);
            Node nodeB = new Node("B", 9999999);
            Node nodeC = new Node("C", 9999999);
            Node nodeD = new Node("D", 9999999);
            Node nodeE = new Node("E", 9999999);

            nodeA.connectTo(nodeB, 2);
            nodeA.connectTo(nodeC, 6);
            nodeB.connectTo(nodeC, 8);
            nodeB.connectTo(nodeD, 9);
            nodeC.connectTo(nodeD, 3);
            nodeC.connectTo(nodeE, 5);
            nodeD.connectTo(nodeE, 19);

            return new List<Node>() {
                nodeA,
                nodeB,
                nodeC,
                nodeD,
                nodeE
            };
        }

        void performDijkstasAlgorith(List<Node> nodes, Node targetNode) {
            Node currentNode = nodes[0];

            while (currentNode != targetNode) {

                currentNode = nodes[0];

                foreach (NodeConnection connection in currentNode.Connections) {
                    if (nodes.Contains(connection.node)) {
                        int currentDistance = (int) connection.node.data;
                        int connectionDistance = (int) connection.data + (int) currentNode.data;

                        if (connectionDistance < currentDistance) {

                        }
                    }
                }

                nodes.Remove(currentNode);
            }
        }
    }
}
