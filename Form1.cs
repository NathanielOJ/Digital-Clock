namespace Digitalclock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            orangeButton.FlatStyle = FlatStyle.Flat;
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            Clocktimer.Start();
        }

        private void Clocktimer_Tick(object sender, EventArgs e)
        {
            clocklabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Red;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Yellow;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Orange;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Green;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Blue;
        }

        private void styleButton_Click(object sender, EventArgs e)
        {
            clocklabel.Font = new Font("Snap ITC", 90, FontStyle.Regular);
        }

        private void styleButton2_Click(object sender, EventArgs e)
        {
            clocklabel.Font = new Font("Showcard Gothic", 90, FontStyle.Regular);
        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            clocklabel.Font = new Font("Poor Richard", 90, FontStyle.Regular);
        }
    }
}