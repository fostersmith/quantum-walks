namespace CircleTest{

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;

    operation Mutation(coin: Qubit, state: Qubit[]) : Unit { // Take a step based on coin
        H(coin);
        Controlled Increment([coin], state); // Walker steps forward on heads
        X(coin);
        Controlled Decrement([coin], state); // Walker steps backward on tails
        X(coin);

    }

    operation Increment(register: Qubit[]) : Unit is Adj + Ctl { // Add 1 -> Walker steps forward
        for i in Length(register)-1.. -1 .. 1 { //MSD -> LSD
            Controlled X(register[i-1.. -1 .. 0], register[i]);
        }
        X(register[0]);
    }

    operation Decrement(register: Qubit[]) : Unit is Adj + Ctl{ // Subtract 1 -> Walker steps backward
        Adjoint Increment(register);
    }

    operation Flip(coin : Qubit) : Unit {
        H(coin);
    }

    operation LoopedWalk(N: Int, iterations: Int) : Int { // Do the walk
        use state = Qubit[N];   // Walker's position
        use coin = Qubit();     // Random component
        Rx(PI()/4.0, coin);//H(coin);
        S(coin);                // coin -> |i>

        for i in 1..iterations{ // Take {iterations} random steps
            Mutation(coin, state);
        }

        // Measure superposition
        mutable resultArray = [];
        for qubit in state{
            set resultArray += [M(qubit)];
        }
        Reset(coin);
        return ResultArrayAsInt(resultArray);
    }

    //tests
    operation LeftShifts(N: Int, shifts: Int) : Int {
        use state = Qubit[N];
        for i in 1..shifts{
            Adjoint Increment(state);
        }
        
        mutable resultArray = [];
        for qubit in state{
            set resultArray += [M(qubit)];
        }
        return ResultArrayAsInt(resultArray);
    }

    operation RightShifts(N: Int, shifts: Int) : Int {
        use state = Qubit[N];
        for i in 1..shifts{
            Increment(state);
        }
        
        mutable resultArray = [];
        for qubit in state{
            set resultArray += [M(qubit)];
        }
        return ResultArrayAsInt(resultArray);
    }

}