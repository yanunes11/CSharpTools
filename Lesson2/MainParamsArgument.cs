/*
    * @author : Yan Nascimento
    * @Description : basic tools for using with C#
    * @log : 28/12/2022 - created
*/

using System;

namespace Lesson2 {
    public class MainParamsArgument {
        //retrieve value from the user
        public static void MainParams() {
            ParamsArgument();
            ParamsArgument(1);
            ParamsArgument(1, 2, 7 ,3);
        }
        public static void ParamsArgument(params int[] n) {
            int res=0;

            if (n.Length < 1) {
                Console.WriteLine("Any Param");
            } else if (n.Length < 2) {
                Console.WriteLine("No numbers enought");
            } else {
                foreach (int value in n) {
                    res += value;
                }
                Console.WriteLine("The sum is: "+res);
            }
        }

        public static void RandomCreation(int[] vector) {

        }

    }
}