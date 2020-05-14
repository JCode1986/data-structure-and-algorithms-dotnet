# Graph
Implementation

## Challenge
Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:

* AddNode()
   * Adds a new node to the graph
   * Takes in the value of that node
   * Returns the added node
* AddEdge()
   * Adds a new edge between two nodes in the graph
   * Include the ability to have a “weight”
   * Takes in the two nodes to be connected by the edge
   * Both nodes should already be in the Graph
* GetNodes()
   * Returns all of the nodes in the graph as a collection (set, list, or similar)
* GetNeighbors()
   * Returns a collection of edges connected to the given node
   * Takes in a given node
   * Include the weight of the connection in the returned collection
* Size()
   * Returns the total number of nodes in the graph
 * BreadthFirst()
    * Return a collection of nodes in the order (level-order) they were visited.
* DepthFirst()
    * Return a collection of nodes in the order (depth-order) they were visited.
* GetEdge()
  * Write a function based on the specifications above, which takes in a graph, and an array of city names. Without utilizing any of the built-in methods available to your language, return whether the full trip is possible with direct flights, and how much it would cost.

## Approach & Efficiency
* `class Graph`
    * `AddNode(value)`: O(1)
    * `AddEdge(start, end, weight)`: O(1)
    * `GetNodes()`: O(n)
    * `GetNeighbors(node)`: O(1)
    * `Size()`: O(1)

