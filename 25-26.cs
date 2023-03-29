//написать и отладить программный код (согласно своего варианта),
//реализующий метод половинного деления (см. блок-схему на рис.3). Проанализировать
//полученные результаты (x– найденный корень уравнения, f(x) – значение функции в
//корне, n– количество итераций).

using System;
class HelloWorld {
  static float Function(float value) =>
    0.125f * MathF.Exp(-value) + 40 * MathF.Sin(value) - 1.5f;

  static void Main() {
    float a = 2;
    float b = 6;
    float n = 0;
    float e = MathF.Pow(10, -6);
    float x = 0;

    do {
      x = (a + b) / 2;
      if (Function(a) * Function(x) > 0)
        a = x;
      else
        b = x;

      n++;
    }
    while ((MathF.Abs(a - b) < e || MathF.Abs(Function(x)) <= e) == false);

    x = (a + b) / 2;

    Console.WriteLine($"x: {x}\nf(x): {Function(x)}\nn: {n}");

  }
}