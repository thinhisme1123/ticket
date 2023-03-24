using QRCoder;
using BarcodeLib;
using System.Data;
using System.Data.SqlClient;

namespace ticketform
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        BarcodeLib.Barcode code128;
        public Form1()
        {
            InitializeComponent();
            code128 = new Barcode();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void loadCombo()
        {
            string s = "select * from destination";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            desCb.DataSource = tb;
            desCb.DisplayMember = "name";
            desCb.ValueMember = "cost";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = ticketmachine; data source = MSIGF66\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(sql);
            cn.Open();
            disable_code();
            creditLabel.Visible= false;
            creditNum.Visible= false;
            loadCombo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void disable_code()
        {
            barcodeLabel.Visible = false;
            qrcodeLabel.Visible= false;
            txtDataBarcode.Visible = false;
            txtDataQRCode.Visible = false;
            displayBtn.Visible = false;
            scanBtn.Visible = false;
            creditSubmit.Visible = false;
            showticketLb.Visible = false;
            ticketGrd.Visible = false;
            showTicket.Visible = false;

        }
        void show_code()
        {
            barcodeLabel.Visible = true;
            qrcodeLabel.Visible = true;
            txtDataBarcode.Visible = true;
            txtDataQRCode.Visible = true;
            displayBtn.Visible = true;
            creditLabel.Visible= false;

        }

        private void pmCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pmCb.Text == "Momo")
            {
                show_code();
            }
            else
            {
                disable_code();
                creditLabel.Visible = true;
                creditNum.Visible= true;
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, txtDataBarcode.Text);
            pictureBox_Barcode.Image = barcode;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(txtDataQRCode.Text, QRCodeGenerator.ECCLevel.Q));
            pictureBox_QRCode.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
            scanBtn.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            //insert into ticket values ("13212", 1000,'weqweqew', 'qewqweq'),

            string uniqueID = Guid.NewGuid().ToString();
            string insertValue = "insert into ticket values ('" + uniqueID + "','" + desCb.SelectedValue.ToString() + "','" + pmCb.Text + "','" +  desCb.Text + "')";
            cm = new SqlCommand(insertValue, cn);
            cm.ExecuteNonQuery();

            showTicket.Visible = true;
            ticketGrd.Visible = true;
            showticketLb.Visible = true;

        }

        private void ticket_Click(object sender, EventArgs e)
        {

        }

        private void creditSubmit_Click(object sender, EventArgs e)
        {

        }

        private void showTicket_Click(object sender, EventArgs e)
        {
            
            string s = "select * from ticket";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            ticketGrd.DataSource = tb;
        }
    }
}