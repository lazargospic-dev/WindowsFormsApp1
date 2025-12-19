using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int broj_sloga = 0;
        DataTable tabela;

        private void Load_data()
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void Txt_Load()
        {
            if (tabela.Rows.Count == -1)
            {
                t_id.Text = "";
                t_id.Text = "";
                t_id.Text = "";
                t_id.Text = "";
                t_id.Text = "";
                t_id.Text = "";
                t_id.Text = "";
                t_id.Text = "";
            }
            else
            {
                t_id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                t_id.Text = tabela.Rows[broj_sloga]["ime"].ToString();
                t_id.Text = tabela.Rows[broj_sloga]["prezime"].ToString();
                t_id.Text = tabela.Rows[broj_sloga]["adresa"].ToString();
                t_id.Text = tabela.Rows[broj_sloga]["jmbg"].ToString();
                t_id.Text = tabela.Rows[broj_sloga]["email"].ToString();
                t_id.Text = tabela.Rows[broj_sloga]["pass"].ToString();
                t_id.Text = tabela.Rows[broj_sloga]["uloga"].ToString();

            }
            if (broj_sloga == 0)
            {
                btnprvi.Enabled = false;
                btnpredhodni.Enabled = false;

            }
            else
            {
                btnprvi.Enabled = true;
                btnpredhodni.Enabled = true;
            }
            if (broj_sloga == tabela.Rows.Count - 1)
            {
                btnzadnji.Enabled = false;
                btnsledeci.Enabled = false;
            }
            else
            {
                btnzadnji.Enabled = true;
                btnsledeci.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnprvi_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Load();
        }

        private void btnpredhodni_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Load();
        }

        private void btnsledeci_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Load();
        }

        private void btnzadnji_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO osoba (ime, prezime, jmbg, adresa, email, password, uloga) values('");
            Naredba.Append(t_ime.Text + "', '");
            Naredba.Append(t_prezime.Text + "', '");
            Naredba.Append(t_adresa.Text + "', '");
            Naredba.Append(t_jmbg.Text + "', '");
            Naredba.Append(t_email.Text + "', '");
            Naredba.Append(t_password.Text + "', '");
            Naredba.Append(t_uloga.Text + "', '");
            SqlConnection veza = konekcija.connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
        }

        private void btnizmeni_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE osoba SET");
            Naredba.Append("ime = '" + t_ime.Text + "', ");
            Naredba.Append("prezime = '" + t_prezime.Text + "', ");
            Naredba.Append("adresa = '" + t_adresa.Text + "', ");
            Naredba.Append("jmbg = '" + t_jmbg.Text + "', ");
            Naredba.Append("email = '" + t_email.Text + "', ");
            Naredba.Append("pass = '" + t_password.Text + "', ");
            Naredba.Append("uloga = '" + t_uloga.Text + "', ");
            Naredba.Append("WHERE id = '" + t_ime.Text + "', ");
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(Naredba.ToString(), veza);


        }

        private void bntbrisi_Click(object sender, EventArgs e)
        {
            string Naredba = "DELETE FROM osoba WHERE id= " + t_id.Text;
            SqlConnection veza = konekcija.connect(); ;
            SqlCommand komanda = new SqlCommand(Naredba, veza);
           Boolean brisano=false;
          
            if (brisano)
            {
                Load_data();
                if (broj_sloga > 0) broj_sloga--;
                Txt_Load();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
