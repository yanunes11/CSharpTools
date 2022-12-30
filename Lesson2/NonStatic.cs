/*
    * @author : Yan Nascimento
    * @Description : Non-static class
    * @log : 28/12/2022 - created
*/

using System;

namespace Lesson2 {
    // aux class for study purpose: invokes Product class
    public class NonStatic {
        public NonStatic() {
            Product pd = new Product();
            pd.name = "Juan Pablo";
            pd.setPrice(20);
            Console.WriteLine("pd.name: "+pd.name);
            Console.WriteLine("pd.price: R$ "+pd.getPrice());

            // overload constructor
            Product pdOverload = new Product();

            Gardening gd = new Gardening("Inheritance");
        }

    }

    public class Product {

        // properties
        public string name = "No Name";
        private int price = 0;

        public Product(string name, int price) {
            this.name = name;
            this.price = price;
        }

        public Product() {
            Console.WriteLine("*** -> Constructor Overloaded <- ***");
            Console.WriteLine("Default Name : "+this.name);
            Console.WriteLine("Default Price : R$ "+this.price);
        }

        // use get set when the properties are private
        public int getPrice() {
            return price;
        }

        public void setPrice(int value) {
            if (value < 0) {
                price = 0;
            } else {
                price = value;
            }
        }
        // public string getName() {
        //     return name;
        // }

        // public void setName(string value) {
        //     name = value;
        // }


    }

    public class Gardening:Product {
        public Gardening(string name) {
            this.name = name;
        }
    }


}