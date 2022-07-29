namespace project {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Random;


     open CyclicalDemo;
    // open QSharpExercises.Solutions.Lab1;


    @Test("QuantumSimulator")
    operation RunWalkTest () : Unit {
        use target = Qubit();

        mutable counts = [0, size=16];

        for i in 0..100{
            let result = RunWalk(4, 1);
            set counts w/= result <- counts[result]+1;
        }
        Message($"{counts}");
    }
}
