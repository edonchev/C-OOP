using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLogger.Layouts.Contracts
{
    public interface ILayout
    {
        string Format { get; }
    }
}
