namespace RoverProblem
{
    class Rover
    {
        private RoverPosition _roverPosition;
        public Rover(int xCordinate, int yCoordinate, char direction)
        {
            _roverPosition.initialize(xCordinate, yCoordinate, direction);
        }
        public void RotateRover(char rotateDirection)
        {
            switch (_roverPosition.GetDirection())
            {
                case 'N':
                    if (rotateDirection == 'L')
                    {
                        _roverPosition.SetDirection('W');
                    }
                    else if (rotateDirection == 'R')
                    {
                        _roverPosition.SetDirection('E');
                    }
                    break;
                case 'S':
                    if (rotateDirection == 'L')
                    {
                        _roverPosition.SetDirection('E');
                    }
                    else if (rotateDirection == 'R')
                    {
                        _roverPosition.SetDirection('W');
                    }
                    break;
                case 'E':
                    if (rotateDirection == 'L')
                    {
                        _roverPosition.SetDirection('N');
                    }
                    else if (rotateDirection == 'R')
                    {
                        _roverPosition.SetDirection('S');
                    }
                    break;
                case 'W':
                    if (rotateDirection == 'L')
                    {
                        _roverPosition.SetDirection('S');
                    }
                    else if (rotateDirection == 'R')
                    {
                        _roverPosition.SetDirection('N');
                    }
                    break;
                default:
                    break;
            }
        }

        public void MoveRover()
        {
            switch (_roverPosition.GetDirection())
            {
                case 'N':
                    _roverPosition.SetYCord(_roverPosition.GetYCord() + 1);
                    break;
                case 'S':
                    _roverPosition.SetYCord(_roverPosition.GetYCord() - 1);
                    break;
                case 'E':
                    _roverPosition.SetXCord(_roverPosition.GetXCord() + 1);
                    break;
                case 'W':
                    _roverPosition.SetXCord(_roverPosition.GetXCord() - 1);
                    break;
                default:
                    break;
            }
        }
    }
}
