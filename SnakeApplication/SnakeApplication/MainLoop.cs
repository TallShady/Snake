using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication
{
    public static class MainLoop
    {
        private static bool loop { get; set;}

        static MainLoop()
        {
            loop = true;
        }


        public static void Loop()
        {
            //initiate dot and the frame
            var dot = new Dot();
            var frame = new Frame();

            Console.CursorVisible = false;
            frame.DrawFrame();

            do
            {
                //Console.Clear();
                //Draw the frame and print dot
                
                //read input
                
                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    switch(key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            frame.CleanFrame(dot);
                            dot.MoveDown();
                            frame.UpdateFrame(dot);
                            break;
                        case ConsoleKey.LeftArrow:
                            frame.CleanFrame(dot);
                            dot.MoveLeft();
                            frame.UpdateFrame(dot);
                            break;
                        case ConsoleKey.RightArrow:
                            frame.CleanFrame(dot);
                            dot.MoveRight();
                            frame.UpdateFrame(dot);
                            break;
                        case ConsoleKey.UpArrow:
                            frame.CleanFrame(dot);
                            dot.MoveUp();
                            frame.UpdateFrame(dot);
                            break;
                        default:
                            loop = false;
                            break;
                    }
                }

                frame.UpdateFrame(dot);

                //refreshRate
                System.Threading.Thread.Sleep(99);
            } while (loop);
            Console.ReadKey();
        }
    }
}
