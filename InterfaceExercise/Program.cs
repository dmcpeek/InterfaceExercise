﻿using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyPrius = new Car() //dot notation
            {
                EngineCylinders = 4,
                Color = "Blue",
                ManufacturerName = "Toyota",
                IsElctric = true
            };
            Suv MyRav4 = new Suv(); //object initializer syntax
                MyRav4.SunRoof = true;
                MyRav4.NumberOfWheels = 4;
                MyRav4.SunRoof = true;
                MyRav4.AllWheelDrive = true;

            Truck CyberTruck = new Truck(); //custom constructor

            var vehicles = new List<IVehicle>() { MyPrius, MyRav4, CyberTruck };

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Number of Wheels: {vehicle.NumberOfWheels}");
                Console.WriteLine($"Engine Cylinders: {vehicle.EngineCylinders}");
                Console.WriteLine($"Sunroof: {vehicle.SunRoof}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //DONE - Create 3 classes called Car , Truck , & SUV

            //DONE - In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONE - In ICompany

            /*DONE - Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONE - In each of your car, truck, and suv classes

            /*DONE - Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //DONE - Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

