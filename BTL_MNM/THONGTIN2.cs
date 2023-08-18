using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTL_MNM
{
    
    public partial class THONGTIN2 : Form
    {
        String css = @"URI=file:dataa_table.db";
        SQLiteConnection conn;
        SQLiteCommand cmdd;
        public THONGTIN2()
        {
            InitializeComponent();
        }
       
        private void data_show()
        {
            /*conn = new SQLiteConnection(css);
            conn.Open();

            String stm = "SELECT * FROM test";
            cmdd = new SQLiteCommand(stm, conn);
            SQLiteDataReader dr = cmdd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1));
            }
            conn.Close(); */
            database dataprovide = new database();
            String stm = "SELECT * FROM test";
            dataGridView1.DataSource = dataprovide.ExecuteQuery(stm);
        }
        private void create_db()
        {
            if (!System.IO.File.Exists("dataa_table.db"))
            {
                SQLiteConnection.CreateFile("dataa_table.db");
                using (SQLiteConnection sqlite = new SQLiteConnection("Data Source=dataa_table.db"))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20), id varchar(12))";
                    SQLiteCommand c = new SQLiteCommand(sql, sqlite);
                    c.ExecuteNonQuery();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txt_name.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                txt_ma.Text = dataGridView1.CurrentRow.Cells["ma"].Value.ToString();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(css);
            conn.Open();
            cmdd = new SQLiteCommand(conn);

            try
            {
                cmdd.CommandText = "INSERT INTO test(name, id) VALUES(@name, @ma)";

                String ten = txt_name.Text;
                String id = txt_ma.Text;

                cmdd.Parameters.AddWithValue("@name", ten);
                cmdd.Parameters.AddWithValue("@ma", id);

                cmdd.ExecuteNonQuery();

                dataGridView1.Rows.Add(ten, id);
                txt_name.Clear();
                txt_ma.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(css);
            conn.Open();
            cmdd = new SQLiteCommand(conn);

            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string ten = dataGridView1.CurrentRow.Cells["name"].Value.ToString();

                    cmdd.CommandText = "DELETE FROM test WHERE name = @name";
                    cmdd.Parameters.AddWithValue("@name", ten);

                    cmdd.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(css);
            conn.Open();
            cmdd = new SQLiteCommand(conn);

            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string ten = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                    string id = txt_ma.Text;

                    cmdd.CommandText = "UPDATE test SET id = @ma WHERE name = @name";
                    cmdd.Parameters.AddWithValue("@name", ten);
                    cmdd.Parameters.AddWithValue("@ma", id);

                    cmdd.ExecuteNonQuery();

                    dataGridView1.CurrentRow.Cells["ma"].Value = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void THONGTIN2_Load(object sender, EventArgs e)
        {
            create_db();
            data_show();
        }
    }
}
