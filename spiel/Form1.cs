using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace spiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void land_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NordAmerika_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SudAmerika_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            start.Enabled = name.Text != "";
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection myConnection;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=spiel";
            try
            {
                myConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                //open a connection
                myConnection.Open();


                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = @"INSERT INTO spieler (name) VALUES(@name);";
                myCommand.Parameters.AddWithValue("@name", name.Text);

                // execute the command and read the results
                var reader = myCommand.ExecuteReader();
                reader.Close();
 
                Options.region = regionGroup.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked).Name;
                Options.typ = typGroup.Controls.OfType<RadioButton>()
                            .FirstOrDefault(n => n.Checked).Name;

                MySqlCommand frageCommand = new MySqlCommand();
                frageCommand.Connection = myConnection;


                if (Options.region == "welt")
                {
                    frageCommand.CommandText = @"SELECT id, frage_text FROM frage WHERE typ = @typ;";
                    frageCommand.Parameters.AddWithValue("@typ", Options.typ);
                } else
                {
                    frageCommand.CommandText = @"
                                                SELECT f.id, f.frage_text 
                                                FROM frage f
                                                JOIN kontinent k ON k.id = f.kontinent_id
                                                WHERE f.typ = @typ AND k.name = @region;";
                    frageCommand.Parameters.AddWithValue("@typ", Options.typ);
                    frageCommand.Parameters.AddWithValue("@region", Options.region);
                }
                var myReader = frageCommand.ExecuteReader();
                int i = 0;                
                while (myReader.Read())
                {
                    Options.id[i] = myReader.GetInt32("id");
                    Options.frage[i] = myReader.GetString("frage_text");
                    i++;
                }
                Options.numberOfQuestions = i;
                Options.name = name.Text;


                Form2 form2 = new Form2();
                form2.ShowDialog();
                myConnection.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
