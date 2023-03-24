namespace ticketform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.desCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pmCb = new System.Windows.Forms.ComboBox();
            this.pictureBox_QRCode = new System.Windows.Forms.PictureBox();
            this.pictureBox_Barcode = new System.Windows.Forms.PictureBox();
            this.txtDataBarcode = new System.Windows.Forms.TextBox();
            this.txtDataQRCode = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.qrcodeLabel = new System.Windows.Forms.Label();
            this.displayBtn = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.creditNum = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.scanBtn = new System.Windows.Forms.Button();
            this.creditSubmit = new System.Windows.Forms.Button();
            this.ticketGrd = new System.Windows.Forms.DataGridView();
            this.showticketLb = new System.Windows.Forms.Label();
            this.showTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Destionation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // desCb
            // 
            this.desCb.FormattingEnabled = true;
            this.desCb.Location = new System.Drawing.Point(205, 18);
            this.desCb.Name = "desCb";
            this.desCb.Size = new System.Drawing.Size(382, 28);
            this.desCb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Payment Method";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pmCb
            // 
            this.pmCb.FormattingEnabled = true;
            this.pmCb.Items.AddRange(new object[] {
            "Momo",
            "Credit Card"});
            this.pmCb.Location = new System.Drawing.Point(205, 77);
            this.pmCb.Name = "pmCb";
            this.pmCb.Size = new System.Drawing.Size(382, 28);
            this.pmCb.TabIndex = 3;
            this.pmCb.SelectedIndexChanged += new System.EventHandler(this.pmCb_SelectedIndexChanged);
            // 
            // pictureBox_QRCode
            // 
            this.pictureBox_QRCode.Location = new System.Drawing.Point(14, 257);
            this.pictureBox_QRCode.Name = "pictureBox_QRCode";
            this.pictureBox_QRCode.Size = new System.Drawing.Size(194, 177);
            this.pictureBox_QRCode.TabIndex = 4;
            this.pictureBox_QRCode.TabStop = false;
            // 
            // pictureBox_Barcode
            // 
            this.pictureBox_Barcode.Location = new System.Drawing.Point(12, 209);
            this.pictureBox_Barcode.Name = "pictureBox_Barcode";
            this.pictureBox_Barcode.Size = new System.Drawing.Size(382, 42);
            this.pictureBox_Barcode.TabIndex = 5;
            this.pictureBox_Barcode.TabStop = false;
            // 
            // txtDataBarcode
            // 
            this.txtDataBarcode.Location = new System.Drawing.Point(205, 122);
            this.txtDataBarcode.Name = "txtDataBarcode";
            this.txtDataBarcode.Size = new System.Drawing.Size(382, 27);
            this.txtDataBarcode.TabIndex = 6;
            // 
            // txtDataQRCode
            // 
            this.txtDataQRCode.Location = new System.Drawing.Point(205, 166);
            this.txtDataQRCode.Name = "txtDataQRCode";
            this.txtDataQRCode.Size = new System.Drawing.Size(382, 27);
            this.txtDataQRCode.TabIndex = 7;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(12, 125);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(123, 20);
            this.barcodeLabel.TabIndex = 8;
            this.barcodeLabel.Text = "Data for barcode";
            // 
            // qrcodeLabel
            // 
            this.qrcodeLabel.AutoSize = true;
            this.qrcodeLabel.Location = new System.Drawing.Point(12, 166);
            this.qrcodeLabel.Name = "qrcodeLabel";
            this.qrcodeLabel.Size = new System.Drawing.Size(125, 20);
            this.qrcodeLabel.TabIndex = 9;
            this.qrcodeLabel.Text = "Data for QR code";
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(593, 162);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(176, 34);
            this.displayBtn.TabIndex = 10;
            this.displayBtn.Text = "Hiển thị QR code";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(14, 125);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(158, 20);
            this.creditLabel.TabIndex = 11;
            this.creditLabel.Text = "Enter number of credit";
            this.creditLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // creditNum
            // 
            this.creditNum.Location = new System.Drawing.Point(205, 122);
            this.creditNum.Name = "creditNum";
            this.creditNum.Size = new System.Drawing.Size(382, 27);
            this.creditNum.TabIndex = 12;
            this.creditNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(123, 267);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(136, 30);
            this.scanBtn.TabIndex = 13;
            this.scanBtn.Text = "Click to Scan";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // creditSubmit
            // 
            this.creditSubmit.Location = new System.Drawing.Point(593, 118);
            this.creditSubmit.Name = "creditSubmit";
            this.creditSubmit.Size = new System.Drawing.Size(176, 34);
            this.creditSubmit.TabIndex = 18;
            this.creditSubmit.Text = "Submit";
            this.creditSubmit.UseVisualStyleBackColor = true;
            this.creditSubmit.Click += new System.EventHandler(this.creditSubmit_Click);
            // 
            // ticketGrd
            // 
            this.ticketGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGrd.Location = new System.Drawing.Point(265, 257);
            this.ticketGrd.Name = "ticketGrd";
            this.ticketGrd.RowHeadersWidth = 51;
            this.ticketGrd.RowTemplate.Height = 29;
            this.ticketGrd.Size = new System.Drawing.Size(529, 181);
            this.ticketGrd.TabIndex = 19;
            // 
            // showticketLb
            // 
            this.showticketLb.AutoSize = true;
            this.showticketLb.Location = new System.Drawing.Point(514, 231);
            this.showticketLb.Name = "showticketLb";
            this.showticketLb.Size = new System.Drawing.Size(78, 20);
            this.showticketLb.TabIndex = 20;
            this.showticketLb.Text = "Your ticket";
            // 
            // showTicket
            // 
            this.showTicket.Location = new System.Drawing.Point(123, 313);
            this.showTicket.Name = "showTicket";
            this.showTicket.Size = new System.Drawing.Size(136, 30);
            this.showTicket.TabIndex = 21;
            this.showTicket.Text = "Show ticket";
            this.showTicket.UseVisualStyleBackColor = true;
            this.showTicket.Click += new System.EventHandler(this.showTicket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.showTicket);
            this.Controls.Add(this.showticketLb);
            this.Controls.Add(this.ticketGrd);
            this.Controls.Add(this.creditSubmit);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.creditNum);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.qrcodeLabel);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.txtDataQRCode);
            this.Controls.Add(this.txtDataBarcode);
            this.Controls.Add(this.pictureBox_Barcode);
            this.Controls.Add(this.pictureBox_QRCode);
            this.Controls.Add(this.pmCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desCb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ticket Vendor Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox desCb;
        private Label label2;
        private ComboBox pmCb;
        private PictureBox pictureBox_QRCode;
        private PictureBox pictureBox_Barcode;
        private TextBox txtDataBarcode;
        private TextBox txtDataQRCode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label barcodeLabel;
        private Label qrcodeLabel;
        private Button displayBtn;
        private Label creditLabel;
        private TextBox creditNum;
        private NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button scanBtn;
        private Button creditSubmit;
        private DataGridView ticketGrd;
        private Label showticketLb;
        private Button showTicket;
    }
}