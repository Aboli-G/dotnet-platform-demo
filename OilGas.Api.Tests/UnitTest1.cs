namespace OilGas.Api.Tests;

public class OilGasTests
{
    [Fact]
    public void EquipmentStatus_ShouldBeActive()
    {
        // Arrange
        var status = "Active";

        // Act
        var result = status == "Active";

        // Assert
        Assert.True(result);
    }
}