//Найти минимум функции u = f (x, y) на области определения функции.
//Разработать на ЭВМ программу, реализующую каждый из рассмотренных методов.
//Исследовать сходимость алгоритмов и провести сравнение по числу
//вычислений функции для достижения заданной точности.

using System;

namespace Program {
  internal class HelloWorld {
    static void Main(string[] args) {
      Console.Write("Enter x1: ");
      double x1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter x2: ");
      double x2 = Convert.ToDouble(Console.ReadLine());
      double eps = Double.Epsilon;
      Console.Write("Enter step h: ");
      double h = Convert.ToDouble(Console.ReadLine());
      int k = 0;

      double G, Y, x1_p, x2_p;

      do {
        x1P = x1;
        x2P = x2;
        G = Function(x1, x2);
        x1 = x1P - h * gradX1(x1P, x2P);
        x2 = x2P - h * gradX2(x1P, x2P);
        Y = Function(x1, x2);

        k++;
      }
      while (Math.Abs(Y - G) > eps);

      Console.WriteLine("\nx1 = {0} \nx2 = {1}\nf(x1,x2) = {2}", x1, x2, Y);
      Console.WriteLine("\nNumber of iterations: " + k);
    }

    static double function(double x, double y) =>
      10 - (x - 3) * Math.Pow(Math.E, -(x - 3)) - (y - 1) * Math.Pow(Math.E, -(x - 1));

    static double gradX1(double x1, double x2) => 4 * x1 + x2 - 11;

    static double gradX2(double x1, double x2) => x1 + 4 * x2 - 8;
  }
}

