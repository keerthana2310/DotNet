using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        //class Car
        //{
        //    public string model;  // Create a field

        //    // Create a class constructor for the Car class
        //    public Car()
        //    {
        //        model = "Mustang"; // Set the initial value for model
        //    }

        //    static void Main(string[] args)
        //    {
        //        Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
        //        Console.WriteLine(Ford.model);  // Print the value of model
        //    }
            class Car
            {
                public string model;

                // Create a class constructor with a parameter
                public Car(string modelName)
                {
                    model = modelName;
                }

                static void Main(string[] args)
                {
                    Car Ford = new Car("Mustang");
                    Console.WriteLine(Ford.model);
                }
            }

        }

    }

