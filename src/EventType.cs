using Ardalis.SmartEnum;

namespace Soenneker.Enums.EventType;

/// <summary>
/// A generic enum for CRUD (Create, Read, Update, Delete)
/// </summary>
public sealed class EventType : SmartEnum<EventType>
{
    public static readonly EventType Create = new(nameof(Create), 0);
    public static readonly EventType Read = new(nameof(Read), 1);
    public static readonly EventType Update = new(nameof(Update), 2);
    public static readonly EventType Delete = new(nameof(Delete), 3);

    private EventType(string name, int value) : base(name, value)
    {
    }
}