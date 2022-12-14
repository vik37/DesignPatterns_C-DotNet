using BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder
{
    public class Car
    {
        public CarType Type;
        public int WheelSize;

        public override string ToString()
        {
            return $"Car Type = {Type.ToString()} \nWheel Size = {WheelSize}";
        }
    }
}
