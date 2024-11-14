namespace OOPDevam_0
{
    partial class Form2
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
            this.LstSonuc = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciIsim = new System.Windows.Forms.TextBox();
            this.TxtOgrenciSoyIsim = new System.Windows.Forms.TextBox();
            this.TxtLabNo = new System.Windows.Forms.TextBox();
            this.TxtLabKat = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnLabYarat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstSonuc
            // 
            this.LstSonuc.FormattingEnabled = true;
            this.LstSonuc.ItemHeight = 22;
            this.LstSonuc.Location = new System.Drawing.Point(83, 300);
            this.LstSonuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LstSonuc.Name = "LstSonuc";
            this.LstSonuc.Size = new System.Drawing.Size(1060, 378);
            this.LstSonuc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ogrenci";
            // 
            // TxtOgrenciIsim
            // 
            this.TxtOgrenciIsim.Location = new System.Drawing.Point(83, 96);
            this.TxtOgrenciIsim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtOgrenciIsim.Name = "TxtOgrenciIsim";
            this.TxtOgrenciIsim.Size = new System.Drawing.Size(124, 28);
            this.TxtOgrenciIsim.TabIndex = 2;
            // 
            // TxtOgrenciSoyIsim
            // 
            this.TxtOgrenciSoyIsim.Location = new System.Drawing.Point(83, 164);
            this.TxtOgrenciSoyIsim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtOgrenciSoyIsim.Name = "TxtOgrenciSoyIsim";
            this.TxtOgrenciSoyIsim.Size = new System.Drawing.Size(124, 28);
            this.TxtOgrenciSoyIsim.TabIndex = 2;
            // 
            // TxtLabNo
            // 
            this.TxtLabNo.Location = new System.Drawing.Point(794, 73);
            this.TxtLabNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLabNo.Name = "TxtLabNo";
            this.TxtLabNo.Size = new System.Drawing.Size(124, 28);
            this.TxtLabNo.TabIndex = 2;
            // 
            // TxtLabKat
            // 
            this.TxtLabKat.Location = new System.Drawing.Point(794, 141);
            this.TxtLabKat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLabKat.Name = "TxtLabKat";
            this.TxtLabKat.Size = new System.Drawing.Size(124, 28);
            this.TxtLabKat.TabIndex = 2;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(83, 246);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(94, 32);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnLabYarat
            // 
            this.BtnLabYarat.Location = new System.Drawing.Point(808, 234);
            this.BtnLabYarat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLabYarat.Name = "BtnLabYarat";
            this.BtnLabYarat.Size = new System.Drawing.Size(94, 32);
            this.BtnLabYarat.TabIndex = 3;
            this.BtnLabYarat.Text = "Lab Yarat";
            this.BtnLabYarat.UseVisualStyleBackColor = true;
            this.BtnLabYarat.Click += new System.EventHandler(this.BtnLabYarat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 760);
            this.Controls.Add(this.BtnLabYarat);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtLabKat);
            this.Controls.Add(this.TxtOgrenciSoyIsim);
            this.Controls.Add(this.TxtLabNo);
            this.Controls.Add(this.TxtOgrenciIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstSonuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciIsim;
        private System.Windows.Forms.TextBox TxtOgrenciSoyIsim;
        private System.Windows.Forms.TextBox TxtLabNo;
        private System.Windows.Forms.TextBox TxtLabKat;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnLabYarat;
    }
}