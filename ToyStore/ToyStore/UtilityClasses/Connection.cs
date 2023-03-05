using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace ToyStore.UtilityClasses
{
    public class Connection
    {

        SqlConnection connection = new SqlConnection(@"Data Source = WIN-QR717S0F3HA\SQLEXPRESS; Initial catalog=Project; Integrated Security=true;");
        SqlDataAdapter adapter;
        DataSet data = new DataSet();
        DataTable table = new DataTable();


        public Connection() { }

        public void SelectToGrid(string selectCom, DataGridView dataGridView)
        {
         
            adapter = new SqlDataAdapter(selectCom, connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            try
            {
                adapter.Fill(data);
                table = data.Tables[0];
                dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
    }
    }
}