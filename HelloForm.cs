using System.Windows.Forms.VisualStyles;

namespace WinformApp
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int _soThuNhat = Int32.Parse(txtSoThuNhat.Text);
            int _soThuHai = Int32.Parse(txtSoThuHai.Text);
            int _ketQua = _soThuNhat + _soThuHai;
            lblKetQua.Text = _ketQua.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int _soThuNhat = Int32.Parse(txtSoThuNhat.Text);
            int _soThuHai = Int32.Parse(txtSoThuHai.Text);
            int _ketQua = _soThuNhat - _soThuHai;
            lblKetQua.Text = _ketQua.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int _soThuNhat = Convert.ToInt32(txtSoThuNhat.Text);
            int _soThuHai = Int32.Parse(txtSoThuHai.Text);
            int _ketQua = _soThuNhat * _soThuHai;
            lblKetQua.Text = _ketQua.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float _soThuNhat = float.Parse(txtSoThuNhat.Text);
            float _soThuHai = float.Parse(txtSoThuHai.Text);
            float _ketQua = _soThuNhat / _soThuHai;
            lblKetQua.Text = _ketQua.ToString();
        }

        ErrorProvider error;
        private void txtSoThuNhat_TextChanged(object sender, EventArgs e)
        {
            if(error == null)
            {
                error = new ErrorProvider();
            }
            error.Clear();
            int soThuNhat = 0;
            if(!Int32.TryParse(txtSoThuNhat.Text, out soThuNhat))
            {
                txtSoThuNhat.Text = "";
                error.SetError(txtSoThuNhat, "Vui lòng nhập số");
            }
        }
    }
}