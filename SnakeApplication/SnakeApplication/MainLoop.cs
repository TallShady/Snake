using System;

namespace SnakeApplication
{
    public static class MainLoop
    {
        private static bool Loop { get; set;}

        static MainLoop()
        {
            Loop = true;
        }


        public static void StartLoop()
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
                            Loop = false;
                            break;
                    }
                }

                frame.UpdateFrame(dot);

                //refreshRate
                System.Threading.Thread.Sleep(99);
            } while (Loop);
            Console.ReadKey();
        }
    }
}
