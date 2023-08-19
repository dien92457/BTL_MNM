using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_MNM
{
    public class database
    {
        string debugpath;
        string projectpath;
        string stringconnection;
        public database()
        {
            debugpath = Directory.GetCurrentDirectory(); // Đường dẫn đến file debug
            projectpath = Directory.GetParent(Directory.GetParent(debugpath).FullName).FullName;
            stringconnection = $"Data Source={Path.Combine(projectpath, "dataprovide.db")};Version=3;";

        }


        // private string css = string.Format(@"Data Source={0}\dataprovide.db;Version=3;", Application.StartupPath);
        public void ExecuteNonQuery(string query, object[] parameter = null)
        {
            SQLiteConnection connection = new SQLiteConnection(stringconnection);
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listpara)
                    {
                        if (s.Contains("@"))
                        {
                            string parameterName = s.Replace("@", "");
                            command.Parameters.AddWithValue(parameterName, parameter[i]);
                            i++;
                        }
                    }
                }

                command.ExecuteNonQuery();
                //MessageBox.Show("Thay đổi dữ liệu thành công!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(stringconnection);
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listpara)
                    {
                        if (s.Contains("@"))
                        {
                            string parameterName = s.Replace("@", "");
                            command.Parameters.AddWithValue(parameterName, parameter[i]);
                            i++;
                        }
                    }
                }

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;
            SQLiteConnection connection = new SQLiteConnection(stringconnection);
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listpara)
                    {
                        if (s.Contains("@"))
                        {
                            string parameterName = s.Replace("@", "");
                            command.Parameters.AddWithValue(parameterName, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable ExecuteQuerySearch(string query)
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(stringconnection);
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }

}
