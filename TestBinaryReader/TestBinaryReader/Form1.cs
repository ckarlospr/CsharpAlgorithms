using System.Security.Cryptography;

namespace TestBinaryReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofd.FileName;
            }


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            if (txtFile.Text != "")
            {
                FileStream fs = new FileStream(txtFile.Text, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                int cnt = Convert.ToInt16(txtCnt.Text);

                Byte[] bytes = br.ReadBytes(cnt);
                txtResult.Text += BitConverter.ToString(bytes);
                txtResult.Text += "\n";
                Array.Reverse(bytes);
                txtResult.Text += "\n";
                foreach (Byte b in bytes) txtResult.Text += b.ToString();
                txtResult.Text += "\n";
                txtResult.Text += BitConverter.ToString(bytes);

                MessageBox.Show(br.Read() + "");
                fs.Close();
            }
        }
    }
}