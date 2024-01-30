using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
   List<Edge> edges;
   [SerializeField] List<Node> nodes;
   
  void Start()
  {
     edges = new List<Edge>();
     nodes = new List<Node>();

    //Initialize nodes with random positions between -10 and 10
      nodes.Add( new Node(Random.Range(-10, 10), Random.Range(-10, 10)));
      nodes.Add( new Node(Random.Range(-10, 10), Random.Range(-10, 10)));
      nodes.Add( new Node(Random.Range(-10, 10), Random.Range(-10, 10)));
      nodes.Add( new Node(Random.Range(-10, 10), Random.Range(-10, 10)));
      nodes.Add( new Node(Random.Range(-10, 10), Random.Range(-10, 10)));
      nodes.Add( new Node(Random.Range(-10, 10), Random.Range(-10, 10)));
      nodes.Add( new Node(Random.Range(-10, 10), Random.Range(-10, 10)));
      nodes.Add( new Node(Random.Range(-10, 10), Random.Range(-10, 10)));
      
     Initialize();
  }

// Initialize the graph.
  public void Initialize()
  {
   // Compare all nodes with each other to create edges.
     foreach(Node node in nodes)
     {
       foreach(Node node2 in nodes) {
         if(node != node2){
            // Check distance between two nodes.
          float distance = Vector2.Distance(node.pos, node2.pos);
            // If the distance between the two nodes is less than 10, create an edge.
           if(distance < 10) {
               // Create an edge and add it to the list of edges.
              edges.Add(new Edge(node, node2, (int)distance));
              Debug.Log(node.pos.x+ ", " + node.pos.y + "+" + node2.pos.x + ", " + node2.pos.y + "=" + (int)distance);
            }
         }
       }
     }
            Debug.Log(edges.Count);
  }

}
