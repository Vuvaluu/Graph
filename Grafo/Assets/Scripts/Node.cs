using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    List<Edge> edges = new List<Edge>();
    [SerializeField] int heuristic;
    public Vector2 pos;

    public Node(int x, int y)
    {
        pos = new Vector2(x, y);
    }

// Return the value of the heuristic.
    public int GetHeuristic()
    {
        return heuristic;
    }
}
