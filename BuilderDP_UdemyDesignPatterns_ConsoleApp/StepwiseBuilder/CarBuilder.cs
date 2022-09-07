using BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder.enums;
using BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder
{
    public class CarBuilder
    {
        private class Impl :
            ISpecifyCarType,
            ISpecifyWheelSize,
            IBuildCar
        {
            private Car car = new Car();
            public ISpecifyWheelSize OfType(CarType type)
            {
                car.Type = type;
                return this;
            }

            public IBuildCar WithWeels(int size)
            {
                switch (car.Type)
                {
                    case CarType.Sedan when size < 15 || size > 17:
                    case CarType.Crossover when size < 17 || size > 20:
                        throw new ArgumentException($"Wrong size of wheel for {car.Type}");
                }
                car.WheelSize = size;
                return this;
            }
            public Car Build()
            {
                return car;
            }
        }
        public static ISpecifyCarType Create()
        {
            return new Impl();
        }
    }
}
