using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLogger.Layouts.Contracts
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
