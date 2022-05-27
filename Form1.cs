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

namespace WinFormsApp_SqlDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Server=NIHALAGAR;Database=NORTHWND;Trusted_Connection=True;";
        private void btnGetCategories_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            string query = "select * from Categories";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;

            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Desc", typeof(string));

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();//commandda okuma amacıyla yukarıdakısorguyu calıştır dıyoruz. Okuma yaptıkca don ıcın while dongusu kuruyoruz.

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                //row["CategoryId"] = (int)reader["CategoryId"];//okuma yontemı alttakı de farklı bır okuma yontemı
                row["Id"] = reader.GetInt32("CategoryId");
                row["Name"] = reader.GetString("CategoryName");
                row["Desc"] = reader.GetString("Description");
                table.Rows.Add(row);
            }
            //row yukarıda verilen kolon adlarına gore yazılmalı dbye gore değil ama readre dbye gore yazılmalı.


            connection.Close();

            command.Dispose();
            connection.Dispose();//bılgısayarın ramınden bağlantı nesnesı sılınır yok edılır.


            dataGridView1.DataSource = table;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into Categories (CategoryName,Description) VALUES (@CatagoryName,@Description)";
            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@CatagoryName", txtCategoryName.Text);
            command.Parameters.AddWithValue("@Description", txtCategoriDescription.Text);

            connection.Open();

            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result>0)
            {
                MessageBox.Show("Yeni kategori eklendi.");
                LoadCategories();
            }

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtCategoryId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                txtCategoryName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                txtCategoriDescription.Text = dataGridView1.CurrentRow.Cells["Desc"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }//secılen satır yoksa çık gıt.

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description where CategoryID=@CategoryID";
            SqlCommand command = new SqlCommand(query, connection);

            //command.Parameters.AddWithValue("@CatagoryId", int.Parse(txtCategoryId.Text));
            //command.Parameters.AddWithValue("@CatagoryId", (int)dataGridView1.CurrentRow.Cells["ID"].Value);
            int catId = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            command.Parameters.AddWithValue("@CategoryId", catId);//bunlar farklı kullanımlar
            command.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
            command.Parameters.AddWithValue("@Description", txtCategoriDescription.Text);

            connection.Open();

            int ruselt = command.ExecuteNonQuery();

            connection.Close();

            if (ruselt > 0)
            {
                MessageBox.Show("Kategori güncellendi");
                LoadCategories();
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }//secılen satır yoksa çık gıt.

            string catName= dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show($"{catName} isimli kategoriyi silmek istediğinize emin misiniz?","Silme İşlemi",MessageBoxButtons.YesNoCancel);

            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "DELETE FROM Categories where CategoryID=@CategoryID";
            SqlCommand command = new SqlCommand(query, connection);

            //command.Parameters.AddWithValue("@CatagoryId", int.Parse(txtCategoryId.Text));
            //command.Parameters.AddWithValue("@CatagoryId", (int)dataGridView1.CurrentRow.Cells["ID"].Value);
            int catId = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            command.Parameters.AddWithValue("@CategoryId", catId);//bunlar farklı kullanımlar

            connection.Open();

            int ruselt = command.ExecuteNonQuery();

            connection.Close();

            if (ruselt > 0)
            {
                MessageBox.Show("Kategori silindi");
                LoadCategories();
            }
        }
    }
}
