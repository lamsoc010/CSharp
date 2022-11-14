namespace WinformApp
{
    partial class SliderShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lnkChonThuMuc = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flpImage = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkChonThuMuc
            // 
            this.lnkChonThuMuc.AutoSize = true;
            this.lnkChonThuMuc.Location = new System.Drawing.Point(12, 9);
            this.lnkChonThuMuc.Name = "lnkChonThuMuc";
            this.lnkChonThuMuc.Size = new System.Drawing.Size(96, 15);
            this.lnkChonThuMuc.TabIndex = 0;
            this.lnkChonThuMuc.TabStop = true;
            this.lnkChonThuMuc.Text = "Chọn thư mục ...";
            this.lnkChonThuMuc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChonThuMuc_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 343);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flpImage
            // 
            this.flpImage.AutoScroll = true;
            this.flpImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpImage.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpImage.Location = new System.Drawing.Point(658, 0);
            this.flpImage.Name = "flpImage";
            this.flpImage.Size = new System.Drawing.Size(127, 450);
            this.flpImage.TabIndex = 2;
            // 
            // SliderShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnkChonThuMuc);
            this.Controls.Add(this.flpImage);
            this.Name = "SliderShowForm";
            this.Text = "SliderShowForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel lnkChonThuMuc;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flpImage;
    }
}