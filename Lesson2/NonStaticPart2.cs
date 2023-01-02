/*
    * @author : Yan Nascimento
    * @Description : Non-static class
    * @log : 28/12/2022 - created
*/

using System;

namespace Lesson2 {
    // aux class for study purpose: invokes Product class
    public class NonStaticPart2 {
        public NonStaticPart2() {
            // Inheritance // Gardening is a derived class
            Gardening2 gd = new Gardening2();
        }

    }

    public class Product2 {

        // properties
        public string name = "No Name";
        private int price = 0;
        private int quantity = 0;

        // constructor
        public Product2(int quantity) {
            this.quantity = quantity;
            // this.quantity = quantity;
        }

        public string getPrice() {
            return name;
        }

        public void setPrice(int price) {
            if (price < 0) {
                this.price = price;
            } else {
                this.price = price;
            }
        }

    }

    public class Gardening2:Product2 {
        public Gardening2():base(1) {
            Console.WriteLine("Gardening");
            // this.name = name;
            // this.setPrice(price);
        }
    }


}