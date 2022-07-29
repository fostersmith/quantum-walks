//

namespace CyclicalDemo {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;

    //
    operation P (register: Qubit[]) : Unit is Adj + Ctl {

        let size = Length(register);

        for i in 0..size-1{
            if i==size-1 {
                X(register[i]);
            }
            else {
                (Controlled X)(register[i+1..size-1], register[i]);
            }
        }
    }

    //
    operation U0 (register: Qubit[], theta: Double) : Unit {

        Rx(2.0*theta, register[Length(register)-1]);

    }

    //
    operation U1 (register: Qubit[], theta: Double): Unit {

        P(register);
        U0(register, theta);
        Adjoint P(register);
    }

    //
    operation U (register: Qubit[], theta: Double): Unit {

        U1(register, theta);
        U0(register, theta);
    }

    //
    //the number of nodes will be 2^(numQubits)
    operation RunWalk (numQubits: Int, steps: Int) : Int {

        use register = Qubit[numQubits];
        for i in 1..steps {
            U(register, PI()/8.0);
        }

        mutable sum = 0;
        for i in 0..numQubits-1{
            set sum += 2^i*(M(register[i])==One ? 1 | 0);
        }

        Message($"Walker moved from position 0 to position {sum} in {steps} steps.");

        return sum;
    }
}