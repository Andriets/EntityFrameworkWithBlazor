using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
