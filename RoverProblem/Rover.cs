namespace RoverProblem
{
    public class Rover
    {
        private RoverPosition _roverPosition = new RoverPosition();
        public Rover(RoverPosition Position)
        {
            this._roverPosition = Position;
        }
        public void RotateRover(char rotateDirection)
        {
            switch (_roverPosition.GetDirection())
            {
                case 'n':
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
                case 's':
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
                case 'e':
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
                case 'w':
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
                case 'n':
                case 'N':
                    _roverPosition.SetYCord(_roverPosition.GetYCord() + 1);
                    break;
                case 's':
                case 'S':
                    _roverPosition.SetYCord(_roverPosition.GetYCord() - 1);
                    break;
                case 'e':
                case 'E':
                    _roverPosition.SetXCord(_roverPosition.GetXCord() + 1);
                    break;
                case 'w':
                case 'W':
                    _roverPosition.SetXCord(_roverPosition.GetXCord() - 1);
                    break;
                default:
                    break;
            }
        }

        public void ExecuteCommands(string commands)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                char command = commands[i];
                switch (command)
                {
                    case 'l':
                    case 'L':
                        this.RotateRover('L');
                        break;
                    case 'r':
                    case 'R':
                        this.RotateRover('R');
                        break;
                    case 'm':
                    case 'M':
                        this.MoveRover();
                        break;
                    default:
                        break;
                }
            }
        }

        public void PrintPosition(string positionType)
        {
            _roverPosition.PrintOnConsole(positionType);
        }

        public RoverPosition GetRoverPosition()
        {
            return _roverPosition;
        }
    }
}
