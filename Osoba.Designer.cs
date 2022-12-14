
namespace EsDnevnik
{
    partial class Osoba
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUloga = new System.Windows.Forms.TextBox();
            this.btFirst = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btUpd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(260, 52);
            this.tbId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(148, 26);
            this.tbId.TabIndex = 0;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(260, 115);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(148, 26);
            this.tbIme.TabIndex = 1;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(260, 176);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(148, 26);
            this.tbPrezime.TabIndex = 2;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(260, 238);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(148, 26);
            this.tbAdresa.TabIndex = 3;
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(260, 300);
            this.tbJMBG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(148, 26);
            this.tbJMBG.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(260, 362);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(148, 26);
            this.tbEmail.TabIndex = 5;
            // 
            // tbUloga
            // 
            this.tbUloga.Location = new System.Drawing.Point(260, 415);
            this.tbUloga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUloga.Name = "tbUloga";
            this.tbUloga.Size = new System.Drawing.Size(148, 26);
            this.tbUloga.TabIndex = 6;
            // 
            // btFirst
            // 
            this.btFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFirst.Location = new System.Drawing.Point(77, 609);
            this.btFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(56, 56);
            this.btFirst.TabIndex = 7;
            this.btFirst.Text = "<<";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btPrev
            // 
            this.btPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrev.Location = new System.Drawing.Point(213, 609);
            this.btPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(56, 56);
            this.btPrev.TabIndex = 8;
            this.btPrev.Text = "<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(531, 609);
            this.btNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(56, 56);
            this.btNext.TabIndex = 9;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btLast
            // 
            this.btLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLast.Location = new System.Drawing.Point(674, 609);
            this.btLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(56, 56);
            this.btLast.TabIndex = 10;
            this.btLast.Text = ">>";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Prezime";
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(339, 548);
            this.btUpd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(112, 35);
            this.btUpd.TabIndex = 14;
            this.btUpd.Text = "Izmeni";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 497);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(694, 26);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(748, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 16;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(503, 548);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 35);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Brisi";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(185, 548);
            this.btnIns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(112, 35);
            this.btnIns.TabIndex = 18;
            this.btnIns.Text = "Dodaj";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "JMBG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "e-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 421);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Uloga";
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 834);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.tbUloga);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbJMBG);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbId);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Osoba";
            this.Text = "EsDnevnik";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUloga;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

