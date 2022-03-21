namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            int seconds = 0;
            int minutes;
            int hours;
            int months;

            seconds = int.Parse(txt_inputSec.Text);

            if (seconds >= 60 && seconds <= 3599)
            {
                minutes = seconds / 60;
                txt_min.Text = minutes.ToString();
            }
            else if (seconds >= 3600 && seconds <= 86399)
            {
                hours = seconds / 3600;
                txt_hrs.Text = hours.ToString();
            }
            else if (seconds >= 86400)
            {
                months = seconds / 86400;
                txt_months.Text = months.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Entery, Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}