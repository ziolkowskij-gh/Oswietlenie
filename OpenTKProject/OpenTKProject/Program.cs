﻿using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            using (var mainWindow = new MainWindow())
            {
                mainWindow.Run();
            }
        }
    }
}
