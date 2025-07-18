using Codefinity.Hexon.Architecture.Hexagon;
using System;

namespace Codefinity.Hexon.Architecture
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class UseCaseAttribute : Attribute
    {
        public Side Side { get; }
        public string PortName { get; }

        public UseCaseAttribute( string portName)
        {
            Side = Side.Driven;
            PortName = portName;
        }

    }
}
