using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter sequence length: ");

    int length = Convert.ToInt32(Console.ReadLine());
    int value = 0;
    int count = 0;
    int sum = 0;

    Console.WriteLine("Doubled odd numbers are: ");

    for (int i = 1; i < length + 1; i++) {
      if (i % 2 == 0) {
        value = i / 2;
      }
      if (value % 2 != 0) {
        Console.WriteLine(i);
      }
    }
    Console.WriteLine("when divided by 7 gives a remainder of 1, 2 or 5: ");
    for (int i = 0; i < length + 1; i++) {
      if (i % 7 == 1) {
        Console.WriteLine(i);
      }
      if (i % 7 == 2) {
        Console.WriteLine(i);
      }
      if (i % 7 == 5) {
        Console.WriteLine(i);
      }

    }

    Console.WriteLine("are divisible by 5 and not divisible by 7, find the number and sum of those members of the sequence");

    for (int i = 0; i < length + 1; i++) {
      if (i % 5 == 2) {
        if (i % 7 != 0) {
          count++;
          sum += i;
        }
      }
    }
    Console.WriteLine(count);
    Console.WriteLine(sum);
  }
}

