using System.Drawing;
using System.Windows.Forms;
namespace osoba
{

    partial class Form1
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
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_ime = new System.Windows.Forms.TextBox();
            this.t_prezime = new System.Windows.Forms.TextBox();
            this.t_adresa = new System.Windows.Forms.TextBox();
            this.t_jmbg = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.t_uloga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnprvi = new System.Windows.Forms.Button();
            this.btnpredhodni = new System.Windows.Forms.Button();
            this.btndodaj = new System.Windows.Forms.Button();
            this.btnizmeni = new System.Windows.Forms.Button();
            this.bntbrisi = new System.Windows.Forms.Button();
            this.btnsledeci = new System.Windows.Forms.Button();
            this.btnzadnji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_id
            // 
            this.t_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_id.ForeColor = System.Drawing.Color.Gray;
            this.t_id.Location = new System.Drawing.Point(540, 28);
            this.t_id.Multiline = true;
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(111, 37);
            this.t_id.TabIndex = 0;
            this.t_id.Text = "ID";
            // 
            // t_ime
            // 
            this.t_ime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_ime.ForeColor = System.Drawing.Color.Gray;
            this.t_ime.Location = new System.Drawing.Point(540, 71);
            this.t_ime.Multiline = true;
            this.t_ime.Name = "t_ime";
            this.t_ime.Size = new System.Drawing.Size(111, 37);
            this.t_ime.TabIndex = 1;
            this.t_ime.Text = "Ime";
            // 
            // t_prezime
            // 
            this.t_prezime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_prezime.ForeColor = System.Drawing.Color.Gray;
            this.t_prezime.Location = new System.Drawing.Point(540, 114);
            this.t_prezime.Multiline = true;
            this.t_prezime.Name = "t_prezime";
            this.t_prezime.Size = new System.Drawing.Size(111, 35);
            this.t_prezime.TabIndex = 2;
            this.t_prezime.Text = "Prezime";
            // 
            // t_adresa
            // 
            this.t_adresa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_adresa.ForeColor = System.Drawing.Color.Gray;
            this.t_adresa.Location = new System.Drawing.Point(540, 155);
            this.t_adresa.Multiline = true;
            this.t_adresa.Name = "t_adresa";
            this.t_adresa.Size = new System.Drawing.Size(111, 40);
            this.t_adresa.TabIndex = 3;
            this.t_adresa.Text = "Adresa";
            // 
            // t_jmbg
            // 
            this.t_jmbg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_jmbg.ForeColor = System.Drawing.Color.Gray;
            this.t_jmbg.Location = new System.Drawing.Point(540, 201);
            this.t_jmbg.Multiline = true;
            this.t_jmbg.Name = "t_jmbg";
            this.t_jmbg.Size = new System.Drawing.Size(111, 40);
            this.t_jmbg.TabIndex = 7;
            this.t_jmbg.Text = "JMBG";
            // 
            // t_email
            // 
            this.t_email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_email.ForeColor = System.Drawing.Color.Gray;
            this.t_email.Location = new System.Drawing.Point(540, 247);
            this.t_email.Multiline = true;
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(111, 39);
            this.t_email.TabIndex = 6;
            this.t_email.Text = "E-mail";
            // 
            // t_password
            // 
            this.t_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_password.ForeColor = System.Drawing.Color.Gray;
            this.t_password.Location = new System.Drawing.Point(540, 292);
            this.t_password.Multiline = true;
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(111, 34);
            this.t_password.TabIndex = 5;
            this.t_password.Text = "Password";
            // 
            // t_uloga
            // 
            this.t_uloga.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t_uloga.ForeColor = System.Drawing.Color.Gray;
            this.t_uloga.Location = new System.Drawing.Point(540, 332);
            this.t_uloga.Multiline = true;
            this.t_uloga.Name = "t_uloga";
            this.t_uloga.Size = new System.Drawing.Size(111, 33);
            this.t_uloga.TabIndex = 4;
            this.t_uloga.Text = "Uloga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ukucajte podatke u odgovarajuca polja:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnprvi
            // 
            this.btnprvi.Location = new System.Drawing.Point(353, 422);
            this.btnprvi.Name = "btnprvi";
            this.btnprvi.Size = new System.Drawing.Size(64, 20);
            this.btnprvi.TabIndex = 10;
            this.btnprvi.Text = "<<";
            this.btnprvi.UseVisualStyleBackColor = true;
            this.btnprvi.Click += new System.EventHandler(this.btnprvi_Click);
            // 
            // btnpredhodni
            // 
            this.btnpredhodni.Location = new System.Drawing.Point(423, 422);
            this.btnpredhodni.Name = "btnpredhodni";
            this.btnpredhodni.Size = new System.Drawing.Size(64, 20);
            this.btnpredhodni.TabIndex = 11;
            this.btnpredhodni.Text = "<";
            this.btnpredhodni.UseVisualStyleBackColor = true;
            this.btnpredhodni.Click += new System.EventHandler(this.btnpredhodni_Click);
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(493, 422);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(64, 20);
            this.btndodaj.TabIndex = 12;
            this.btndodaj.Text = "Dodaj";
            this.btndodaj.UseVisualStyleBackColor = true;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // btnizmeni
            // 
            this.btnizmeni.Location = new System.Drawing.Point(563, 422);
            this.btnizmeni.Name = "btnizmeni";
            this.btnizmeni.Size = new System.Drawing.Size(64, 20);
            this.btnizmeni.TabIndex = 13;
            this.btnizmeni.Text = "Izmeni";
            this.btnizmeni.UseVisualStyleBackColor = true;
            this.btnizmeni.Click += new System.EventHandler(this.btnizmeni_Click);
            // 
            // bntbrisi
            // 
            this.bntbrisi.Location = new System.Drawing.Point(633, 422);
            this.bntbrisi.Name = "bntbrisi";
            this.bntbrisi.Size = new System.Drawing.Size(64, 20);
            this.bntbrisi.TabIndex = 14;
            this.bntbrisi.Text = "Brisi";
            this.bntbrisi.UseVisualStyleBackColor = true;
            this.bntbrisi.Click += new System.EventHandler(this.bntbrisi_Click);
            // 
            // btnsledeci
            // 
            this.btnsledeci.Location = new System.Drawing.Point(703, 422);
            this.btnsledeci.Name = "btnsledeci";
            this.btnsledeci.Size = new System.Drawing.Size(64, 20);
            this.btnsledeci.TabIndex = 15;
            this.btnsledeci.Text = ">";
            this.btnsledeci.UseVisualStyleBackColor = true;
            this.btnsledeci.Click += new System.EventHandler(this.btnsledeci_Click);
            // 
            // btnzadnji
            // 
            this.btnzadnji.Location = new System.Drawing.Point(773, 422);
            this.btnzadnji.Name = "btnzadnji";
            this.btnzadnji.Size = new System.Drawing.Size(64, 20);
            this.btnzadnji.TabIndex = 16;
            this.btnzadnji.Text = ">>";
            this.btnzadnji.UseVisualStyleBackColor = true;
            this.btnzadnji.Click += new System.EventHandler(this.btnzadnji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1251, 611);
            this.Controls.Add(this.btnzadnji);
            this.Controls.Add(this.btnsledeci);
            this.Controls.Add(this.bntbrisi);
            this.Controls.Add(this.btnizmeni);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.btnpredhodni);
            this.Controls.Add(this.btnprvi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_jmbg);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_uloga);
            this.Controls.Add(this.t_adresa);
            this.Controls.Add(this.t_prezime);
            this.Controls.Add(this.t_ime);
            this.Controls.Add(this.t_id);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox t_id;
        private TextBox t_ime;
        private TextBox t_prezime;
        private TextBox t_adresa;
        private TextBox t_jmbg;
        private TextBox t_email;
        private TextBox t_password;
        private TextBox t_uloga;
        private Label label1;
        private Label label2;
        private Button btnprvi;
        private Button btnpredhodni;
        private Button btndodaj;
        private Button btnizmeni;
        private Button bntbrisi;
        private Button btnsledeci;
        private Button btnzadnji;
    }

}


