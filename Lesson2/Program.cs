using System;

namespace Lesson2 {
    class Program {
        static void Main(string[] args) {
            RetrieveValue(); //ReadLine()
            HalfDouble(); // << and >> operators
            EnumDaysOfWeek(); // enum
            GoToCommand(); // Go to any place of the code

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
    }
}