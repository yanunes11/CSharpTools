using System;

namespace Lesson2 {
    class Program {
        static void Main(string[] args) {
            RetrieveValue(); //ReadLine() retrieve values from the user
            HalfDouble(); // << and >> operators
            EnumDaysOfWeek(); // enum
            GoToCommand(); // Go to any place of the code
            ListArray();
            Matrix();
        }

        //retrieve value from the user
        static void RetrieveValue() {
            Console.WriteLine("Writedonw your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your Name: "+name);
        }

        // half and double
        static void HalfDouble() {
            int n1 = 10, n2 = 20;
            int s = n1<<3;
            Console.WriteLine(s);
        }

        enum DaysOfWeek{Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
        static void EnumDaysOfWeek() {

            // First way:
            DaysOfWeek dw1 = DaysOfWeek.Wednesday;
            Console.WriteLine("Days of the Week FIRST WAY: "+dw1);

            // Second Way:
            DaysOfWeek dw2 = (DaysOfWeek)3;
            Console.WriteLine("Days of the Week SECOND WAY: "+dw2);
        }

        static void GoToCommand() {
            bool value = false;
            int count = 0;
            init:
            if (value && count == 1) {
                Console.Clear();
                Console.WriteLine("Inside If statement");
            }

            value = true;
            if (value == true && count < 1) {
                Console.WriteLine("WriteLine deleted");
                count += 1;
                goto init;
            }
        }
        
        static void ListArray() {
            int[] n1 = new int[5]; // list with 5 elements 0-4
            Console.WriteLine("n1.Length: "+n1.Length);

            n1[0] = 4;
            n1[1] = 5;
            n1[2] = 7;
            n1[3] = 43;
            n1[4] = 1;
            Console.WriteLine("\nn1 values: ");
            int i = 0;
            foreach(int value in n1) {
                Console.WriteLine("value["+i+"]: "+value);
                i =+ 1;
            }

            int[] n2 = new int[6]{4, 5, 2, 6, 8, 98}; // list with 5 elements 0-4
            Console.WriteLine("\nn2.Length: "+n2.Length);

        }

        static void Matrix() {
            int[,] n = new int[3,5]; // 3 lines 5 columns

            n[0,0] = 10;
            n[0,1] = 20;
            n[0,2] = 30;
            n[0,3] = 40;
            n[0,4] = 50;

            n[1,0] = 60;
            n[1,1] = 70;
            n[1,2] = 80;
            n[1,3] = 90;
            n[1,4] = 100;

            Console.WriteLine("n[1,3]: "+n[1,3]);

            // inserting values in declaration
            int[,] num = new int[2,2]{{10, 20}, {30, 40}};
        }
    }
}