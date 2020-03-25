# Singly Linked Lists

## Challenge
* Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
* Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
* Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
* Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
* Define a method called toString which takes in no arguments and returns a string representing all the values in the Linked List.
* Define a method KthFromTheEnd for the Linked List class which takes a number, k, as a parameter. Return the node’s value that is k from the end of the linked list.

## Approach & Efficiency
* `Insert` method - O(1); always to the head.
* `Includes` method - O(n); possibly traverses through entire linked list.
* `ToString` method - O(n); traverses through entire linked list.
* `Append` method - O(1); linked list tail --> new node.
* `InsertBefore` method - O(n) - Worst case, value is not in linked list.
* `InsertAfter` method - O(n) - Worst case, value is not in linked list.
* `KthFromTheEnd` method - O(n); possibly traverses through entire linked list.

## API
* `Class Node` with value and next attributes.
* `Class_linked` list with head.
    * `Insert(int va)` - takes in a value as an argument, and inserts that that value into the head of the linked list.
    * `Includes(int val)` method - takes in a value as an argument, and returns a boolean if the value is present or not in the linked list.
    * `ToString` method - returns all the values in the linked list
    * `Append(int val)` - appends node to the end of a linked list.
    * `InsertBefore(int oldValue, newValue)` - insert a node before a specific node.
    * `InsertAfter(int oldValue, newValue)` - insert a node after a specific node.
    * `KthFromTheEnd(int k) method - returns node value, that is k away from the end of the linked list.