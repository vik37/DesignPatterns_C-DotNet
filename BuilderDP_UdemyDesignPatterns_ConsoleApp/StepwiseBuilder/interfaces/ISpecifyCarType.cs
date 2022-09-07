using BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder.interfaces
{
    public interface ISpecifyCarType
    {
        ISpecifyWheelSize OfType(CarType type);
    }
}
