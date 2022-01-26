using System;

namespace HelloGameWorld
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new HelloGameWorldGame())
                game.Run();
        }
    }
}
