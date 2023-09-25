using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinRobot
{
    public partial class Form1 : Form
    {
        //to store the x-axis and y-axis increment values
        int xinc = 0;
        int yinc = 0;
        //robot class instantiation
        ChildRobot r;
        public Form1()
        {
            InitializeComponent();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes form
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creates an object for robot
            r = new ChildRobot();
            //updates robot location
            updateArrowLabelLocation();
        }

        private void updateArrowLabelLocation()
        {
            
            pointLabel.Text = "{X: " + r.pos.X + ", Y: " + r.pos.Y + "}"; // Display TotalDistance
            distanceLbl.Text = "Total Distance = " + r.TotalDistance;
        }

        private void northButton_Click(object sender, EventArgs e)
        {
            //set north direction
            r.direction = "5";
            //update the label to north
            arrowLabel.Text = r.direction;
            //set xinc and yinc accordingly
            xinc = 0;
            yinc = -1;
        }


        private void southButton_Click(object sender, EventArgs e)
        {
            //set south direction
            r.direction = "6";
            //update the label to south
            arrowLabel.Text = r.direction;
            //set xinc and yinc accordingly
            xinc = 0;
            yinc = 1;
        }

        private void westButton_Click(object sender, EventArgs e)
        {
            //set east direction
            r.direction = "3";
            //update the label to east
            arrowLabel.Text = r.direction;
            //set xinc and yinc accordingly
            xinc = -1;
            yinc = 0;
        }

        private void eastButton_Click(object sender, EventArgs e)
        {
            //set west direction
            r.direction = "4";
            //update the label to west
            arrowLabel.Text = r.direction;
            //set xinc and yinc accordingly
            xinc = 1;
            yinc = 0;
        }

        private void goOneButton_Click(object sender, EventArgs e)
        {
            //get arrow label location
            Point p = arrowLabel.Location;
            //check if robot moves beyond 100 units, if move robot
            if (checkXY(r.pos.X + (1 * xinc), r.pos.Y + (1 * yinc)))
            {
                //increment x and y values and set robot position
                r.pos.X += (1 * xinc);
                r.pos.Y += (1 * yinc);
                arrowLabel.Location = new Point(p.X + (1 * xinc), p.Y + (1 * yinc));
                r.TotalDistance += 1; // Increment TotalDistance by 1
                updateArrowLabelLocation();
            }
            else
                //if robot is moved beyond 100 units, display error message
                displayErrorMessage();

        }

        private void displayErrorMessage()
        {
            //error message
            MessageBox.Show("Cannot move Robot beyond 100 units");
        }

        private void goTenButton_Click(object sender, EventArgs e)
        {
            //get arrow label location
            Point p = arrowLabel.Location;
            //check if robot moves beyond 100 units, if move robot            
            if (checkXY(r.pos.X + (10 * xinc), r.pos.Y + (10 * yinc)))
            {
                //increment x and y values and set robot position
                r.pos.X += (10 * xinc);
                r.pos.Y += (10 * yinc);
                arrowLabel.Location = new Point(p.X + (10 * xinc), p.Y + (10 * yinc));
                r.TotalDistance += 10; // Increment TotalDistance by 10
                updateArrowLabelLocation();
            }
            else
                //if robot is moved beyond 100 units, display error message
                displayErrorMessage();
        }

        private bool checkXY(int x, int y)
        {
            //check if robot is trying to move beyond 100 units in x and y axis
            if (Math.Abs(x) > 100)
                return false;
            if (Math.Abs(y) > 100)
                return false;
            return true;
        }

    }

}
