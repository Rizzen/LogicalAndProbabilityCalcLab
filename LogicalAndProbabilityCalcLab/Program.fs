module Main

open System
open FaultProbability
open NModularRedundancy

let calcForList lambda =
    let ts = [100.0; 1_000.0; 5_000.0; 10_000.0;]
    let fullSystemNonFaultProbabilityForLambda t = systemNonFaultProbability lambda t
    ts |> List.map (fun x -> x, (fullSystemNonFaultProbabilityForLambda x))
       |> Map
       
let calcNModularRedundancyResultForList lambda pTVoter =
    let ts = [100.0; 1_000.0; 5_000.0; 10_000.0;]
    let redundancySystemNonFaultProbabilityForLambda t = systemNonFaultProbabilityWithRedundancy lambda t pTVoter
    ts |> List.map (fun x -> x, (redundancySystemNonFaultProbabilityForLambda x))
       |> Map

let printResult map =
    map |> Map.iter (fun k v -> printfn "t = %f P(t) = %f" k v)
        |> ignore

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
    let pTVoter = Math.Pow(10.0, -7.)
    
    let results = calcForList lambda
    
    let nModularRedundancyResult = calcNModularRedundancyResultForList lambda pTVoter
    
    // print result
    printResult results
    printfn ""
    printResult nModularRedundancyResult
    0
