using BridgeDP_UdemyDesignPatterns_ConsoleApp.Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDP_UdemyDesignPatterns_ConsoleApp.Homework
{
    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs { get { return "Pixels"; } }        

    }
}
