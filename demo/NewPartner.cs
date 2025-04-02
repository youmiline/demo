using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
	public partial class NewPartner : Form
	{
		ClassAdo classAdo = new ClassAdo();
		DBMethods methods = new DBMethods();

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

            foreach (Control item in groupBox1.Controls)
            {
				item.Enabled = false;

            }

			button2.Visible = true;
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
			string email = txtEmail.Text;
			const string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
			string phone = txtPhonePartner.Text;
			/*const string phonePattern = @"^\+?[\d\.-]{11,}$";*/
			if (txtDirector.TextLength != 0)
			{
				if(txtNamePartner.TextLength != 0)
				{
					if (Regex.Match(email, pattern).Success && txtEmail.TextLength != 0) 
					{
						if(txtPhonePartner.TextLength != 0 /*&& Regex.Match(phone,phonePattern).Success*/)
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
						else
						{
							MessageBox.Show("Ошибка! Номер телефона - пустое");
						}
					}
					else
					{
						MessageBox.Show("Ошибка! Почта имеет некорректный формат или пустое");
					}
				}
				else
				{
					MessageBox.Show("Ошибка! Поле названия - пустое");
				}
			}
			else
			{
				MessageBox.Show("Ошибка! Поле ФИО - пустое");
			}
		}

		string sqlTypePart = "select * from Partners_type";

		private void NewPartner_Load(object sender, EventArgs e)
		{
			classAdo.comboBoxBind(sqlTypePart, cbTypePartnerName, "typePartnerName", "typePartnerId");
			DGV();
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

		public void AddPartner(Partners partner)
		{
			SqlCommand cmd = classAdo.StProcExec("addPartner");

			cmd.Parameters.AddWithValue("@namePartner", partner.NamePartner);
			cmd.Parameters.AddWithValue("@director", partner.Director);
			cmd.Parameters.AddWithValue("@email", partner.EmailPartner);
			cmd.Parameters.AddWithValue("@phone", txtNamePartner.Text);
			cmd.Parameters.AddWithValue("@address", txtNamePartner.Text);
			cmd.Parameters.AddWithValue("@inn", txtNamePartner.Text);
			cmd.Parameters.AddWithValue("@typePartrnerId", txtNamePartner.Text);
			cmd.Parameters.AddWithValue("@rating", txtNamePartner.Text);
			cmd.ExecuteNonQuery();
		}

		public void keyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '+' && e.KeyChar != '('
				&& e.KeyChar != ')' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Space && e.KeyChar != '#')
			{
				e.KeyChar = '\0';
			} 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			foreach (Control item in groupBox1.Controls)
			{
				item.Enabled = true;

			}
		}

		List<Purchase> purchaseList = new List<Purchase>();

		public void DGV()
		{
			purchaseList = methods.GetPurchases(currentPartner.PartnerId);
			dgvPurchase.DataSource = purchaseList;
		}
	}
}
