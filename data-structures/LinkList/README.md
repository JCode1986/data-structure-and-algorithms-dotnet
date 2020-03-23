# Singly Linked Lists

## Challenge
* Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
* Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
* Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
* Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
* Define a method called toString which takes in no arguments and returns a string representing all the values in the Linked List.

## Approach & Efficiency
* `insert` method - O(1); always to the head
* `includes` method - O(n); possibly traverses through entire linked list
* `to_string` method - O(n); traverses through entire linked list

## API
* `Class Node` with value and next attributes
* `Class_linked` list with head
    * `insert(value)` method - takes in a value as an argument, and inserts that that value into the head of the linked list
    * `includes(value)` method - takes in a value as an argument, and returns a boolean if the value is present or not in the linked list
    * `to_string` method - returns all the values in the linked list