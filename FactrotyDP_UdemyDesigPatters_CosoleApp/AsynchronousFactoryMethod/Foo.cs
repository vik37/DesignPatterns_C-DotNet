﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.AsynchronousFactoryMethod
{
    public class Foo
    {
        private Foo()
        {

        }
        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }
        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }
    }
}
