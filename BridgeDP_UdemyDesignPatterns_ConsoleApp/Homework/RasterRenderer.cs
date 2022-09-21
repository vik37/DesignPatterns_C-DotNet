using BridgeDP_UdemyDesignPatterns_ConsoleApp.Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDP_UdemyDesignPatterns_ConsoleApp.Homework
{
    public class RasterRenderer : IRenderer
    {

        public string WhatToRenderAs { get { return "Line"; } }
        
    }
}
