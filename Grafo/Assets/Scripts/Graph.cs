using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
   List<Edge> edges;
   [SerializeField] List<GameObject> goNodes;
   
  void Start()
  {
     edges = new List<Edge>();
     Initialize();
  }

// Initialize the graph.
  public void Initialize()
  {
   // Compare all nodes with each other to create edges.
     foreach(GameObject goNode in goNodes)
     {
       foreach(GameObject goNode2 in goNodes) {
         if(goNode != goNode2){
            // Check distance between two nodes.
            float distance = Vector3.Distance(goNode.transform.position, goNode2.transform.position);
            // If the distance between the two nodes is less than 10, create an edge.
            if(distance < 10) {
               // Create an edge and add it to the list of edges.
              edges.Add(new Edge(goNode.GetComponent<Node>(), goNode2.GetComponent<Node>(), (int)distance));
              Debug.Log(goNode.name + "+" + goNode2.name + "=" + (int)distance);

            }
         }
       }
     }
    
  }

}
