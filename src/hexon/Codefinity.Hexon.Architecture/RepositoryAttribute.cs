using Codefinity.Hexon.Architecture.Hexagon;
using System;

namespace Codefinity.Hexon.Architecture
{
    public class RepositoryAttribute : AdapterAttribute
    {
        public RepositoryAttribute(string portName) : base(Side.Driven, portName)
        {

        }

    }
}
