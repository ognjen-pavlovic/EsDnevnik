using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EsDnevnik
{
    public partial class Osoba : Form
    {
        public int broj_sloga = 0;
        public DataTable tabela;
        public Osoba()
        {
            InitializeComponent();
        }
        public void TxtPopulate()
        {
            if (tabela.Rows.Count == 0)
            {
                tbId.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbAdresa.Text = "";
                tbJMBG.Text = "";
                tbEmail.Text = "";
                tbUloga.Text = "";
            }
            else
            {
                tbId.Text = tabela.Rows[broj_sloga][0].ToString();
                tbIme.Text = tabela.Rows[broj_sloga][1].ToString();
                tbPrezime.Text = tabela.Rows[broj_sloga][2].ToString();
                tbAdresa.Text = tabela.Rows[broj_sloga][3].ToString();
                tbJMBG.Text = tabela.Rows[broj_sloga][4].ToString();
                tbEmail.Text = tabela.Rows[broj_sloga][5].ToString();
                tbUloga.Text = tabela.Rows[broj_sloga][7].ToString();
                if (tbUloga.Text == "1")
                    tbUloga.Text = "Ucenik";
                else
                    tbUloga.Text = "Profesor";
                if (broj_sloga == tabela.Rows.Count - 1)
                {
                    btNext.Enabled = false;
                    btLast.Enabled = false;
                }
                else
                {
                    btNext.Enabled = true;
                    btLast.Enabled = true;
                }
                if (broj_sloga == 0)
                {
                    btPrev.Enabled = false;
                    btFirst.Enabled = false;
                }
                else
                {
                    btPrev.Enabled = true;
                    btFirst.Enabled = true;
                }

            }
        }
        private void Osoba_Load(object sender, EventArgs e)
        {
            tabela = new DataTable();
            // ovo izbacujemo uskoro...
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            da.Fill(tabela);
            TxtPopulate();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            TxtPopulate();
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            TxtPopulate();
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            TxtPopulate();
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            TxtPopulate();
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE osoba SET ";
            naredba = naredba + "ime = '" + tbIme.Text + "', ";
            naredba = naredba + "prezime='" + tbPrezime.Text + "', ";
            naredba = naredba + "adresa='" + tbAdresa.Text + "' ";
            naredba = naredba + "WHERE id=" + tbId.Text;
            // textBox1.Text = naredba;
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch(Exception graska) { MessageBox.Show(graska.GetType().ToString()); }
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable(); // MORA!!!
            da.Fill(tabela);
            TxtPopulate();
            label4.Text = "Podatak uspesno izmenjen";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM osoba WHERE id=" + tbId.Text;
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            if (broj_sloga == tabela.Rows.Count - 1) broj_sloga--;
            if (broj_sloga < 0) broj_sloga = 0;
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable(); // MORA!!!
            da.Fill(tabela);
            TxtPopulate();
            label4.Text = "Podatak uspesno izmenjen";
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            Dodaj nova = new Dodaj(tabela);
            nova.Show();
            label4.Text = "Podatak uspesno dodat";
        }
    }
}
