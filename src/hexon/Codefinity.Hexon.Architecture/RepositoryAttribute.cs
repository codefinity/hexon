using System;

namespace Codefinity.Hexon.Architecture
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class RepositoryAttribute : Attribute
    {
        public Side Side { get; }
        public string PortName { get; }

        public RepositoryAttribute(string portName)
        {
            Side = Side.Driven;
            PortName = portName;
        }

    }
}
