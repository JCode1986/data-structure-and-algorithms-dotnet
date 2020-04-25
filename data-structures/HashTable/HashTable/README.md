# Hashtables
Implementation

## Challenge
* Create methods for Hashtable class:
    * add: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
    * get: takes in the key and returns the value from the table.
    * contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
    * hash: takes in an arbitrary key and returns an index in the collection.

## Approach & Efficiency
* `add(key, value)`: O(1) - puts it directly into and index according to hash method
* `get(key)`: O(1) - retrieves directly from bucket, unless there are collision(s) which takes n times
* `contains(key)`: O(1) - checks if key is in bucket, unless there are collision(s) which takes n times 
* `hash(key)`: O(n) - loops through every character in string

## API
* `class HashTable`
    * `add(key, value)`: adds key, and value into bucket after key gets hashed with `hash(key)` method
    * `get(key)`: returns value from bucket
    * `contains(key)`: returns boolean if key is in bucket
    * `hash(key)`: loops through every character in string and returns an integer