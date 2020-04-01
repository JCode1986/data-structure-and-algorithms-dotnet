# Code Challenge

## FIFO Animal Shelter 
*Author: Joseph Hangarter*

---

### Problem Domain
* Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
* Implement the following methods:
    * enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
    * dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

---

### Inputs and Expected Outputs

* enqueue(dog)
* enqueue(cat)

| Input | Expected Output |
| :----------- | :----------- |
| Shelter = none | Shelter = dog |
| Shelter = dog | Shelter = dog , cat |

* dequeue(cat)
* dequeue(dog)
* dequeue(bird)

| Input | Expected Output |
| :----------- | :----------- |
| Shelter = dog | Shelter = none |
| Shelter = dog, cat | Shelter = cat |

---

### Big O


| Time | Space |
| :----------- | :----------- |
| O(1) | O(1) |


---


### Whiteboard Visual
![Whiteboard](assets/wb12.jpg)


---
