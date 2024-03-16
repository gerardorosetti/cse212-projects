/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

    // Todo Maze Problem - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    private void Move(int index)
    {
        ValueTuple<int, int> current_point = (_currX, _currY);
        if(_mazeMap[current_point][index])
        {
            Console.Write($"Moved from: {current_point}");
            switch (index)
            {
                case 0: 
                    _currX -= 1;
                    break;
                case 1: 
                    _currX += 1;
                    break;
                case 2: 
                    _currY -= 1;
                    break;
                case 3: 
                    _currY += 1;
                    break;
                default:
                    break;
            }
            ValueTuple<int, int> new_point = (_currX, _currY);
            Console.WriteLine($" to: {new_point}");
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }
    public void MoveLeft() {
        // FILL IN CODE
        Console.Write("Action: Move-Left: ");
        Move(0);
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight() {
        // FILL IN CODE
        Console.Write("Action: Move-Right: ");
        Move(1);
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp() {
        // FILL IN CODE
        Console.Write("Action: Move-Up: ");
        Move(2);
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown() {
        // FILL IN CODE
        Console.Write("Action: Move-Down: ");
        Move(3);
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}