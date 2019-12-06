using RoverProblem;
using Xunit;

namespace RoverProblemFixtures
{
    public class RoverTests
    {
        [Fact]
        public void Test()
        {
            RoverPosition actualPosition = new RoverPosition(0, 0, 'N');
            Rover rover = new Rover(actualPosition);
            rover.ExecuteCommands("LMMMRMMR");
            actualPosition = rover.GetRoverPosition();
            RoverPosition expectedPosition = new RoverPosition(-3, 2, 'E');
            char actulDir = actualPosition.GetDirection();
            char expectedDir = expectedPosition.GetDirection();
            Assert.Equal(actulDir, expectedDir);
        }
    }
}
