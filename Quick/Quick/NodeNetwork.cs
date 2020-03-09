using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick {
    namespace NodeNetwork {
        public class Node {
            private List<NodeConnection> connections = new List<NodeConnection>();
            public string name;
            public object data;
            public Dictionary<string, object> dataObject = new Dictionary<string, object>();

            public List<NodeConnection> Connections { get { return connections; } }

            public Node() { }

            public Node(string name) {
                this.name = name;
            }

            public Node(string name, object data) {
                this.name = name;
                this.data = data;
            }

            public void connectTo(Node node) {
                addConnection(new NodeConnection(node));
                node.addConnection(new NodeConnection(this));
            }

            public void connectTo(Node node, object data) {
                addConnection(new NodeConnection(node, data));
                node.addConnection(new NodeConnection(this, data));
            }

            public void addConnection(NodeConnection connection) {
                connections.Add(connection);
            }
        }

        public class NodeConnection {
            public Node node;
            public object data;

            public NodeConnection(Node toNode) {
                node = toNode;
            }

            public NodeConnection(Node toNode, object data) {
                node = toNode;
                this.data = data;
            }
        }
    }
}
