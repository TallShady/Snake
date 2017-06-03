namespace SnakeApplication
{
    public class Dot
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value.Modulo(SnakeConstants.FrameMaxSize); }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value.Modulo(SnakeConstants.FrameMaxSize); }
        }

        public Dot()
        {
            X = 10;
            Y = 10;
        }

    }
}
