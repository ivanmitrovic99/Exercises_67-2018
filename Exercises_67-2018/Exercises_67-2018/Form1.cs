using Microsoft.Azure.Amqp.Framing;
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

namespace Exercises_67_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }

        
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ExerciseResults> rezultati = new List<ExerciseResults>();

            string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection SqlConnection = new SqlConnection(ConnectionString);

            SqlConnection.Open();


            SqlCommand Command = new SqlCommand();
            Command.Connection = SqlConnection;
            Command.CommandText = "Select * FROM ExerciseResults";
            SqlDataReader dr = Command.ExecuteReader();
            while (dr.Read())
            {
                ExerciseResults rezultat = new ExerciseResults();
                rezultat.Id = dr.GetInt32(0);
                rezultat.StundentName = dr.GetString(1);
                rezultat.IndexNumber = dr.GetString(2);
                rezultat.Points = dr.GetInt32(3);
                rezultati.Add(rezultat);
            }

            foreach (ExerciseResults r in rezultati)
            {
                listBox1.Items.Add(r.StundentName + "  | " +
r.IndexNumber + " |  " + r.Points);
            }
        }
    }
}
