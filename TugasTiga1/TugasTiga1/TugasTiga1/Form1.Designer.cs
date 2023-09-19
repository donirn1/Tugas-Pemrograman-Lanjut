namespace TugasTiga1
{
    partial class form
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
            this.lblNIM = new System.Windows.Forms.Label();
            this.ket1 = new System.Windows.Forms.Button();
            this.ket2 = new System.Windows.Forms.Button();
            this.lblNAMA = new System.Windows.Forms.Label();
            this.lblKELAS = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.nim = new System.Windows.Forms.Label();
            this.kelas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIM.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNIM.Location = new System.Drawing.Point(111, 46);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(89, 20);
            this.lblNIM.TabIndex = 0;
            this.lblNIM.Text = "22.11.4806";
            this.lblNIM.Click += new System.EventHandler(this.label1_Click);
            // 
            // ket1
            // 
            this.ket1.Location = new System.Drawing.Point(77, 156);
            this.ket1.Name = "ket1";
            this.ket1.Size = new System.Drawing.Size(113, 36);
            this.ket1.TabIndex = 1;
            this.ket1.Text = "Tampilkan (●\'◡\'●)";
            this.ket1.UseVisualStyleBackColor = true;
            this.ket1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ket2
            // 
            this.ket2.Location = new System.Drawing.Point(231, 156);
            this.ket2.Name = "ket2";
            this.ket2.Size = new System.Drawing.Size(107, 34);
            this.ket2.TabIndex = 2;
            this.ket2.Text = "Kosongkan (¬_¬ )";
            this.ket2.UseVisualStyleBackColor = true;
            this.ket2.Click += new System.EventHandler(this.ket2_Click);
            // 
            // lblNAMA
            // 
            this.lblNAMA.AutoSize = true;
            this.lblNAMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAMA.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNAMA.Location = new System.Drawing.Point(112, 82);
            this.lblNAMA.Name = "lblNAMA";
            this.lblNAMA.Size = new System.Drawing.Size(274, 20);
            this.lblNAMA.TabIndex = 3;
            this.lblNAMA.Text = "Muhammad Doni Rijalutama Nugraha";
            // 
            // lblKELAS
            // 
            this.lblKELAS.AutoSize = true;
            this.lblKELAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKELAS.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblKELAS.Location = new System.Drawing.Point(114, 115);
            this.lblKELAS.Name = "lblKELAS";
            this.lblKELAS.Size = new System.Drawing.Size(111, 20);
            this.lblKELAS.TabIndex = 4;
            this.lblKELAS.Text = "Informatika 04";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(39, 82);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(67, 20);
            this.nama.TabIndex = 5;
            this.nama.Text = "NAMA  :";
            // 
            // nim
            // 
            this.nim.AutoSize = true;
            this.nim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nim.Location = new System.Drawing.Point(39, 46);
            this.nim.Name = "nim";
            this.nim.Size = new System.Drawing.Size(66, 20);
            this.nim.TabIndex = 6;
            this.nim.Text = "NIM      :";
            // 
            // kelas
            // 
            this.kelas.AutoSize = true;
            this.kelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas.Location = new System.Drawing.Point(39, 115);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(69, 20);
            this.kelas.TabIndex = 7;
            this.kelas.Text = "KELAS :";
            this.kelas.Click += new System.EventHandler(this.label4_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.nim);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.lblKELAS);
            this.Controls.Add(this.lblNAMA);
            this.Controls.Add(this.ket2);
            this.Controls.Add(this.ket1);
            this.Controls.Add(this.lblNIM);
            this.Name = "form";
            this.Text = "Identitas Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Button ket1;
        private System.Windows.Forms.Button ket2;
        private System.Windows.Forms.Label lblNAMA;
        private System.Windows.Forms.Label lblKELAS;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label nim;
        private System.Windows.Forms.Label kelas;
    }
}

