using System;

namespace Codefinity.Hexon.Architecture.Hexagon
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class PortAttribute : Attribute
    {
        public Side Side { get; }
        public string PortName { get; }
        

        public PortAttribute(Side side, string portName)
        {
            Side = side;
            PortName = portName;
        }

    }
}
