using System;

namespace JsonSerializableDemo
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class DrxpendableAttribute : Attribute
    {
    }
}