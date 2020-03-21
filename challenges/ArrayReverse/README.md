# Reverse an Array
<!-- Short summary or background information -->

## Challenge
<!-- Description of the challenge -->
* Write a function called reverseArray which takes an array as an argument. Without utilizing any of the built-in methods available to your language, return an array with elements in reversed order.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
* Initialized a `result` array, and utilized a for loop starting from the end of input array. Insert elements from `index -1` from input array to `index 0` of `result` array until loop is complete.

* Big O  
    * Time and Space - O(n); iterating through every element in array, and inserting element in `result` array.

