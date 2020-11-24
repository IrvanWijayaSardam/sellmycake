using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DuaPutri
{
    class config
    {
        SqlConnection cnn;
        string strkoneksi = null;

        public SqlConnection buka()
        {
            try
            {
                //strkoneksi = "Data Source=45.77.223.216\\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=putrilego2;User ID=7_MEI19\\Administrator;Password=AminiVan12!";
                //strkoneksi = "Server = .\\SQLEXPRESS; Database = putrilego;Integrated Security = SSPI";
                strkoneksi = "Server = .\\SQLEXPRESS ; Database = putrilego ; Integrated Security = SSPI";
                //169.254.11.229
                cnn = new SqlConnection(strkoneksi);
                cnn.Open();
               //MessageBox.Show("Berhasil Terkoneksi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cnn;
        }

    }
}
