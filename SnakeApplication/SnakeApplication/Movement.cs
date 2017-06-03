namespace SnakeApplication
{
    public static class Movement
    {
        public static void MoveRight(this Dot dot)
        { 
            dot.X++;
        }

        public static void MoveLeft(this Dot dot)
        {
            dot.X--;
        }

        public static void MoveUp(this Dot dot)
        {
            dot.Y--;
        }

        public static void MoveDown(this Dot dot)
        {
            dot.Y++;
        }
    }
}
