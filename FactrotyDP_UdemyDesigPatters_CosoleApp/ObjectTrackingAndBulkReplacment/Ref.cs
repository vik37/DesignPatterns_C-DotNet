using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.ObjectTrackingAndBulkReplacment
{
    public class Ref<T> where T : class
    {
        public T Value;
        public Ref(T value)
        {
            Value = value;
        }
    }
}
