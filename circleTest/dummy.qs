namespace DummyQS{

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;

    operation Mutation(coin: Qubit, state: Qubit[]) : Unit{
        Flip(coin);
        Controlled Increment([coin], state);
        X(coin);
        Controlled Decrement([coin], state);
        X(coin);

    }

    operation Increment(register: Qubit[]) : Unit is Adj + Ctl {
        for i in Length(register)-1.. -1 .. 1 { //MSD -> LSD
            Controlled X(register[i-1.. -1 .. 0], register[i]);
        }
        X(register[0]);
    }

    operation Decrement(register: Qubit[]) : Unit is Adj + Ctl{
        Adjoint Increment(register);
    }

    operation Flip(coin : Qubit) : Unit {
        H(coin);
    }

    operation LoopedWalk(N: Int, iterations: Int) : Int {
        use state = Qubit[N];
        use coin = Qubit();
        H(coin);
        S(coin);
        for i in 1..iterations{
            Mutation(coin, state);
        }
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