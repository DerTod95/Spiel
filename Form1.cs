using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace KeksKlicker
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> Daten = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\Spiel\Bilder\Super sichere Passwörter.txt");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line != "")
                {
                    Daten.Add(line.Split(',')[0], line.Split(',')[1].Trim());
                }
            }
            sr.Close();
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            string Benutzername = txtBenutzername.Text;
            if (Daten.TryGetValue(Benutzername, out string Password))
            {
                if(Verschlüsselung.ToSha256(txtPasswort.Text) == Password)
                {
                    KeksKlickerForm keksKlickerForm = new KeksKlickerForm(Benutzername);
                    keksKlickerForm.Show();
                    Hide();
                }
                else
                {
                    IblFehler.Visible = true;
                }
            }
            else
            {
                IblFehler.Visible = true;
            }
        }

        private void btnRegestrieren_Click(object sender, EventArgs e)
        {
            string Benutzername = txtBenutzername.Text;
            if (Daten.TryGetValue(Benutzername, out string Password))
            {
                IblRegestriert.Visible = true;
            }
            else
            {
                MessageBox.Show("Erfolgreich regestriert!");
                StreamWriter sw = new StreamWriter(@"C:\Users\User\source\repos\Spiel\Bilder\Super sichere Passwörter.txt", true);

                string PasswordHash = Verschlüsselung.ToSha256(txtPasswort.Text);
                sw.WriteLine(Benutzername + ", " + PasswordHash);
                sw.Close();
                Daten.Add(Benutzername, Verschlüsselung.ToSha256(txtPasswort.Text));
                StreamWriter sd = new StreamWriter(@"C:\Users\User\source\repos\Spiel\Bilder\Spielerdaten.txt", true);

                sd.WriteLine(Benutzername + ", " + @"C:\Users\User\source\repos\Spiel\Bilder\" + Benutzername + ".txt");
                sd.Close();
            }
        }

        private void txtBenutzername_TextChanged(object sender, EventArgs e)
        {
            IblRegestriert.Visible = false;
            IblFehler.Visible = false;
        }

        private void txtPasswort_TextChanged(object sender, EventArgs e)
        {
            IblFehler.Visible = false;
        }
    }
}
