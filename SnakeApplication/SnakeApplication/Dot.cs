using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication
{
    public class Dot
    {
        private int _x;
        private int _y;

        public int x
        {
            get { return _x; }
            set { _x = value.Modulo(SnakeConstants.FrameMaxSize); }
        }
        public int y
        {
            get { return _y; }
            set { _y = value.Modulo(SnakeConstants.FrameMaxSize); }
        }

        public Dot()
        {
            x = 10;
            y = 10;
        }

    }
}
