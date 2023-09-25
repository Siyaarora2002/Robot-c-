
namespace WinRobot
{
    public class ChildRobot : Robot
    {
        public int TotalDistance { get; set; }

        public ChildRobot() : base()
        {
            TotalDistance = 0;
        }
    }
}
