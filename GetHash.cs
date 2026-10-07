using System.Text;
using SHA256 = System.Security.Cryptography.SHA256;

namespace HashTool
{
    public partial class GetHash : Form
    {
        public GetHash()
        {
            InitializeComponent();
        }

        private void Get_Hash_Click(object sender, EventArgs e)
        {
            string Password = textBox1.Text;
            SHA256 sha256 = SHA256.Create();
            byte[] Bytes = Encoding.UTF8.GetBytes(Password);
            byte[] Hash = sha256.ComputeHash(Bytes);
            sha256.Dispose();
            string PasswordHash = BitConverter.ToString(Hash).ToLower().Replace("-", "");
            label4.Text = PasswordHash;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label4.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show($"Ошибка: Пустое поле для копирования");
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Ошибка: {Ex}");
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