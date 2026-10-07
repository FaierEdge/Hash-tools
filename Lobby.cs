namespace HashTool
{
	public partial class Lobby : Form
	{
		public Lobby()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Hide();
			GetHash Form = new GetHash();
			Form.ShowDialog();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Hide();
			HashCheck Form = new HashCheck();
			Form.ShowDialog();
			this.Close();
		}
	}
}