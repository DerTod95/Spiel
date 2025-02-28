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

namespace KeksKlicker
{
    public partial class KeksKlickerForm : Form
    {
        string Benutzername;
        Random Random = new Random();
        private string[] SpielerDaten = new string[2];
        Dictionary<string, string> DasAndereDaten = new Dictionary<string, string>();
        int KekseProKlick = Convert.ToInt32(SpielerDaten[1]);
        int Kekse = Convert.ToInt32(SpielerDaten[0]);
        public KeksKlickerForm(string Benutzername)
        {
            InitializeComponent();
            this.Benutzername = Benutzername;
            lblBenutzername.Text = Benutzername;

            StreamReader stream = new StreamReader(@"C:\Users\User\source\repos\Spiel\Bilder\Spielerdaten.txt");
            while (!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                if (line != "")
                {
                    DasAndereDaten.Add(line.Split(',')[0], line.Split(',')[1].Trim());
                }
            }
            stream.Close();
            if (DasAndereDaten.TryGetValue(Benutzername, out string Pfad))
            {
                if (File.Exists(Pfad))
                {
                    StreamReader sr = new StreamReader(Pfad);
                    while (!stream.EndOfStream)
                    {
                        int i = 0;
                        string line = stream.ReadLine();
                        if (line != "")
                        {
                            SpielerDaten[i] = line;
                        }
                        i++;
                    }
                    sr.Close();
                }
                else
                {
                    File.CreateText(Pfad);
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StreamReader stream = new StreamReader(@"C:\Users\User\source\repos\Spiel\Bilder\Spielerdaten.txt");

            
        }

        private async void pcbKeks_Click_1(object sender, EventArgs e)
        {
            Label Plus = new Label();
            int pcbKeksX = pcbKeks.Location.X;
            int pcbKeksY = pcbKeks.Location.Y;
            int PositionX = Random.Next(pcbKeksX -100, pcbKeksX +150);
            int PositionY = Random.Next(pcbKeksY -150, pcbKeksY +100);
            Plus.Location = new Point(PositionX, PositionY);
            Plus.Text = "+" + Convert.ToString(KekseProKlick);
            Plus.BackColor = Color.Transparent;
            Plus.Font = new Font(Plus.Font, FontStyle.Bold);
            Plus.ForeColor = Color.SandyBrown;
            Plus.Font = new Font("Arial", 12);
            Controls.Add(Plus);

            Kekse += KekseProKlick;
            lblKekse.Text = "Kekse: " + Convert.ToString(Kekse);
            await Task.Delay(1200);
            Plus.Dispose();
        }

        private void libUpgrades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
