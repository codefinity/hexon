using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefinity.Hexon.Architecture
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class ComponentTypeAttribute : Attribute
    {
        public string Id { get; }

        public ComponentTypeAttribute(string id)
        {
            Id = id;
        }
    }
}