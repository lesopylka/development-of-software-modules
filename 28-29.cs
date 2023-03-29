//Используя метод «золотого сечения», составить программу нахождения
//наименьшего значения заданной функции с точностью 10^(-5)

using System;

namespace Code {
  class Program {
    static void Main(string[] args) {
      double start = 1;
      double end = 3;
      double eps = 0.00001;
      double z = (3 - Math.Sqrt(5)) / 2;
      double x1 = start + z * (end - start);
      double x2 = end - z * (end - start);

      for (int i = 0; end - start > eps; i++) {
        if (Function(x1) <= Function(x2)) {
          end = x2;
          x2 = x1;
          x1 = start + end - x2;
        } else {
          start = x1;
          x1 = x2;
          x2 = start + end - x1;
        }
      }
      double x = (start + end) / 2;
      Console.WriteLine(x);
      Console.WriteLine($"x: {x}\nFunction(x): {Function(x)}");
    }

    private static double Function(double x) =>
      (Math.Pow(x, 2) / 2) - (1 / x);
  }
}
