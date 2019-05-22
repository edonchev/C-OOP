﻿using DemoLogger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLogger.Layouts
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            switch (type)
            {
                case "SimpleLayout":
                    return new SimpleLayout();
                case "XmlLayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("Invalid layout type");
            }
        }
    }
}
