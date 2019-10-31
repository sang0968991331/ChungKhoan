namespace DetaiChungKhoan
{
    partial class btn_tapd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_tapD = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_maHoa = new System.Windows.Forms.ListView();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbMinSup = new System.Windows.Forms.Label();
            this.btntapd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_tapD);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tâp D";
            // 
            // lv_tapD
            // 
            this.lv_tapD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_tapD.Location = new System.Drawing.Point(3, 16);
            this.lv_tapD.Name = "lv_tapD";
            this.lv_tapD.Size = new System.Drawing.Size(715, 255);
            this.lv_tapD.TabIndex = 0;
            this.lv_tapD.UseCompatibleStateImageBehavior = false;
            this.lv_tapD.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_maHoa);
            this.groupBox2.Location = new System.Drawing.Point(739, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã Hóa";
            // 
            // lv_maHoa
            // 
            this.lv_maHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_maHoa.Location = new System.Drawing.Point(3, 16);
            this.lv_maHoa.Name = "lv_maHoa";
            this.lv_maHoa.Size = new System.Drawing.Size(204, 255);
            this.lv_maHoa.TabIndex = 0;
            this.lv_maHoa.UseCompatibleStateImageBehavior = false;
            this.lv_maHoa.View = System.Windows.Forms.View.Details;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(44, 362);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(477, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbMinSup
            // 
            this.lbMinSup.AutoSize = true;
            this.lbMinSup.Location = new System.Drawing.Point(234, 334);
            this.lbMinSup.Name = "lbMinSup";
            this.lbMinSup.Size = new System.Drawing.Size(52, 13);
            this.lbMinSup.TabIndex = 3;
            this.lbMinSup.Text = "MinSup : ";
            // 
            // btntapd
            // 
            this.btntapd.Location = new System.Drawing.Point(64, 448);
            this.btntapd.Name = "btntapd";
            this.btntapd.Size = new System.Drawing.Size(75, 23);
            this.btntapd.TabIndex = 4;
            this.btntapd.Text = "Tìm tập D";
            this.btntapd.UseVisualStyleBackColor = true;
            this.btntapd.Click += new System.EventHandler(this.btntapd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tapd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntapd);
            this.Controls.Add(this.lbMinSup);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "btn_tapd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_tapD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_maHoa;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbMinSup;
        private System.Windows.Forms.Button btntapd;
        private System.Windows.Forms.Button button1;
    }
}

