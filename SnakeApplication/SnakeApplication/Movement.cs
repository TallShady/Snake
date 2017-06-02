using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication
{
    public static class Movement
    {
        public static void MoveRight(this Dot dot)
        { 
            dot.x++;
        }

        public static void MoveLeft(this Dot dot)
        {
            dot.x--;
        }

        public static void MoveUp(this Dot dot)
        {
            dot.y--;
        }

        public static void MoveDown(this Dot dot)
        {
            dot.y++;
        }

        public static int Modulo(this int x, int y)
        {
            return x > 0 ? x % y : y - (-x % y) ;
        }
    }
}
