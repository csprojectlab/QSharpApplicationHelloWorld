namespace Quantum.RandomNumberGenerator {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    operation QuantumRandomNumberGenerator() : Result {
        using (q = Qubit()) {   // Allocate a qubit
		    H(q);                   // Put the qubit in superposition (Hadamard Transformation). 50 % chance of being 0 or 1
            let result = M(q);      // Measure the qubit value
            Reset(q);
            return result;
		}
	}
}
