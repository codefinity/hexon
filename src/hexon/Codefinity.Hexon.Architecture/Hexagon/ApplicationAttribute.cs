using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Codefinity.Hexon.Architecture.Hexagon
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class ApplicationAttribute : Attribute
    {
        public string Name { get; }

        public ApplicationAttribute(string name )
        {
            Name = name;
        }
    }
}