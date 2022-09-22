using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompositeDP_UdemyDesignPatterns_ConsoleApp.NeutralNetworks
{
    public class Neuron : IEnumerable<Neuron>
    {
        public float value;
        public List<Neuron>  In, Out;
        //public void ConnectTo(Neuron other)
        //{
        //    Out.Add(other);
        //    other.In.Add(this);
        //}

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
