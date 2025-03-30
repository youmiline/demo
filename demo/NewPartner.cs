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

namespace demo
{
	public partial class NewPartner : Form
	{
		ClassAdo classAdo = new ClassAdo();
		private Partners currentPartner;
		public NewPartner(Partners partner)
		{
			InitializeComponent();
			currentPartner = partner;

			cbTypePartnerName.Text = partner.TypePartnerName;
			txtNamePartner.Text = partner.NamePartner;
			txtDirector.Text = partner.Director;
			txtPhonePartner.Text = partner.PhonePartner;
			numRating.Value = partner.Rating;
			txtEmail.Text = partner.EmailPartner;
			txtInn.Text = partner.Inn;
			txtAddress.Text = partner.AddressPartner;
		}

		public NewPartner()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddPartner_Click(object sender, EventArgs e)
		{
			classAdo.StProcExec("addPartner");
			SqlCommand cmd = classAdo.StProcExec("addPartner");
			cmd.Parameters.Add("@namePartner", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@director", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@email", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@phone", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@address", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@inn", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@typePartrnerId", SqlDbType.Int);
			cmd.Parameters.Add("@rating", SqlDbType.Int);

			cmd.Parameters["@namePartner"].Value = txtNamePartner.Text;
			cmd.Parameters["@director"].Value = txtDirector.Text;
			cmd.Parameters["@email"].Value = txtEmail.Text;
			cmd.Parameters["@phone"].Value = txtPhonePartner.Text;
			cmd.Parameters["@address"].Value = txtAddress.Text;
			cmd.Parameters["@inn"].Value = txtInn.Text;
			cmd.Parameters["@typePartrnerId"].Value = cbTypePartnerName.SelectedValue;
			cmd.Parameters["@rating"].Value = numRating.Value;

			cmd.ExecuteNonQuery();
			MessageBox.Show("Запись добавлена");
			this.Close();
		}

		string sqlTypePart = "select * from Partners_type";

		private void NewPartner_Load(object sender, EventArgs e)
		{
			classAdo.comboBoxBind(sqlTypePart, cbTypePartnerName, "typePartnerName", "typePartnerId");
		}

		private void btnSavePartner_Click(object sender, EventArgs e)
		{
			string p = currentPartner.PartnerId.ToString();
			classAdo.StProcExec("updPartner");
			SqlCommand cmd = classAdo.StProcExec("updPartner");
			cmd.Parameters.Add("@namePartner", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@director", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@email", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@phone", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@address", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@inn", SqlDbType.VarChar, 150);
			cmd.Parameters.Add("@typePartrnerId", SqlDbType.Int);
			cmd.Parameters.Add("@rating", SqlDbType.Int);
			cmd.Parameters.Add("@partnerId", SqlDbType.Int);

			cmd.Parameters["@namePartner"].Value = txtNamePartner.Text;
			cmd.Parameters["@director"].Value = txtDirector.Text;
			cmd.Parameters["@email"].Value = txtEmail.Text;
			cmd.Parameters["@phone"].Value = txtPhonePartner.Text;
			cmd.Parameters["@address"].Value = txtAddress.Text;
			cmd.Parameters["@inn"].Value = txtInn.Text;
			cmd.Parameters["@typePartrnerId"].Value = cbTypePartnerName.SelectedValue;
			cmd.Parameters["@rating"].Value = numRating.Value;
			cmd.Parameters["@partnerId"].Value = p;

			cmd.ExecuteNonQuery();
			MessageBox.Show("Запись изменена");
			this.Close();
		}
	}
}
