using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace spiel
{
    public partial class Form2 : Form
    {
        private int correctAnswer = -1;
        private int currentQuestionId = -1;
        private int scoreNumber = 0;
        private int numberOfQuestions = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.loadRandomQuestion();

        }

        private void antwort1_Click(object sender, EventArgs e)
        {


            if (this.correctAnswer == 1) {
                score.Text = (Int32.Parse(score.Text.ToString()) + 1).ToString();
            }
            this.loadRandomQuestion();


        }

        private void antwort2_Click_1(object sender, EventArgs e)
        {


            if (this.correctAnswer == 2)
            {
                score.Text = (Int32.Parse(score.Text.ToString()) + 1).ToString();
            }
            this.loadRandomQuestion();


        }

        private void antwort3_Click_1(object sender, EventArgs e)
        {


            if (this.correctAnswer == 3)
            {
                score.Text = (Int32.Parse(score.Text.ToString()) + 1).ToString();
            }
            this.loadRandomQuestion();


        }

        private void antwort4_Click_1(object sender, EventArgs e)
        {



            if (this.correctAnswer == 4)
            {
                score.Text = (Int32.Parse(score.Text.ToString()) + 1).ToString();
            }
            this.loadRandomQuestion();


        }

        private void loadRandomQuestion()
        {

            Random random = new Random();
            int minValue = 0;
            int maxValue = Options.numberOfQuestions;
            int rand = random.Next(minValue, maxValue);
            this.currentQuestionId = Options.id[rand];

            frage.Text = Options.frage[rand];

            MySql.Data.MySqlClient.MySqlConnection myConnection;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=spiel";
            try
            {
                myConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                //open a connection
                myConnection.Open();

                if (this.numberOfQuestions >= 10)
                {
                    MessageBox.Show("Game over your score is" + this.score.Text);
                    MySqlCommand ergebnisCommand = new MySqlCommand();
                    ergebnisCommand.Connection = myConnection;
                    ergebnisCommand.CommandText = @"
                                                INSERT INTO ergebnis (ergebnis, spieler_id) SELECT @ergebnis, id FROM spieler WHERE name = @name;";
                    ergebnisCommand.Parameters.AddWithValue("@ergebnis", Int32.Parse(this.score.Text));
                    ergebnisCommand.Parameters.AddWithValue("@name", Options.name);
                    var Reader = ergebnisCommand.ExecuteReader();
                    Reader.Close();

                }
                this.numberOfQuestions++; 

                MySqlCommand frageCommand = new MySqlCommand();
                frageCommand.Connection = myConnection;
                frageCommand.CommandText = @"
                                                SELECT a.antwort_text, richtige_antwort 
                                                FROM frage f
                                                JOIN antwort a ON a.frage_id = f.id
                                                WHERE f.id = @id;";
                frageCommand.Parameters.AddWithValue("@id", this.currentQuestionId);



                var myReader = frageCommand.ExecuteReader();
                int i = random.Next(1, 5);
                while (myReader.Read())
                {
                    if (i == 1)
                    {
                        antwort1.Text = myReader.GetString("antwort_text");
                    }
                    else if (i == 2)
                    {
                        antwort2.Text = myReader.GetString("antwort_text");

                    }
                    else if (i == 3)
                    {
                        antwort3.Text = myReader.GetString("antwort_text");

                    }
                    else if (i == 4)
                    {
                        antwort4.Text = myReader.GetString("antwort_text");

                    }
                    if (myReader.GetBoolean("richtige_antwort"))
                    {

                        this.correctAnswer = i;

                    }

                    i = i >= 4 ? 1 : i + 1;
                }



            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
