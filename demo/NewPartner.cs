using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
	public partial class NewPartner : Form
	{

		private Partners _currentPartner;

		public NewPartner(Partners partner)
		{
			InitializeComponent();
			_currentPartner = partner;

			// Загружаем данные партнера в элементы управления формы
			textBoxTypePartnerName.Text = partner.TypePartnerName;
			textBoxNamePartner.Text = partner.NamePartner;
			textBoxDirector.Text = partner.Director;
			textBoxPhonePartner.Text = partner.PhonePartner;
			numericUpDownRating.Value = partner.Rating;
		}

		// Конструктор по умолчанию оставляем для создания новых партнеров
		public NewPartner()
		{
			InitializeComponent();
		}
	}
}
