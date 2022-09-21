using BridgeDP_UdemyDesignPatterns_ConsoleApp.Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDP_UdemyDesignPatterns_ConsoleApp.Homework
{
    public abstract class Shape
    {
        private IRenderer renderer;
        public string Name { get; set; }
        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }
        public override string ToString()
        {
            return $"Drowing {Name} as {renderer.WhatToRenderAs}";
        }

    }
}
