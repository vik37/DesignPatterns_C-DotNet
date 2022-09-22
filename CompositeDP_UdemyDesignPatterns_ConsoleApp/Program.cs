using CompositeDP_UdemyDesignPatterns_ConsoleApp.GeometricShapes;
using CompositeDP_UdemyDesignPatterns_ConsoleApp.NeutralNetworks;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompositeDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Geometric Shapes
            //var drawing = new GraphicObject { Name = "My Drawing" };
            //drawing.Children.Add(new Circle { Color = "Red" });
            //drawing.Children.Add(new Square { Color = "Yellow" });

            //var group = new GraphicObject();
            //group.Children.Add(new Circle { Color="Blue"});
            //group.Children.Add(new Square { Color = "Blue" });
            //drawing.Children.Add(group);

            //Console.WriteLine(drawing);
            #endregion

            #region
            // Neutral Networks
            var neuron1 = new Neuron();
            var neuron2 = new Neuron();
            neuron1.ConnectTo(neuron2);

            var neuronLayer1 = new NeuronLayer();
            var neuronLayer2 = new NeuronLayer();
            neuron1.ConnectTo(neuronLayer2);
            neuronLayer1.ConnectTo(neuronLayer2);
            #endregion
            Console.ReadLine();
        }
    }
}
