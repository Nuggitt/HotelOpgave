using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelOpgave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hotelOpgaveDB;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string query = $"INSERT into Facilitet values('{Facilitet_Id.Text.ToString()}','{Hotel_Id.Text.ToString()}','{Facilitet_Navn.Text}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }
        private void cleardata()
        {
            Facilitet_Id.Clear();
            Hotel_Id.Clear();
            Facilitet_Navn.Clear();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Facilitet SET Facilitet_Id = @NewFacilitetId, Hotel_Id = @NewHotelId, Facilitet_Navn = @NewFacilitetNavn WHERE Facilitet_Id = @CurrentFacilitetId AND Hotel_Id = @CurrentHotelId";
            cmd.CommandText = query;
            conn.Open();
            cmd.Parameters.AddWithValue("@NewFacilitetId", NewFacilitet_Id.Text);
            cmd.Parameters.AddWithValue("@NewHotelId", NewHotel_Id.Text);
            cmd.Parameters.AddWithValue("@NewFacilitetNavn", NewFacilitet_Navn.Text);
            cmd.Parameters.AddWithValue("@CurrentFacilitetId", Facilitet_Id.Text);
            cmd.Parameters.AddWithValue("@CurrentHotelId", Hotel_Id.Text);
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE Facilitet WHERE Facilitet_Id = " + Facilitet_Id.Text.ToString() + " AND Hotel_Id = " + Hotel_Id.Text.ToString();
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Facilitet";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM Facilitet WHERE Facilitet_Id ='{FindByFacilitet_Id.Text.ToString()}' AND Hotel_Id = '{FindByHotel_Id.Text.ToString()}'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Facilitet_Id.Text = dt.ToString();
            Hotel_Id.Text = dt.ToString();
            Facilitet_Navn.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void FindById_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM Facilitet WHERE Facilitet_Id ='{FindOnlyByFacilitet_Id.Text.ToString()}'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Facilitet_Id.Text = dt.ToString();
            Hotel_Id.Text = dt.ToString();
            Facilitet_Navn.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowAllTypes_Click(object sender, EventArgs e)
        {
            displaydata2();
        }

        private void displaydata2()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Facilitet_Type_Aktivitet";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string query = $"INSERT into Facilitet_Type_Aktivitet VALUES('{Facilitet_Navn2.Text.ToString()}','{Facilitet_Type.Text}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata2();
        }

        private void DeleteByName_Click(object sender, EventArgs e)
        {
            string query = $"DELETE Facilitet_Type_Aktivitet WHERE Facilitet_Navn LIKE'" + Facilitet_Navn2.Text.ToString() + "'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView2.DataSource = query;
            cleardata();
            conn.Close();
            displaydata2();
        }

        private void Update2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Facilitet_Type_Aktivitet SET Facilitet_Navn = @NewFacilitetNavn2, Facilitet_Type = @NewFacilitetType WHERE Facilitet_Navn LIKE @CurrentFacilitetNavn";
            cmd.CommandText = query;
            conn.Open();
            cmd.Parameters.AddWithValue("@CurrentFacilitetNavn", Facilitet_Navn2.Text);
            cmd.Parameters.AddWithValue("@NewFacilitetNavn2", NewFacilitet_Navn2.Text);
            cmd.Parameters.AddWithValue("@NewFacilitetType", NewFacilitet_Type2.Text);
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata2();
        }

        private void FindByFacilitet_Navn_Knap_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM Facilitet_Type_Aktivitet WHERE Facilitet_Navn ='{FindByFacilitet_Navn.Text.ToString()}'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FindByFacilitet_Navn.Text = dt.ToString();
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void FindByFacilitet_Type_Knap_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM Facilitet_Type_Aktivitet WHERE Facilitet_Type ='{FindByFacilitet_Type.Text.ToString()}'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FindByFacilitet_Type.Text = dt.ToString();
            dataGridView2.DataSource = dt;
            conn.Close();
        }
    }
    
}
