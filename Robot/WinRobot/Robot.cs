using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinRobot
{
    public class Robot
    {
        //direction
        public string direction;
        //current position
        public Point pos;
        //constructor to initialize robot object
        public Robot()
        {
            direction = "5";
            pos.X = 0;
            pos.Y = 0;
        }
    }
}
