# Code Challenge

## PseudoQueue 
*Author: Joseph Hangarter*

---

### Problem Domain

Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:
* enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.
* dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.

The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.

### Inputs and Expected Outputs

enqueue(value)

| Input | Args | Expected Output |
| :----------- | :----------- | :----------- |
| [10]->[15]->[10] | 5 | [5]->[10]->[15]->[10] |
|              | 5            | [5]           |

dequeue()

| Input | Output | Internal State |
| :----------- | :----------- | :----------- |
| [5]->[10]->[15]->[20] | 20 | [5]->[10]->[15] |
| [5]->[10]->[15] | 15          |  [5]->[10] |

---

### Big O

enqueue(value) - shuffling from the 2 stacks; 2 while loops; O(n + m)

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

dequeue() - shuffling from the 2 stacks; 2 while loops; O(n + m)

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |


---


### Whiteboard Visual
![Whiteboard](assets/enqueue.jpg)
![Whiteboard](assets/dequeue.jpg)

---