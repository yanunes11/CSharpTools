/*
    * @author : Yan Nascimento
    * @Description : basic tools for using with C#
    * @log : 20/12/2022 - created
*/

using System;

namespace Lesson2 {
    public class Basic1 {
        //retrieve value from the user
        public static void RetrieveValue() {
            Console.WriteLine("Writedonw your name: ");
            string name = Console.ReadLine() ?? "Not Null";
            Console.WriteLine("Your Name: "+name);
        }

        // operator << and >> for half and double
        public static void HalfDouble() {
            int n1 = 10;
            int s = n1<<3;
            Console.WriteLine(s);
        }

        enum DaysOfWeek{Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
        public static void EnumDaysOfWeek() {

            // First way:
            DaysOfWeek dw1 = DaysOfWeek.Wednesday;
            Console.WriteLine("Days of the Week FIRST WAY: "+dw1);

            // Second Way:
            DaysOfWeek dw2 = (DaysOfWeek)3;
            Console.WriteLine("Days of the Week SECOND WAY: "+dw2);
        }

        public static void GoToCommand() {
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
        
        public static void ListArray() {
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

        public static void Matrix() {
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