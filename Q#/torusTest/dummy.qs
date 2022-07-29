namespace DummyQS{

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;

    operation Mutation(coin: Qubit[], stateX: Qubit[], stateY: Qubit[]) : Unit{
        ApplyToEach(Flip, coin);
        Controlled Increment(coin, stateX); //left
        X(coin[0]);
        Controlled Decrement(coin, stateX); //right
        X(coin[1]);
        Controlled Increment(coin, stateY); //down
        X(coin[0]);
        Controlled Decrement(coin, stateY); //up
        X(coin[1]);
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

    operation LoopedWalk(length: Int, height: Int, iterations: Int) : Int[] {

        //store coordinates in separate registers
        //this allows us to easily perform the directional movements
        //it also preserves the idea that we can simulate N nodes with Log2(N) qubits, plus the coin qubits
        use stateX = Qubit[length];
        use stateY = Qubit[height];

        //we need two qubits for the coin because it needs to decide between four choices.
        use fourWayCoin = Qubit[2];
        //preparing the state of the coin
        ApplyToEach(H, fourWayCoin);
        ApplyToEach(S, fourWayCoin);

        //walk around aimlessly for a while and call it a useful scientific experiment
        for i in 1..iterations{
            Mutation(fourWayCoin, stateX, stateY);
        }

        ResetAll(fourWayCoin);

        //X-coordinate
        mutable resultX = 0;
        for i in length-1 .. -1 .. 0{
            set resultX += 2^i * (M(stateX[i]) == One ? 1 | 0);
        }

        //Y-coordinate
        mutable resultY = 0;
        for i in height-1 .. -1 .. 0{
            set resultY += 2^i * (M(stateY[i]) == One ? 1 | 0);
        }

        return [resultX, resultY];
    }
}