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
    public partial class Dodaj : Form
    {
        DataTable tabela;
        public Dodaj(DataTable t)
        {
            InitializeComponent();
            this.tabela = t;
        }
        private void btnIns_Click(object sender, EventArgs e)
        {
            
            string naredba = "INSERT INTO osoba VALUES('";
            // DODATI NAVODNIKE!!!
            naredba = naredba + tbIme.Text + "','";
            naredba = naredba + tbPrezime.Text + "','";
            naredba = naredba + tbAdresa.Text + "',";
            naredba = naredba + "NULL, NULL, NULL, 0)";
            // textBox1.Text = naredba;
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception graska) { MessageBox.Show(graska.GetType().ToString()); }
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            this.Close();
        }
    }
}
