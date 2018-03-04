using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int PreviousScore { get; set; }
        public static int RecordScore { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings(int record = 0)
        {
            Width = 16;
            Height = 16;
            Speed = 10;
            Score = 0;
            PreviousScore = 0;
            RecordScore = record;
            Points = 1;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
