using System;

namespace RoverProblem
{
    public class RoverPosition
    {
        private int _x;
        private int _y;
        private char _direction;

        public RoverPosition(int x = 0, int y = 0, char direction = 'N')
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        public int GetXCord()
        {
            return _x;
        }

        public int GetYCord()
        {
            return _y;
        }

        public char GetDirection()
        {
            return _direction;
        }

        public void SetXCord(int newXCoordinateValue)
        {
            this._x = newXCoordinateValue;
        }
        public void SetYCord(int newYCoordinateValue)
        {
            this._y = newYCoordinateValue;
        }

        public void SetDirection(char newDirection)
        {
            this._direction = newDirection;
        }

        public void PrintOnConsole(string PositionType)
        {
            Console.WriteLine(PositionType + " Position: (" + _x + "," + _y + "," + _direction + ")");
        }

    }
}
