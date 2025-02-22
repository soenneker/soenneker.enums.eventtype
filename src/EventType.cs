using Intellenum;

namespace Soenneker.Enums.EventType;

/// <summary>
/// A generic enum for CRUD (Create, Read, Update, Delete)
/// </summary>
[Intellenum<string>]
public partial class EventType
{
    public static readonly EventType Create = new(nameof(Create));

    public static readonly EventType Read = new(nameof(Read));

    public static readonly EventType Update = new(nameof(Update));

    public static readonly EventType Delete = new(nameof(Delete));
}