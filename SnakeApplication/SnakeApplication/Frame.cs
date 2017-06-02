using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication
{
    public class Frame
    {
        private bool[,] frame { get; set; }

        public Frame()
        {
            frame = new bool[SnakeConstants.FrameMaxSize, SnakeConstants.FrameMaxSize];
        }

        public void CleanFrame(Dot dot)
        {
            frame[dot.x, dot.y] = false;
            Console.SetCursorPosition(dot.x, dot.y);
            Console.Write(" ");
        }

        public void UpdateFrame(Dot dot)
        {
            frame[dot.x, dot.y] = true;
            Console.SetCursorPosition(dot.x,dot.y);
            Console.Write("0");
        }

        public void DrawFrame()
        {
            //Draw top
            DrawTopOrBottom();
            Console.Write("\n");

            //Draw middle
            for (int i = 0; i < SnakeConstants.FrameMaxSize; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SnakeConstants.FrameMaxSize; j++)
                {
                    Console.Write(frame[i, j] ? "0" : " ");
                }
                Console.WriteLine("|");
            }

            //Draw bottom
            DrawTopOrBottom();
        }

        private void DrawTopOrBottom()
        {
            for (int i = 0; i <= SnakeConstants.FrameMaxSize + 1; i++)
            {
                Console.Write("-");
            }
        }
    }
}
