module FaultProbability

open System

let pi (lambda : double) (t : double)  = - lambda * t |> Math.Exp

let qi lambda t = 1.0 - (pi lambda t)

let elementNonFaultProbability lambda t = 1.0 - (qi lambda t) * 3.0

let sameElementsFaultProbability lambda t count = Math.Pow ((elementNonFaultProbability lambda t), (count))

let systemNonFaultProbabilityWithFirstElem firstElemPi lambda t
    = firstElemPi * (sameElementsFaultProbability lambda t 8.0)

let systemNonFaultProbability lambda t
    = systemNonFaultProbabilityWithFirstElem (pi lambda t) lambda t
