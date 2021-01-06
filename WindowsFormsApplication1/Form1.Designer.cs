namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKayitEt = new System.Windows.Forms.Button();
            this.txtAranacak = new System.Windows.Forms.TextBox();
            this.btnKayitAra = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKitapAdi.Location = new System.Drawing.Point(110, 10);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(166, 31);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKitapTuru.Location = new System.Drawing.Point(473, 10);
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(166, 31);
            this.txtKitapTuru.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Türü";
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYazarSoyadi.Location = new System.Drawing.Point(473, 46);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(166, 31);
            this.txtYazarSoyadi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yazar Soyadı";
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYazarAdi.Location = new System.Drawing.Point(110, 46);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(166, 31);
            this.txtYazarAdi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yazar Adı";
            // 
            // btnKayitEt
            // 
            this.btnKayitEt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKayitEt.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitEt.Location = new System.Drawing.Point(18, 85);
            this.btnKayitEt.Name = "btnKayitEt";
            this.btnKayitEt.Size = new System.Drawing.Size(621, 46);
            this.btnKayitEt.TabIndex = 8;
            this.btnKayitEt.Text = "KAYIT ET";
            this.btnKayitEt.UseVisualStyleBackColor = false;
            this.btnKayitEt.Click += new System.EventHandler(this.btnKayitEt_Click);
            // 
            // txtAranacak
            // 
            this.txtAranacak.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAranacak.Location = new System.Drawing.Point(18, 154);
            this.txtAranacak.Name = "txtAranacak";
            this.txtAranacak.Size = new System.Drawing.Size(294, 31);
            this.txtAranacak.TabIndex = 9;
            // 
            // btnKayitAra
            // 
            this.btnKayitAra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKayitAra.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitAra.Location = new System.Drawing.Point(318, 154);
            this.btnKayitAra.Name = "btnKayitAra";
            this.btnKayitAra.Size = new System.Drawing.Size(321, 30);
            this.btnKayitAra.TabIndex = 10;
            this.btnKayitAra.Text = "KAYIT ARA";
            this.btnKayitAra.UseVisualStyleBackColor = false;
            this.btnKayitAra.Click += new System.EventHandler(this.btnKayitAra_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 191);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kitap Adı \r\nKitap Türü \r\nYazar Adı \r\nYazar Soyadı ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(324, 193);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(258, 191);
            this.lblSonuc.TabIndex = 12;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirst.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(18, 415);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 34);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackward.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackward.Location = new System.Drawing.Point(136, 415);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(92, 34);
            this.btnBackward.TabIndex = 14;
            this.btnBackward.Text = "<<";
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.SystemColors.Control;
            this.btnForward.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(254, 415);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(92, 34);
            this.btnForward.TabIndex = 15;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.Control;
            this.btnLast.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(372, 415);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(92, 34);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(490, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 34);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 468);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKayitAra);
            this.Controls.Add(this.txtAranacak);
            this.Controls.Add(this.btnKayitEt);
            this.Controls.Add(this.txtYazarSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKitapTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKayitEt;
        private System.Windows.Forms.TextBox txtAranacak;
        private System.Windows.Forms.Button btnKayitAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnDelete;
    }
}

