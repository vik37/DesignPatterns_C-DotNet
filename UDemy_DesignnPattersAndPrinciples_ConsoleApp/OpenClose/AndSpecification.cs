using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.enums;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.interfaces;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose
{
    public class AndSpecification<T> : ISpecifications<T>
    {
        private ISpecifications<T> first, second;
        public AndSpecification(ISpecifications<T> first, ISpecifications<T> second)
        {
            if(first == null)
            {
                throw new ArgumentNullException(paramName: nameof(first));
            }
            if(second == null)
            {
                throw new ArgumentNullException(paramName: nameof(second));
            }
            this.first = first;
            this.second = second;
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}
