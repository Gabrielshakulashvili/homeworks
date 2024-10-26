//using System;
//class Program
//{
//    static void Main()
//    {
//        char[] vowels = { 'a', 'e', 'i', 'o', 'o' };

//        Console.WriteLine("gtxovt sheikvanot raime winadadeba: ");
//        string input = Console.ReadLine();

//        int Vowel_count = 0;

//        foreach (char x in vowels)
//        {
//            if (vowels.Contains(x))
//            {
//                Vowel_count++;
//            }
//        }
//        Console.WriteLine("tqvens winadadebashi aris" + Vowel_count + "xmovani");
//    }
//}



//  2)

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] number = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//        Console.WriteLine("gtxovt sheikvanot ricxvi: ");
//        int  input = int.Parse(Console.ReadLine());

//        Console.WriteLine(input + " * 1 = " + input * 1 + "\n" + input + " * 2 = " + input * 2 + "\n" + 
//            input + " * 3 = " + input * 3 + "\n" + input + " * 4 = " + input * 4 + "\n" +
//                  input + " * 5 = " + input * 5 + "\n" +
//                  input + " * 6 = " + input * 6 + "\n" +
//                  input + " * 7 = " + input * 7 + "\n" +
//                  input + " * 8 = " + input * 8 + "\n" +
//                  input + " * 9 = " + input * 9 + "\n" +
//                  input + " * 10 = " + input * 10);
//    }


//}




//   3) 


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matrix1 = new int[3, 3];
//        int[,] matrix2 = new int[3, 3];
//        int[,] result = new int[3, 3];

//        Console.WriteLine("\nsheikvanet pirveli matricis elementebi:");

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write("matrix1[" + (i + 1) + "," + (j + 1) + "]");

//                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
//            }

//        }


//        Console.WriteLine("\nsheikvanet mwore maticis elementebi");

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write("matrix2[" + (i + 1) + "," + (j + 1) + "]");

//                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
//            }
//        }


//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                result[i, j] = matrix1[i, j] + matrix2[i, j];

//            }
//        }


//        Console.WriteLine("result: ");

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write(result[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }




//    }

//}





////  4)

using System;

class Program
{



    static void Main(string[] args)
    {
        bool Continue_running = true;
        while (Continue_running)
        {
            Console.WriteLine("airchiet romeli moqmedeba gsurt (airchiet shesabamisi nomeri");
            Console.WriteLine("1. mimateba");
            Console.WriteLine("2. gamokleba");
            Console.WriteLine("3. gamravleba");
            Console.WriteLine("4. gayofa");
            Console.WriteLine("5. calculatoris gamortva ");


            string choice = Console.ReadLine();


            if (choice == "5")
            {
                Continue_running = false;
                Console.WriteLine("gatishva...");
                break;
            }


            Console.WriteLine("sheikvanet pirveli ricxvi: ");
            double number1 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("sheikvanet meore ricxvi: ");
            double number2 = Convert.ToDouble(Console.ReadLine());


            double result = 0;

            switch (choice)
            {
                case "1":
                    result = number1 + number2;
                    Console.WriteLine("shedegi = " + result);
                    break;

                case "2":
                    result = number1 - number2;
                    Console.WriteLine("shedegi = " + result);
                    break;

                case "3":
                    result = number1 * number2;
                    Console.WriteLine("shedegi = " + result);
                    break;

                case "4":

                    if (number2 == 0)
                    {
                        Console.WriteLine("nulze gayofa ar sheidzleba. ");
                        break;
                    }


                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine("shedegi = " + result);
                        break;
                    }

                //case "5" :

                //     Continue_running = false;
                //     Console.WriteLine("gatishva...");
                //     break;




                default:
                    Console.WriteLine("araswori archevani, tavidan scade.");
                    break;


            }
        }



    }


}



