using System;

namespace QuickMapper.Common.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class MapToAttribute : Attribute
{
    public MapToAttribute(params Type[] TargetTypes) {
        this.TargetTypes = TargetTypes;
    }
    public Type[] TargetTypes { get; }
}
