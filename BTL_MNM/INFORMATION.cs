using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BTL_MNM
{
    public partial class INFORMATION : Form
    {
        String cs = @"URI=file:data_table.db";
        SQLiteConnection con;
        SQLiteCommand cmd;

        public INFORMATION()
        {
            InitializeComponent();
            
        }
       
        private void data_show()
        {
             /*con = new SQLiteConnection(cs);
             con.Open();

             String stm = "SELECT * FROM test";
             cmd = new SQLiteCommand(stm, con);
             SQLiteDataReader dr = cmd.ExecuteReader();
             while (dr.Read())
             {
                 dataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1));
             }
             con.Close(); */
            database dataprovide = new database();
            String stm = "SELECT * FROM NhanVien";
            dataprovide.ExecuteQuery(stm);
            dataGridView1.DataSource = dataprovide.ExecuteQuery(stm);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            /*con = new SQLiteConnection(cs);
            con.Open();
            cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO test(name, id) VALUES(@ten, @id)";

                String ten = txt_ten.Text;
                String id = txt_id.Text;

                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                dataGridView1.Rows.Add(ten, id);
                txt_ten.Clear();
                txt_id.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }*/
            String ten = txt_ten.Text;
            int id = Convert.ToInt32(txt_id.Text);
            int phanquyen = Convert.ToInt32(text_phan_quyen.Text);
            database dataprovde = new database();
            string query = "INSERT INTO NhanVien (ID, HoTen, PhanQuyen) VALUES ( @id , @ten , @phanquyen );";
            dataprovde.ExecuteNonQuery(query, new object[] {id, ten, phanquyen});
            this.data_show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(cs);
            con.Open();
            cmd = new SQLiteCommand(con);

            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string ten = dataGridView1.CurrentRow.Cells["ten"].Value.ToString();

                    cmd.CommandText = "DELETE FROM test WHERE name = @ten";
                    cmd.Parameters.AddWithValue("@ten", ten);

                    cmd.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(cs);
            con.Open();
            cmd = new SQLiteCommand(con);

            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string ten = dataGridView1.CurrentRow.Cells["ten"].Value.ToString();
                    string id = txt_id.Text;

                    cmd.CommandText = "UPDATE test SET id = @id WHERE name = @ten";
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    dataGridView1.CurrentRow.Cells["id"].Value = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật dữ liệu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txt_ten.Text = dataGridView1.CurrentRow.Cells["ten"].Value.ToString();
                txt_id.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
        }

        private void INFORMATION_Load(object sender, EventArgs e)
        {
            create_db();
            data_show();
        }

        private void create_db()
        {
            if (!System.IO.File.Exists("data_table.db"))
            {
                SQLiteConnection.CreateFile("data_table.db");
                using (SQLiteConnection sqlite = new SQLiteConnection("Data Source=data_table.db"))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20), id varchar(12))";
                    SQLiteCommand c = new SQLiteCommand(sql, sqlite);
                    c.ExecuteNonQuery();
                }
            }
        }
    }
}
