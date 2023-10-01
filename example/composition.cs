using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alternate
{
    class addition
    {
        public int x = 4;
        public int y = 5;

        public int result;
        public addition add(int x_, int y_)
        {
            result = x_ + y_;
            return this;
        }
    }
    class Subtraction
    {
        public int b = 7;
        public int result; 
        public Subtraction subtract(int b, int input_)
        {
            result = b - input_;
            return this;
        }
    }
    class Multiplication
    {
        public int c = 8;
        public string result = "";
        public Multiplication multiply(int c, int input_)
        {
            c *= input_;
            result = c.ToString();
            return this;
        }
    }
    class printing
    {
        
        public void print(string input)
        {
            Console.WriteLine(input);
        }
    }

    class Processing
    {
        addition adder = new addition();
        Subtraction subber = new Subtraction();
        Multiplication multer = new Multiplication();
        printing printer = new printing();


        
        public void Process()
        {
            printer.print(multer.multiply(multer.c,subber.subtract(subber.b,adder.add(adder.x, adder.y).result).result).result);
               
        }
    }

}
