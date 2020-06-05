using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.builder.abstractas
{
    public interface IBuilder<T>
    {
        public T Build();
    }
}
