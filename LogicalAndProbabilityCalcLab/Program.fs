open System
open System

let pi (lambda : Double) (t : Double)  = - lambda * t |> Math.Exp

let qi lambda t = 1.0 - (pi lambda t)

let elementNonFaultProbability lambda t = 1.0 - (qi lambda t) * 3.0

let fullSystemNonFaultProbability lambda t = (pi lambda t) * (Math.Pow ((elementNonFaultProbability lambda t), (8.0)))

let calcForList lambda =
    let ts = [1.0; 10.0; 100.0; 1_000.0; 10_000.0; 100_000.0; 1_000_000.0]
    let fullSystemNonFaultProbabilityForLambda t = fullSystemNonFaultProbability lambda t
    ts |> List.map (fun x -> x, (fullSystemNonFaultProbabilityForLambda x))
       |> Map

[<EntryPoint>]
let main argv =
    printfn "Enter lambda value"
    let (success, value) = Console.ReadLine()
                        |> Double.TryParse
    if not success
    then
        printfn "Wrong value entered"
        0
    else
    
    // init data
    let lambda = Math.Pow(10.0, value)
    
    let results = calcForList lambda
    
    // print result
    results
    |> Map.iter (fun k v -> printfn "t = %f P(t) = %f" k v)
    |> ignore
    0
