# F# Project: Introductory Exercises

### Background
I made this project in Languages and Computation with Professor Eric
Larson at Seattle University.

#### Functions

**replace**
    - Takes a list of integers (list), an integer to be replaced (origVal), and a replacement integer (newVal). 
    - Returns a list such that each occurrence of origVal in list is replaced with newVal.
    - All other elements remain unchanged.

**mergeList**
    - Both parameters are lists of integers (listA, listB). 
    - Returns a list that merges that lists in alternating fashion, starting with listA.
    - Append remaining items of longer list if it exists.

##### Note:
*The following functions are for a dictionary. The dictionary is implemented using a list of tuples. Each tuple represents a key value pair. The first item is a string that represents the key, the second is an integer representing the value. The dictionary is unordered and every key can be assumed to be unique*

**search**
    - Return option type with corresponding calue if the key is in the dictionary.
    - Return None if key is not in the dictionary.

**insert**
    - If the key is not in the dictionary, a new dictionary is returned with the key-value pair inserted. 
    - Dictionary is returned with no modifications of key is already in it.

**remove**
    - If key is in the dictionary, a new dictionary is returned with that tuple removed.
    - Dictionary is returned with no modifications of key is not in it.

**count**
    - Parameter func is a boolean function that takes a single integer and returns T/F.
    - The function calls func with each value (of the key-value pair) and returns the number of nodes that evaluate to true.

**twoDigitCount**
    - Return the number of entries that have a two-digit positive integer value (10-99). 
    - Done using a single call to count using a lambda function.

#### Other   
I used the option type, functions as parameters, lambda functions, and list operations in this project.
