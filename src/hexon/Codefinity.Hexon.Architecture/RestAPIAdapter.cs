using Codefinity.Hexon.Architecture.Hexagon;
using System;

namespace Codefinity.Hexon.Architecture
{
    public class RestAPIAdapterAttribute : AdapterAttribute
    {
        public RestAPIAdapterAttribute(string portName) : base(Side.Driving, portName)
        {

        }

    }
}
