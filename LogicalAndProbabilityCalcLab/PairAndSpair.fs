module PairAndSpair

open System
open FaultProbability

let pairAndSpairNonFaultProbability qT qTVoter = (2. * Math.Pow(qT, 2.)) - Math.Pow((Math.Pow(qT, 2.)), 2.)

let pairAndSpairSystemNonFaultProbability lambda t pTVoter =
    let c = pairAndSpairNonFaultProbability (qi lambda t) (1. - pTVoter)
    let a = 1. - c
    systemNonFaultProbabilityWithFirstElem a lambda t