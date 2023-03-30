using System;
class HelloWorld {
  static void Main(string[] args) {
    Console.WriteLine("Enter sequence length: ");

    int length = Convert.ToInt32(Console.ReadLine());
    DoubleNegativeNumbers(length);
    DevideBy7(length);
    DevideBy5NotBy7(length);
  }

  public static void DoubleNegativeNumbers(int length) {
    Console.Write("Doubled odd numbers are: ");

    for (int i = 1; i < length + 1; i++) {
      if (i % 2 == 0 && i / 2 % 2 != 0) {
        Console.Write($"{i}");
      }
    }
  }

  public static void DevideBy7(int length) {

    Console.WriteLine("when divided by 7 gives a remainder of 1, 2 or 5: ");
    for (int i = 0; i < length + 1; i++) {
      if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5) {
        Console.Write($"{i}");
      }
    }
  }

  public static void DevideBy5NotBy7(int length) {
    int value = 0;
    int sum = 0;
    Console.WriteLine("are divisible by 5 and not divisible by 7, find the number and sum of those members of the sequence");

    for (int i = 0; i < length + 1; i++) {
      if (i % 5 == 2 && i % 7 != 0) {
        value++;
        sum += i;
      }
    }

    Console.WriteLine(value);
    Console.WriteLine(sum);
  }
}