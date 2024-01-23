using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge 
{
    Node nodeA;
    Node nodeB;
    int cost;

// Edge constructor.
    public Edge(Node nodeA, Node nodeB, int nodeCost)
    {
        this.nodeA = nodeA;
        this.nodeB = nodeB;
        this.cost = nodeCost;
    }

// Return the value of the nodeA.
    public Node GetNodeA()
    {
        return nodeA;
    }

// Return the value of the nodeB.
    public Node GetNodeB()
    {
        return nodeB;
    }

// Return the value of the cost.
    public int GetCost()
    {
        return cost;
    }

// Assing the cost.
    public void SetCost(int newCost)
    {
        cost = newCost;
    }
    
}
