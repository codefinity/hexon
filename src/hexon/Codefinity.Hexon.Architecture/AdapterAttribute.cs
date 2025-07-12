using System;

namespace Codefinity.Hexon.Architecture
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class AdapterAttribute : Attribute
    {
        public Side Side { get; }
        public string PortName { get; }

        public AdapterAttribute(Side side, string portName)
        {
            Side = side;
            PortName = portName;
        }

    }
}
