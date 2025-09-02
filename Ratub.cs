using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Collections;


namespace WordGuessingApp

{
    public partial class Form1 : Form
    {
        StringBuilder SB = new StringBuilder();
        private string RB = "Ratub";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SB.Append(textBox1.Text.Trim());

            if (SB.Equals(RB))
            {
                MessageBox.Show("Correct Guess", "Guess The Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label1.Text = RB;
            }

            else
            {
                listBox1.Items.Add(SB.ToString());
                MessageBox.Show("Wrong Guess", "Guess The Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SB.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
