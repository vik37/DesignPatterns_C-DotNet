using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder.interfaces
{
    public interface ISpecifyWheelSize
    {
        IBuildCar WithWeels(int size);
    }
}
