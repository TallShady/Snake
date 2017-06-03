using System;

namespace SnakeApplication
{
    public class Frame
    {
        private bool[,] Internalframe { get;}

        public Frame()
        {       
            Internalframe = new bool[SnakeConstants.FrameMaxSize, SnakeConstants.FrameMaxSize];
        }

        public void CleanFrame(Dot dot)
        {
            Internalframe[dot.X, dot.Y] = false;
            Console.SetCursorPosition(dot.X, dot.Y);
            Console.Write(" ");
        }

        public void UpdateFrame(Dot dot)
        {
            Internalframe[dot.X, dot.Y] = true;
            Console.SetCursorPosition(dot.X,dot.Y);
            Console.Write("0");
        }

        public void DrawFrame()
        {
            //Draw top
            DrawTopOrBottom();
            Console.Write("\n");

            //Draw middle
            for (var i = 0; i < SnakeConstants.FrameMaxSize; i++)
            {
                Console.Write("|");
                for (var j = 0; j < SnakeConstants.FrameMaxSize; j++)
                {
                    Console.Write(Internalframe[i, j] ? "0" : " ");
                }
                Console.WriteLine("|");
            }

            //Draw bottom
            DrawTopOrBottom();
        }

        private static void DrawTopOrBottom()
        {
            for (var i = 0; i <= SnakeConstants.FrameMaxSize + 1; i++)
            {
                Console.Write("-");
            }
        }
    }
}
