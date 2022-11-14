namespace WinformApp
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numPhut = new System.Windows.Forms.NumericUpDown();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThietLap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian (phút):";
            // 
            // numPhut
            // 
            this.numPhut.Location = new System.Drawing.Point(148, 77);
            this.numPhut.Name = "numPhut";
            this.numPhut.Size = new System.Drawing.Size(57, 23);
            this.numPhut.TabIndex = 1;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(225, 185);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // btnThietLap
            // 
            this.btnThietLap.Location = new System.Drawing.Point(144, 185);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(75, 23);
            this.btnThietLap.TabIndex = 3;
            this.btnThietLap.Text = "Thiết Lập";
            this.btnThietLap.UseVisualStyleBackColor = true;
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuayLai;
            this.ClientSize = new System.Drawing.Size(312, 220);
            this.Controls.Add(this.btnThietLap);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.numPhut);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown numPhut;
        private Button btnQuayLai;
        private Button btnThietLap;
    }
}