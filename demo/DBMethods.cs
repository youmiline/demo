using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
	internal class DBMethods
	{
		ClassAdo classAdo = new ClassAdo();

		string sqlTypePartner = "select * from Partners_type";

		public List<TypePartner> GetTypePartners()
		{
			List<TypePartner> typePartners = new List<TypePartner>();
			DataSet ds = classAdo.GetDataSet(sqlTypePartner);
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				TypePartner typePartner = new TypePartner();
				typePartner.TypePartnerId = int.Parse(ds.Tables[0].Rows[i]["typePartnerId"].ToString());
				typePartner.TypePartnerName = ds.Tables[0].Rows[i]["typePartnerName"].ToString();
				typePartners.Add(typePartner);
			}
			return typePartners;
		}

		string sqlPartners = "select * from Partners, Partners_type where Partners_type.typePartnerId = Partners.typePartnerId";

		public List<Partners> GetPartners()
		{
			List<Partners> partners = new List<Partners>();
			DataSet ds = classAdo.GetDataSet(sqlPartners);
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				Partners partners1 = new Partners();
				partners1.PartnerId = int.Parse(ds.Tables[0].Rows[i]["partnersId"].ToString());
				partners1.NamePartner = ds.Tables[0].Rows[i]["NamePartner"].ToString();
				partners1.Director = ds.Tables[0].Rows[i]["director"].ToString();
				partners1.EmailPartner = ds.Tables[0].Rows[i]["emailPartner"].ToString();
				partners1.PhonePartner = ds.Tables[0].Rows[i]["phonePartner"].ToString();
				partners1.AddressPartner = ds.Tables[0].Rows[i]["addressPartner"].ToString();
				partners1.TypePartnerName = ds.Tables[0].Rows[i]["typePartnerName"].ToString();
				partners1.Inn = ds.Tables[0].Rows[i]["inn"].ToString();
				partners1.Rating = int.Parse(ds.Tables[0].Rows[i]["rating"].ToString());
				partners1.TypePartnerId = int.Parse(ds.Tables[0].Rows[i]["typePartnerId"].ToString());
				partners.Add(partners1);
			}
			return partners;
		}


		public int GetSales(int partnersId)
		{

			string sqlCheckExists = $"SELECT COUNT(*) FROM Purchase WHERE partnersId = {partnersId}";
			DataSet dsCheck = classAdo.GetDataSet(sqlCheckExists);
			int recordCount = Convert.ToInt32(dsCheck.Tables[0].Rows[0][0]);

			if (recordCount == 0)
			{
				return 0;
			}


			string sqlSale = $"select sum(countProd) as sumCount from Purchase where partnersId = {partnersId}";
			int sale = 0;
			DataSet ds = classAdo.GetDataSet(sqlSale);
			int sumCount = int.Parse(ds.Tables[0].Rows[0]["sumCount"].ToString());
			if (ds.Tables[0].Rows[0]["sumCount"] != null)
			{
				if (sumCount < 10000)
				{
					sale = 0;
				}
				if (sumCount >= 10000 && sumCount < 50000)
				{
					sale = 5;
				}
				if (sumCount >= 50000 && sumCount < 300000)
				{
					sale = 10;
				}
				if (sumCount >= 300000)
				{
					sale = 15;
				}
			}
			else
			{
				sale = 0;
			}
			return sale;
		}

		public Partners GetPartners(int partnersId)
		{
			string sqlP = $"select * from Partners, Partners_type where Partners_type.typePartnerId = Partners.typePartnerId and Partners.partnersId = {partnersId}";
			DataSet ds = classAdo.GetDataSet(sqlP);
			Partners partners = new Partners();
			partners.PartnerId = int.Parse(ds.Tables[0].Rows[0]["partnersId"].ToString());
			partners.NamePartner = ds.Tables[0].Rows[0]["NamePartner"].ToString();
			partners.Director = ds.Tables[0].Rows[0]["director"].ToString();
			partners.EmailPartner = ds.Tables[0].Rows[0]["emailPartner"].ToString();
			partners.PhonePartner = ds.Tables[0].Rows[0]["phonePartner"].ToString();
			partners.AddressPartner = ds.Tables[0].Rows[0]["addressPartner"].ToString();
			partners.TypePartnerName = ds.Tables[0].Rows[0]["typePartnerName"].ToString();
			partners.Inn = ds.Tables[0].Rows[0]["inn"].ToString();
			partners.Rating = int.Parse(ds.Tables[0].Rows[0]["rating"].ToString());
			partners.TypePartnerId = int.Parse(ds.Tables[0].Rows[0]["typePartnerId"].ToString());
			return partners;
		}

		public List<Purchase> GetPurchases(int partnerId)
		{
			List<Purchase> purchases = new List<Purchase>();
			string sqlPurchase = $"select * from Purchase where partnersId = {partnerId} ";
			DataSet ds = classAdo.GetDataSet(sqlPurchase);
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				Purchase purchase = new Purchase();
				purchase.ProductId = int.Parse(ds.Tables[0].Rows[0]["productId"].ToString());
				purchase.PartnersId = int.Parse(ds.Tables[0].Rows[0]["partnersId"].ToString());
				purchase.CountProd = int.Parse(ds.Tables[0].Rows[0]["countProd"].ToString());
				purchase.DatePurchare = DateTime.Parse(ds.Tables[0].Rows[0]["datePurchase"].ToString());
				purchase.PurchaseId = int.Parse(ds.Tables[0].Rows[0]["purchaseId"].ToString());
				purchases.Add(purchase);
			}
				return purchases;
		}
	}
}
