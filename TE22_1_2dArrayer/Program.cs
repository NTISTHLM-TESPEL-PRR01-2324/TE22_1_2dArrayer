int[,] board = new int[8, 8];

board[3, 2] = 1;
board[5, 0] = 5;

int space = 2;


for (int y = 0; y < board.GetLength(1); y++)
{
  for (int x = 0; x < board.GetLength(0); x++)
  {
    Console.SetCursorPosition(x * space, y * space);

    Console.Write(board[x, y]);
  }
}


// Console.Write(board[1, 0]);
// Console.Write(board[2, 0]);
// Console.Write(board[3, 0]);
// Console.Write(board[4, 0]);
// Console.Write(board[5, 0]);
// Console.Write(board[6, 0]);
// Console.Write(board[7, 0]);



// Console.WriteLine();
// Console.Write(board[0, 1]);
// Console.Write(board[1, 1]);
// Console.Write(board[2, 1]);

// List<int> numbers = new List<int>() { 3, 6, 45 };

// numbers.Add(89);

// string[] names = { "Micke", "Martin", "Lena" };

// Console.WriteLine(names[1]);


Console.ReadLine();