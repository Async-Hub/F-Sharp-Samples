// ******* Declarations *******

let sampleInt = 7
let sampleFloat = 7.27f
let sampleDouble = 7.27
let sampleString = "Hi!"

let mutable mutableInt = 7 // Mutable value
mutableInt <- 8

let sampleTuple = 5,9

// ******* Functions *******

let addTwo a = a + 2
let addThree a = a + 3.0 // Type inference
let sumTuple (a, b) = a + b // Tuple parameter

let squareInt x = x * x 
let ``Sum Of Squares`` = List.map squareInt [1..10] |> List.sum 

// ******* Collection Types *******
// https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/fsharp-collection-types

let sampleList = ["a";"b";"c";"d";"e"]
let sampleArray = [|"a";"b";"c";"d";"e"|]

// ******* Complex Types *******

type Customer = { First: string; Last: string; } // Record type

// A struct record.
[<Struct>]
type StructPoint = 
    { X: float
      Y: float }

let point = { X = 1.0; Y = 2.0 }

// ******* Object-Oriented constructs *******

//[<AllowNullLiteral>]
type Account(id : string, creationTime : System.DateTime) =
    member  _.Id = id
    member _.CreationTime = creationTime
    
let mutable account = Account("1", System.DateTime.Now)
//account <- null

// ******* Pattern Matching *******

type Shape =
    | Rectangle of height : float * width : float
    | Circle of radius : float
    
let matchShape shape =
    match shape with
    | Rectangle(height = h) -> printfn "Rectangle with length %f" h
    | Circle(r) -> printfn "Circle with radius %f" r
    
let shape = Rectangle(3.0, 4.5)
matchShape shape