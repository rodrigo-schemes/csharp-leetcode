using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class ParkingSystemTests
{
    [Fact]
    public void ParkingSystem_UnitTest()
    {
        var result = new List<bool>();
        var expected = new List<bool> { true, true, false, false };
        
        var parkingSystem = new ParkingSystem(1, 1, 0);
        result.Add(parkingSystem.AddCar(1));
        result.Add(parkingSystem.AddCar(2));
        result.Add(parkingSystem.AddCar(3));
        result.Add(parkingSystem.AddCar(1));

        result.Should().BeEquivalentTo(expected);
    }
}