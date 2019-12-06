namespace RoverProblem
{
    class RoverPosition
    {
        private int _x;
        private int _y;
        private char _direction;

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

        public void initialize(int xCoordinateValue, int yCoordinateValue, char directionValue)
        {
            this._x = xCoordinateValue;
            this._y = yCoordinateValue;
            this._direction = directionValue;
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

    }
}
