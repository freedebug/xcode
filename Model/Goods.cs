using System;
namespace VipSoft.Model
{
	/// <summary>
	/// Goods:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Goods
	{
		public Goods()
		{}
		#region Model
		private int _id;
		private string _goodscode;
		private string _name;
		private string _namecode;
		private string _unit;
		private int? _number;
		private int? _salenumber;
		private int? _classid;
		private decimal? _price;
		private decimal? _buyprice;
		private int? _point;
		private decimal? _minpercent;
		private bool _goodstype;
		private int? _pointtype;
		private DateTime? _createdatetime;
		private int? _shopid;
		private string _shopname;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsCode
		{
			set{ _goodscode=value;}
			get{return _goodscode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NameCode
		{
			set{ _namecode=value;}
			get{return _namecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SaleNumber
		{
			set{ _salenumber=value;}
			get{return _salenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ClassID
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BuyPrice
		{
			set{ _buyprice=value;}
			get{return _buyprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Point
		{
			set{ _point=value;}
			get{return _point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MinPercent
		{
			set{ _minpercent=value;}
			get{return _minpercent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool GoodsType
		{
			set{ _goodstype=value;}
			get{return _goodstype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointType
		{
			set{ _pointtype=value;}
			get{return _pointtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDateTime
		{
			set{ _createdatetime=value;}
			get{return _createdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ShopID
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

