using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTodoListApp
{
    public partial class Form1 : Form
    {
        List<string> songList = new List<string>();
        List<string> doneSongs = new List<string>();
        Random songIndex = new Random();
        MyMSSqlConnection mySqlConnection = MyMSSqlConnection.GetInstance();
        SqlConnection sqlConn;
        public Form1()
        {

            InitializeComponent();
            this.Controls.Add(panelSongName);
            this.Size = new Size(322, 290);
            btnStart.Location = new Point(110, 190);
            lblSongName.Visible = false;
            lblCorrect.Visible = false;
            lblTryAgain.Visible = false;
            lblArtist.Visible = false;
            tbArtistInput.Visible = false;
            panelSongName.Visible = false;
            panelSongName.Controls.Add(lblSongName);
            lblSongName.Dock = DockStyle.Fill;
        
        }
        private void randomSongGenerator(List<string> songList) 
        {
            // Check if all songs have been played
            if (doneSongs.Count >= songList.Count)
            {
                MessageBox.Show("All songs have been played.");
                
                return;
            }
            

            string songGenerated;
            do
            {
                songGenerated = songList[songIndex.Next(songList.Count)];
            }
            while (doneSongs.Contains(songGenerated));  // Keep generating until a new song is found

            doneSongs.Add(songGenerated);
            lblSongName.Text = songGenerated;
            tbArtistInput.Text = "";
        }

        private void lblSongName_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelSongName.Visible = true;

            sqlConn = mySqlConnection.GetConnection();
            string myQuery = @"SELECT song FROM production.albums";
            SqlCommand sqlComm = new SqlCommand(myQuery, sqlConn);
            SqlDataReader reader = sqlComm.ExecuteReader();
            while (reader.Read()) 
            {
                string songName = reader[0].ToString();
                songList.Add(songName);
            }

            randomSongGenerator(songList);
            this.Size = new Size(322, 444);
            btnStart.Visible = false;
            btnSubmit.Location = new Point(115, 320);
            lblSongName.Visible = true;
            lblDirection.Visible = false;
            lblArtist.Visible = true;
            tbArtistInput.Visible = true;

        }

        private void tbArtistInput_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if the user hasn't entered anything in the tbArtistInput
            if (string.IsNullOrWhiteSpace(tbArtistInput.Text))
            {
                MessageBox.Show("Please enter your guess.");
                return;
            }

            bool correctGuess = false;

            sqlConn.Close();
            sqlConn = mySqlConnection.GetConnection();
            string myQuery = $@"SELECT artistName FROM production.albums WHERE song = '{doneSongs[doneSongs.Count - 1]}'";
            SqlCommand sqlComm = new SqlCommand(myQuery, sqlConn);
            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.Read())
            {
                correctGuess = reader[0].ToString().Equals(tbArtistInput.Text, StringComparison.OrdinalIgnoreCase);

                if (correctGuess)
                {
                    lblCorrect.Visible = true;
                }
                else
                {
                    lblTryAgain.Visible = true;
                    tbArtistInput.Text = "";
                }
            }

            await Task.Delay(3000); // Delay for showing the correct/wrong message
            lblCorrect.Visible = false;
            lblTryAgain.Visible = false;

            // No need to use do-while
            if (correctGuess)
            {
                randomSongGenerator(songList); // Generate a new song if the guess was correct
            }
        }


        private void lblDirection_Click(object sender, EventArgs e)
        {

        }

      
    }
}
