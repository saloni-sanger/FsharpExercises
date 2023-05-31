(*
    Name: Saloni Sanger
    Class: CPSC3400
    Professor: Eric Larson
    Purpose: F# exercises.
*)

(*
    Takes list of integers, integer to be replaced, and a replacement integer.
    Returns a list such that each occurrence of origVal in list is replaced with newVal.
    All other elements remain unchanged.
*)

let rec replace list origVal newVal =
    match list with
    | [] -> []
    | hd::tl -> 
        if hd = origVal
            then newVal::replace tl origVal newVal
            else hd::replace tl origVal newVal

(*
    Both parameters are lists of integers. Returns a list that merges the list in alternating fashion.
    First item from listA, second from listB, third from listA, etc.
    Append remainder of longer list if exists one.
*)

let rec mergeList listA listB =
    match (listA, listB) with 
    | ([],_) -> listB
    | (_,[]) -> listA
    | (ahead::atail, bhead::btail) -> 
        ahead::bhead::mergeList atail btail

(*
    Dictionary = dict = list of tuples with key in first index and value in second.
    Assume dict is unordered and each key is unique.
*)

(*
    return option type with corresponding value if key is in the dictionary.
    return None is key not present.
*)

let rec search dict key =
    match dict with
    | [] -> None
    | hd::tl -> 
        let k = fst(hd) //get key from next tuple is dict list
        if k = key
            then Some (snd(hd)) //if key found return some value
            else search tl key

(*
    If key is not in dict, return a new dictionary with the kay-value pair,
    if the key is already in the dictionary return dict with no modifications.
*)

let insert dict key value =
    let x = search dict key
    if x = None then (key, value)::dict
        else dict 

(*
    If the key is in the dictionary, a new dictionary is returned with the 
    corresponding key, value pair removed.
    If key is not in dict, return with no modifications.
*)

let rec nokey dict key =
    match dict with
    | [] -> []
    | hd::tl ->
        let k = fst(hd)
        if k = key 
            then nokey tl key 
            else hd::nokey tl key

let remove dict key = 
    let x = search dict key
    if x = None then dict
        else nokey dict key

(*
    parameter func is a boolean function that takes a single int and returns T/F.
    This function calls func on all values of dict and returns how many nodes return true.
*)

let rec count dict func = 
    match dict with
    | [] -> 0
    | hd::tl -> 
        if func (snd(hd))
            then 1 + count tl func
            else count tl func

(*
    returns number of entries that have a 2-digit positive integer (10 to 99) value.
    Must be a single call to count using lambda function.
*)

let twoDigitCount dict = 
    count dict (fun x -> 10 <= x && x <= 99) 
