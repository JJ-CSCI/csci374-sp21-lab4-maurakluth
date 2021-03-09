module Assignment

// Problem 1
let rec prod (lst:int list) =
    if List.isEmpty lst
    then 0
    else List.head lst * prod (List.tail lst)


// Problem 2
let rec map f (lst:int list) =
    if List.isEmpty lst
    then 0
    else List.head lst (List.tail lst)

// Problem 3
let rec odd (lst:int list) =
    if List.isEmpty lst 
    then 0
    else List.head lst odd (List.tail lst)

// Problem 4
let rec filter f lst =
    if List.isEmpty lst
    then 0
    else List.head lst filter f (List.tail lst)
