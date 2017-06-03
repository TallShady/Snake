namespace SnakeApplication
{
    public static class Helpers
    {
        public static int Modulo(this int x, int y)
        {
            return (y + x % y) % y;
        }
    }
}
