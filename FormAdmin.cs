using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadatakDA.Entiteti;

namespace ZadatakDA
{
    public partial class FormAdmin : Form
    {
        String connectionString = @"Data Source=DESKTOP-OTQFA1S\SQLEXPRESS;Initial Catalog=ZAVRSNI;User ID=AARTI;Password=AARTI";

        List<Korisnici> profChk = new List<Korisnici>();

        public FormAdmin()
        {
            InitializeComponent();
        }

        public void fill_profChk()
        {
            dataGridViewAdmin.DataSource = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
