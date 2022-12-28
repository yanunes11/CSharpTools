/*
    * @author : Yan Nascimento
    * @Description : basic tools for using with C#
    * @log : 27/12/2022 - created
*/

using System;

namespace Lesson2 {
    public class ArrayMethods {
        //retrieve value from the user
        public static void MainArrayMethods() {

            // vector setup
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];
            int[,] matrix = new int[2,5]{{11, 22, 00, 44, 55}, {66, 77, 88, 99, 00}};

            Console.Clear();

            vector1 = RandomCreation(vector1);
            int index = BinarySearch(vector1, 1);
            vector2 = Copy(vector1, vector2);
            vector3 = CopyTo(vector1, vector3);
            int valueOfIndex = GetValue(vector1, 0);
            int indexOf = GetIndexOf(vector1, 1);
            int lastIndexOf = LastIndexOf(vector1, 1);
            Reverse(vector1);
            SetValue(vector1, 99, 3); //vecotr value to set and index where to change
            Sort(vector1);
        }

        public static int[] RandomCreation(int[] vector) {
            Console.WriteLine("RandomCreation");
            Random random = new Random();
            for (int i = 0; i < vector.Length; i++) {
                vector[i] = random.Next(4); // 0 <= values < max
                // vector[i] = random.Next(50, 100); // 50 <= values < 100
                
            }
            return vector;
        }

        public static int BinarySearch(int[] vector, int value) {
            Console.WriteLine("BinarySearch");
            Console.Write("->["+value+"]<- Searched value \n");
            foreach (int v in vector) {
                Console.Write("["+v+"] ");
            }
            int val = Array.BinarySearch(vector, value);
            return val >= 0 ? val : -1;
        }

        public static int[] Copy(int[] vector1, int [] vector2) {
            Console.WriteLine("Copy");
            Array.Copy(vector1, vector2, vector1.Length); // Array.Copy(VectorToCopy, VectorWhereToCopy, QuantityOfElements);
            foreach(int value in vector1) {
                Console.Write("["+value+"] ");
            }
            Console.WriteLine();
            foreach(int value in vector2) {
                Console.Write("["+value+"] ");
            }
            return vector2;
        }

        public static int[] CopyTo(int[] vector1, int[] vector2) {
            Console.WriteLine("CopyTo");
            vector1.CopyTo(vector2, 0); // Vector.CopyTo(VectorWhereToCopy, FromWhichPosition);
            foreach (int value in vector1) {
                Console.Write("["+value+"] ");
            }
            Console.WriteLine();
            foreach (int value in vector2) {
                Console.Write("["+value+"] ");
            }
            return vector2;
        }
        public static int GetValue(int[] vector, int index) {
            Console.WriteLine("GetValue");
            int valueOfIndex = Convert.ToInt32(vector.GetValue(index));
            foreach(int value in vector) {
                Console.Write("["+value+"] ");
            }
            Console.WriteLine("\nValue with the index "+index+": "+valueOfIndex);
            return valueOfIndex;
        }

        public static int GetIndexOf(int[] vector, int value) {
            Console.WriteLine("GetIndexOf");
            int indexOf = Array.IndexOf(vector, value);
            foreach(int v in vector) {
                Console.Write("["+v+"] ");
            }
            Console.WriteLine("\nValue of the index "+value+": "+indexOf);
            return indexOf;
        }

        public static int LastIndexOf(int[] vector, int value) {
            Console.WriteLine("LastIndexOf");
            int indexOf = Array.LastIndexOf(vector, value);
            foreach(int v in vector) {
                Console.Write("["+v+"] ");
            }
            Console.WriteLine("\nValue of the index "+value+": "+indexOf);
            return indexOf;
        }

        public static void Reverse(int[] vector) {
            Console.WriteLine("Vector: ");
            foreach (int value in vector) {
                Console.Write("["+value+"] ");
            }
            Array.Reverse(vector);
            Console.WriteLine("Reversed Vector: ");
            foreach (int value in vector) {
                Console.Write("["+value+"] ");
            }
        }

        public static void SetValue(int[] vector, int valueToSet, int index) {
            vector.SetValue(valueToSet, index);
            
            Console.WriteLine("Vector: ");
            foreach (int value in vector) {
                Console.Write("["+value+"] ");
            }
        }

        public static void Sort(int[] vector) {
            Array.Sort(vector);
            Console.WriteLine("Vector: ");
            foreach (int value in vector) {
                Console.Write("["+value+"] ");
            }
        }

    }
}