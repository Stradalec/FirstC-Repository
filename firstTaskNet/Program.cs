using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTaskNet {
  internal class Program {
    static void Degree(int number) {

      int tempNumber = 0;
      int degree = 0;

      Console.WriteLine("Enter degree of this number:");
      degree = Convert.ToInt32(Console.ReadLine());

      tempNumber = number;

      for (int indexOfDegree = 1; indexOfDegree < degree; ++indexOfDegree) {
        number *= tempNumber;
      }

      Console.WriteLine("Number in this degree = " + number + "\n");
      Console.WriteLine("Operation completed. Press any button to exit");
      Console.ReadKey();
    }

    static void AddDigitToTheNumber(int number) {
      string stringNumber;
      char attachedDigit;
      if (number < 100) {
        Console.WriteLine("Too short number. Enter this number again");
        number = Convert.ToInt32(Console.ReadLine());
        AddDigitToTheNumber(number);
      } else {
        stringNumber = number.ToString();
        attachedDigit = stringNumber[1];

        Console.WriteLine("Result: " + stringNumber.Remove(1, 1) + attachedDigit);
        Console.WriteLine("Operation completed. Press any button to exit");
        Console.ReadKey();
      }

    }
    static void Main(string[] args) {
      int mainNumber = 0;
      char selection = ' ';
      Console.WriteLine("Enter the number: ");
      mainNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Select operation: d = degree of this number, \n");
      Console.WriteLine("a = 2 digit in number put in the end");
      selection = Convert.ToChar(Console.ReadLine());
      if (selection == 'd') {
        Degree(mainNumber);
      } else if (selection == 'a') {
        AddDigitToTheNumber(mainNumber);
      } else {
        Console.WriteLine("Wrong operation type. Press any button to exit");
        Console.ReadKey();
      }

    }

  }
}
