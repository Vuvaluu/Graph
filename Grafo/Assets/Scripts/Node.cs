using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    List<Edge> edges = new List<Edge>();
    [SerializeField] int heuristic;

// Return the value of the heuristic.
    public int GetHeuristic()
    {
        return heuristic;
    }
}
