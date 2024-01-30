using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
   List<Edge> edges;
   [SerializeField] List<Node> nodes;
    public List<GameObject> points;
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

/* if(node == 0)
  {
    AstarFound = true;
* }
    if(edge.GetTo().GetCaminoRecorrido() == -1)
{
    edge.GetTo().SetCaminoRecorrido(edge.GetDistance() + node.GetCaminoRecorrido());
    edge.GetTo().SetCost(cost);
    edge.GetTO().SetCorrectEdge(edge);
}
else if(edge.GetTo().GetCaminoRecorrido() > node.GetCaminoRecorrido() + edge.GetDistance())
{
    edge.GetTo().SetCaminoRecorrido(edge.GetDistance() + node.GetCaminoRecorrido));
    edge.GetTo().SetCost(cost);
    edge.GetTO().SetCorrectEdge(edge);
}
 */

/* Agregar variable: private bool AstarFound = false;
   Agregar una lista: List<Node>
   Agregar otra lista: List<Node> shortest = new List
 public void AStar(){
    Analizar(InitialNode);
    while(!AstarFound)
    {
        Analizar(porAnalizar[0]);
    }
 }

    public void SortList()
{
    porAnalizar.Sort(delegate(Node c1, Node c2) {return c1.GetCost().CompareTo(c2.GetCost()); });
}

    public void ShortesPath(){
        Node temp;
        while(temp != InitialNode)
        {
            ShortestPath.Add(temp);
            temp = temp.GetCorrectEdge().GetFrom();
        }
}
    
 */