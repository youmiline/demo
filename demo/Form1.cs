using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace demo
{
	public partial class FMain : Form
	{
		public FMain()
		{
			InitializeComponent();
		}

		DBMethods methods = new DBMethods();

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		List<Partners> partners = new List<Partners>();

		public void DoCard()
		{
			panel1.AutoScroll = true;
			partners.Clear();
			int sale = 0;
			int d = 20;
			partners = methods.GetPartners();
			panel1.Controls.Clear();
			foreach (Partners partner in partners)
			{
				GroupBox group1 = new GroupBox();
				group1.BackColor = Color.White;
				panel1.Controls.Add(group1);
				group1.Size = new Size(1100, 165);
				group1.Location = new Point(15, d);
				group1.Name = partner.PartnerId.ToString();

				sale = methods.GetSales(partner.PartnerId);


				d += group1.Height + 20;

				Label lbl1 = new Label();
				Label lblSale = new Label();
				lblSale.AutoSize = true;
				lblSale.Location = new Point(1000, 25);
				lblSale.Font = new Font("Segoe UI", 18);
				lblSale.Name = "lblSale";
				lblSale.Text = $"{sale}%";
				lbl1.AutoSize = true;
				lbl1.Location = new Point(30, 25);
				lbl1.Font = new Font("Segoe UI", 18);
				lbl1.Name = "lbl1";
				lbl1.Text = $"{partner.TypePartnerName} | {partner.NamePartner} \n" +
					$"{partner.Director} \n" +
					$"{partner.PhonePartner} \n" +
					$"Рейтинг: {partner.Rating}  ";

				group1.Controls.Add(lblSale);
				group1.Controls.Add(lbl1);

				group1.Click += new EventHandler(group1_Click);
			}

		}




		private void FMain_Load(object sender, EventArgs e)
		{
			DoCard();
		}

		public void group1_Click(object sender, EventArgs e)
		{

/*			// Получаем GroupBox, по которому кликнули
			var groupBox = (GroupBox)sender;
			// Извлекаем ID партнера из имени GroupBox'а
			int partnerId = int.Parse(groupBox.Name);
*/			
			int partnerId = int.Parse((sender as GroupBox).Name);

			// Найдем нужного партнера по ID
			/*			Partners selectedPartner = partners.FirstOrDefault(p => p.PartnerId == partnerId);*/

			Partners partners = methods.GetPartners(partnerId);

			if (partners != null)
			{
				// Создаем экземпляр формы NewPartner и передаем ей данные партнера
				NewPartner editPartner = new NewPartner(partners);
				editPartner.ShowDialog();
				DoCard();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			NewPartner newPartner = new NewPartner();
			newPartner.ShowDialog();
			DoCard();
		}
	}
}
