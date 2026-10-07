namespace HashTool
{
    public partial class HashCheck : Form
    {
        public HashCheck()
        {
            InitializeComponent();
        }

        private void Comparate_Click(object sender, EventArgs e)
        {
            string FileHash = textBox1.Text;
            string SiteHash = textBox2.Text;

            if (FileHash == SiteHash)
            {
                label5.ForeColor = Color.Green;
                label5.Text = "Хеш одинаковый";
            }
            else
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Хеш различный";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Lobby Form = new Lobby();
            Form.ShowDialog();
            this.Close();
        }
    }
}
