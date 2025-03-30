using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace demo
{
	internal class ClassAdo
	{
		string connectionString;
		public SqlCommand cmd;

		public ClassAdo()
		{
			connectionString = "Data Source=LAPTOP-NL88HAUL\\NITRO_SQL_SERVER;Initial Catalog=dbCompany;Integrated Security=True;" +
				"Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		}

		public DataSet GetDataSet(string sqlQuery)
		{
			SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
			DataSet ds = new DataSet();
			adapter.Fill(ds, "Table");
			return ds;
		}

		public SqlCommand StProcExec(string commandText)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = commandText;
			return cmd;
		}

		public void comboBoxBind(string sqlQuery, ComboBox CB, string listField, string keyField)
		{
			DataSet ds = GetDataSet(sqlQuery);
			CB.DataSource = ds.Tables[0];
			CB.DisplayMember = listField; // привязка поля для проверки в списке
			CB.ValueMember = keyField; // первичный ключ
			CB.SelectedValue = ds.Tables[0].Rows[0][keyField].ToString();
		}

	}
}
