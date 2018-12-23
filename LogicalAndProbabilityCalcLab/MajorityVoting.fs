module NModularRedundancy

open System
open FaultProbability

let redundantModuleFaultProbability qT qTVoter = (3. * Math.Pow(qT, 2.) - 2. * Math.Pow(qT, 3.)) * qTVoter

let systemNonFaultProbabilityWithRedundancy lambda t pTVoter =
      let c = redundantModuleFaultProbability (qi lambda t) (1. - pTVoter)
      let a = 1. - c
      systemNonFaultProbabilityWithFirstElem (a) lambda t