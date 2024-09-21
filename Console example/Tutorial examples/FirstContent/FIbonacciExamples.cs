using System.Diagnostics;

namespace AppFibonacciExamples {
  class FibonacciExamples {
    
    public int fibonacciRec(int n) {
        if(n <= 1) {
          return n;
        }
        else {
          return fibonacciRec(n - 1) + fibonacciRec(n - 2);
        }
    }

        // if (n < 0) { tirar error; }
    public int iterativeFibonacci(int n) {
      if (n < 2) return 1;

      int firstNum = 0;
      int secondNum = 1;
      int i = 2;
      while (i <= n) {
        secondNum = firstNum + secondNum;
        firstNum = secondNum - firstNum;
        i++;
      }
      return secondNum;
    }

    public int iterativeFibonacciWithFor(int n) {
      int firstNum = 0;
      int secondNum = 1;
      for(int i = 2; i <= n; i++) {
        secondNum = firstNum + secondNum;
        firstNum = secondNum - firstNum;
      }
      return secondNum;
    }
    
    public void test() {
      Debug.Assert(this.fibonacciRec(6) == 8, "fibonacciRec should be 8.");
      Debug.Assert(this.iterativeFibonacci(6) == 8, "iterativeFibonacci should be 8.");
      Debug.Assert(this.iterativeFibonacciWithFor(6) == 8, "iterativeFibonacci should be 8.");
    }

  }
  
}