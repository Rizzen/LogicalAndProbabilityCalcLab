const Calculator = input => {
    let t = input.t;
    let lambda = input.lambda;
    return fullSystemNonFaultProbability(t, lambda);
};

function fullSystemNonFaultProbability(t, lambda){
    const elementCount = 8;
    return pi(t, lambda) * Math.pow(elementNonFaultProbability(t, lambda), elementCount)
}

function elementNonFaultProbability(t, lambda) {
    return 1 - (qi(t, lambda)) * 3;
}

function qi(t, lambda) {
    return 1 - pi(t, lambda)
}

function pi(t, lambda) {
    let val = - lambda * t;
    return Math.exp(val)
}

export default Calculator;