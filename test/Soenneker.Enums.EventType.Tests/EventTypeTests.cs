using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Enums.EventType.Tests;

[Collection("Collection")]
public class EventTypeTests : FixturedUnitTest
{
    public EventTypeTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
