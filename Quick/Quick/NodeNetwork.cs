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

            public Node(string name) {
                this.name = name;
            }

            public Node(string name, object data) {
                this.name = name;
                this.data = data;
            }

            public void createDirectedConnection(Node node) {
                addConnection(new NodeConnection(node));
                node.addConnection(new NodeConnection(this));
            }

            public void createDirectedConnection(Node node, object data) {
                NodeConnectionData connectionData = new NodeConnectionData(data);

                addConnection(new NodeConnection(node, connectionData));
                node.addConnection(new NodeConnection(this, connectionData));
            }

            public void createUndirectedConnection(Node node) {
                addConnection(new NodeConnection(node));
            }

            public void createUndirectedConnection(Node node, object data) {
                addConnection(new NodeConnection(node, data));
            }

            public void addConnection(NodeConnection connection) {
                connections.Add(connection);
            }
        }

        public class NodeConnection {
            public Node node;
            public NodeConnectionData data;

            public NodeConnection(Node toNode) {
                node = toNode;
            }

            public NodeConnection(Node toNode, NodeConnectionData data) {
                node = toNode;
                this.data = data;
            }

            public NodeConnection(Node toNode, object data) {
                node = toNode;
                this.data = new NodeConnectionData(data);
            }

            public void setData(object data) {
                if (data == null) {
                    this.data = new NodeConnectionData(data);
                } else {
                    this.data.setData(data);
                }
            }
        }

        public class NodeConnectionData {
            public object data;

            public NodeConnectionData(object data) {
                setData(data);
            }

            public void setData(object data) {
                this.data = data;
            }
        }
    }
}
