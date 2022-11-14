namespace WinformApp
{
    partial class ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkChonFile = new System.Windows.Forms.LinkLabel();
            this.btnLatDoc = new System.Windows.Forms.Button();
            this.btnLatNgang = new System.Windows.Forms.Button();
            this.btnXoayPhai = new System.Windows.Forms.Button();
            this.btnXoayTrai = new System.Windows.Forms.Button();
            this.cmbCheDo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 347);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lnkChonFile);
            this.panel2.Controls.Add(this.btnLatDoc);
            this.panel2.Controls.Add(this.btnLatNgang);
            this.panel2.Controls.Add(this.btnXoayPhai);
            this.panel2.Controls.Add(this.btnXoayTrai);
            this.panel2.Controls.Add(this.cmbCheDo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 103);
            this.panel2.TabIndex = 1;
            // 
            // lnkChonFile
            // 
            this.lnkChonFile.AutoSize = true;
            this.lnkChonFile.Location = new System.Drawing.Point(728, 79);
            this.lnkChonFile.Name = "lnkChonFile";
            this.lnkChonFile.Size = new System.Drawing.Size(66, 15);
            this.lnkChonFile.TabIndex = 6;
            this.lnkChonFile.TabStop = true;
            this.lnkChonFile.Text = "Chọn File...";
            this.lnkChonFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChonFile_LinkClicked);
            // 
            // btnLatDoc
            // 
            this.btnLatDoc.Location = new System.Drawing.Point(320, 52);
            this.btnLatDoc.Name = "btnLatDoc";
            this.btnLatDoc.Size = new System.Drawing.Size(75, 23);
            this.btnLatDoc.TabIndex = 5;
            this.btnLatDoc.Text = "Lật Dọc";
            this.btnLatDoc.UseVisualStyleBackColor = true;
            this.btnLatDoc.Click += new System.EventHandler(this.btnLatDoc_Click);
            // 
            // btnLatNgang
            // 
            this.btnLatNgang.Location = new System.Drawing.Point(221, 52);
            this.btnLatNgang.Name = "btnLatNgang";
            this.btnLatNgang.Size = new System.Drawing.Size(75, 23);
            this.btnLatNgang.TabIndex = 4;
            this.btnLatNgang.Text = "Lật Ngang";
            this.btnLatNgang.UseVisualStyleBackColor = true;
            this.btnLatNgang.Click += new System.EventHandler(this.btnLatNgang_Click);
            // 
            // btnXoayPhai
            // 
            this.btnXoayPhai.Location = new System.Drawing.Point(320, 13);
            this.btnXoayPhai.Name = "btnXoayPhai";
            this.btnXoayPhai.Size = new System.Drawing.Size(75, 23);
            this.btnXoayPhai.TabIndex = 3;
            this.btnXoayPhai.Text = "Xoay Phải";
            this.btnXoayPhai.UseVisualStyleBackColor = true;
            this.btnXoayPhai.Click += new System.EventHandler(this.btnXoayPhai_Click);
            // 
            // btnXoayTrai
            // 
            this.btnXoayTrai.Location = new System.Drawing.Point(221, 13);
            this.btnXoayTrai.Name = "btnXoayTrai";
            this.btnXoayTrai.Size = new System.Drawing.Size(75, 23);
            this.btnXoayTrai.TabIndex = 2;
            this.btnXoayTrai.Text = "Xoay Trái";
            this.btnXoayTrai.UseVisualStyleBackColor = true;
            this.btnXoayTrai.Click += new System.EventHandler(this.btnXoayTrai_Click);
            // 
            // cmbCheDo
            // 
            this.cmbCheDo.FormattingEnabled = true;
            this.cmbCheDo.Items.AddRange(new object[] {
            "AutoSize",
            "Strech",
            "Zoom",
            "Center"});
            this.cmbCheDo.Location = new System.Drawing.Point(63, 14);
            this.cmbCheDo.Name = "cmbCheDo";
            this.cmbCheDo.Size = new System.Drawing.Size(121, 23);
            this.cmbCheDo.TabIndex = 1;
            this.cmbCheDo.SelectedIndexChanged += new System.EventHandler(this.cmbCheDo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chế độ:";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(678, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 347);
            this.panel3.TabIndex = 1;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ComboBox cmbCheDo;
        private Label label1;
        private Button btnXoayPhai;
        private Button btnXoayTrai;
        private Button btnLatPhai;
        private Button btnLatTrai;
        private Button btnLatDoc;
        private Button btnLatNgang;
        private LinkLabel lnkChonFile;
        private Panel panel3;
    }
}