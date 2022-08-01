namespace AnotherExample{

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;

    operation Mutation(coin: Qubit, state: Qubit) : Unit { // Take a step based on coin
        H(coin);
        CX(coin, state);
    }

    operation LoopBack(state: Qubit) : Unit is Adj + Ctl {
        // do nothing!
    }

    operation OtherState(state: Qubit) : Unit is Adj + Ctl {
        X(state);
    }

    operation LoopedWalk(iterations: Int) : Bool { // Do the walk
        use state = Qubit();   // Walker's position
        use coin = Qubit();     // Random component
        H(coin);
        S(coin);                // coin -> |i>

        for i in 1..iterations{ // Take {iterations} random steps
            Mutation(coin, state);
        }

        // Measure superposition
        Reset(coin);
        return M(state) == One;
    }

}