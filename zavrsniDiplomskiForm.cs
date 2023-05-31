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
using System.Data.SqlClient;

namespace ZadatakDA
{
    public partial class zavrsniDiplomskiForm : Form
    {
        String connectionString = @"Data Source=DESKTOP-OTQFA1S\SQLEXPRESS;Initial Catalog=ZAVRSNI;User ID=AARTI;Password=AARTI";


        public zavrsniDiplomskiForm()
        {
            InitializeComponent();
        }


        
        private bool IsValidInput()
        {
            //// Provjera polja za prijavu
            //if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            //{
            //    MessageBox.Show("Morate unijeti korisničko ime i lozinku.", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            // Provjera polja za registraciju
            if (string.IsNullOrWhiteSpace(textBoxImeReg.Text) || string.IsNullOrWhiteSpace(textBoxPrezimeReg.Text) ||
                string.IsNullOrWhiteSpace(textBoxUsernameReg.Text) || string.IsNullOrWhiteSpace(textBoxPasswordReg.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ContainsOnlyLetters(textBoxImeReg.Text) || !ContainsOnlyLetters(textBoxPrezimeReg.Text))
            {
                MessageBox.Show("Ime i prezime smiju sadržavati samo slova.", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Provjera duplikata u bazi podataka
            if (IsDuplicateUser(textBoxUsernameReg.Text, textBoxPasswordReg.Text))
            {
                MessageBox.Show("Korisničko ime i lozinka već postoje.", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ContainsOnlyLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        // Metoda za provjeru duplikata korisničkog imena i lozinke
        private bool IsDuplicateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Korisnici WHERE KorisnickoIme = @Username OR Lozinka = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void radioButtonProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProfesor.Checked)
            {
                groupBoxSmjer.Visible = false;
            }
            else
            {
                groupBoxSmjer.Visible = true;
            }

        }

        private bool RegisterUser()
        {
            string ime = textBoxImeReg.Text;
            string prezime = textBoxPrezimeReg.Text;
            string korisnickoIme = textBoxUsernameReg.Text;
            string lozinka = textBoxPasswordReg.Text;
            int uloga = radioButtonStudent.Checked ? 3 : 2;
            int tipStudija = radioButtonDiplomski.Checked ? 2 : 1;
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Korisnici (KorisnickoIme, Lozinka, Uloga, Potvrda) " +
                        "VALUES (@KorisnickoIme, @Lozinka, @Uloga, @Potvrda); SELECT SCOPE_IDENTITY()";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KorisnickoIme", korisnickoIme);
                    command.Parameters.AddWithValue("@Lozinka", lozinka);
                    command.Parameters.AddWithValue("@Uloga", uloga);
                    command.Parameters.AddWithValue("@Potvrda", uloga == 2 ? 1 : 0); // Student je automatski potvrđen

                    connection.Open();
                    int korisnikID = Convert.ToInt32(command.ExecuteScalar());

                    if (uloga == 2)
                    {
                        query = "INSERT INTO Profesori (Ime, Prezime) " +
                            "VALUES (@KorisnikID, @Ime, @Prezime)";
                    }
                    else if (uloga == 3)
                    {
                        query = "INSERT INTO Studenti (Ime, Prezime, TipStudija) " +
                            "VALUES (@KorisnikID, @Ime, @Prezime, @tipStudija)";
                    }
                    else
                    {
                        throw new Exception("Nepoznata uloga korisnika.");
                    }

                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KorisnikID", korisnikID);
                    command.Parameters.AddWithValue("@Ime", ime);
                    command.Parameters.AddWithValue("@Prezime", prezime);
                    command.Parameters.AddWithValue("@TipStudija", tipStudija);
                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom registracije korisnika. Molimo pokušajte ponovno." + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            if (IsValidInput())
            {
                // Izvrši registraciju
                bool success = RegisterUser();

                if (success)
                {
                    MessageBox.Show("Registracija uspješna!");
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Registracija nije uspjela. Pokušajte ponovno.");
                }
            }
        }

        private void ClearRegistrationFields()
        {
            textBoxImeReg.Text = "";
            textBoxPrezimeReg.Text = "";
            textBoxUsernameReg.Text = "";
            textBoxPasswordReg.Text = "";
            radioButtonStudent.Checked = true;
            radioButtonDiplomski.Checked = true;
        }
    }


}

