// 1)

//using System;

//class homework2
//{
//    static void Main()
//    {
//        int num1 = 10;
//        int num2 = 4;


//        int addition = num1 + num2;
//        int subtraction = num1 - num2;
//        int multiplication = num1 * num2;
//        double division = (double)num1 / num2;
//        int remainder = num1 % num2;

//        Console.WriteLine("შეკრება: " + addition);
//        Console.WriteLine("გამოკლება: " + subtraction);
//        Console.WriteLine("გამრავლება: " + multiplication);
//        Console.WriteLine("გაყოფა: " + division);
//        Console.WriteLine("ნაშთი: " + remainder);
//    }
//}


// 2)

//განსხვავება არის ის რომ float არის 32 ბიტიანი(4ბაიტი), double არის 64 ბიტიანი (8 ბაიტი), decimal არის 128 ბიტიანი (16 ბაიტი).
// ასევე განსხვავდებიან გამოთვლის სიზუსტეებით ჯერ არის float მერე  double და decimal არის ყველაზე ზუსტი. 

//using System;

//class Program
//{
//    static void Main()
//    {
//        float x = 1.0f / 7.0f;
//        double y = 1.0 / 7.0;
//        decimal z = 1.0m / 7.0m;

//        float floatResult = x * 7;
//        double doubleResult = y * 7;
//        decimal decimalResult = z * 7;

//        Console.WriteLine("Float result: " + floatResult + "  | Double result: " + doubleResult + "  |  Decimal result: " + decimalResult );
//    }
//}



// 3)

//using System;

//class Program
//{
//    static void Main()
//    {

//        int integer_1 = 10;
//        double double_1 = 15.75;
//        float float_1 = 5.5f;
//        decimal decimal_1 = 100.25m;

//        // Implicit (int -> double)
//        double int_double = integer_1;

//        // Explicit  (double -> int)
//        int double_int = (int)double_1;

//        // Explicit (decimal -> float)
//        float decimal_float = (float)decimal_1;

//        // Implicit (int -> decimal)
//        decimal int_decimal = integer_1;

//        //Implicit (float-> double)
//        double float_double = float_1;

//        Console.WriteLine("int to double: " + int_double);
//        Console.WriteLine("double to int: " + double_int);
//        Console.WriteLine("decimal to float: " + decimal_float);
//        Console.WriteLine("int to decimal: " + int_decimal);
//        Console.WriteLine("float to double: " + float_double);
//    }
//}



//4)

//using System;

//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int b = 10;

//        Console.WriteLine("before: x = " + x + " b = " + b);


//        int y = x; 
//        x = b;
//        b = y;


//        Console.WriteLine("after: x = " + x + ", b = " + b);
//    }
//}




// 5)

using System;

class Program
{
    static void Main()
    {
        
        Console.Write("გთხოვთ შეიყვანოთ თქვენი წონა (კგ): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("გთხოვთ შეიყვანოთ თქვენი სიმაღლე (მ): ");
        double height = Convert.ToDouble(Console.ReadLine());

        
        double bmi = weight / (height * height);


        if (bmi < 18.5)
        {
            Console.WriteLine("თქვენი BMI არის : " + bmi + ".გთხოვთ, იზრუნოთ ჯანმრთელობაზე და ცოტა მოიმატოთ წონაში.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("თქვენი BMI არის : " + bmi + ".თქვენი bmi ნორმალურია. ");
        }
        else 
        {
            Console.WriteLine("თქვენი BMI არის : " + bmi + ".სასურველია დაიკლოთ წონაში.");
        }
    }
}


