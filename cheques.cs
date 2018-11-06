using static System.Console;
using System;

class Program {

    static void Main() {
      int []amount = {0, 0, 0, 0};
      int []rs = new int[]{0, 0, 0};
      int i, k, j, max, min;

      for (i = 1; i <= 4; i++) {
        Write("Input amount #" + i + ":");
        amount[i - 1] = System.Convert.ToInt32(ReadLine());
      } Array.Sort(amount, 0, 4);

      max = amount[3];
      k = 0;
      for (i = 0; i < 4; i++) {
        for (j = i + 1; j < 4; j++) {
          if (amount[j] % amount[i] == 0) {
            WriteLine(amount[i]);
            if (k < 3) {
              rs[k] = amount[i];
            } else {
              i++;
            }
          }
        }
      }



      for (i = 1; i <= 3; i++) {
        Write("#" + i + " $" + rs[i - 1]);
        WriteLine("");
      }
    }
}
