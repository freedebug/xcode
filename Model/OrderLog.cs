using System;
namespace VipSoft.Model
{
	/// <summary>
	/// OrderLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderLog
	{
		public OrderLog()
		{}
		#region Model
		private int _id;
		private string _ordercode;
		private int? _ordertype;
		private int? _memid;
		private string _cardid;
		private string _memname;
		private int? _totalnumber;
		private decimal? _totalmoney;
		private decimal? _discountmoney;
		private string _payinfo;
		private int? _point;
		private DateTime? _createdatetime;
		private int? _paytype;
		private int? _masterid;
		private string _mastername;
		private int? _shopid;
		private int? _shopname;
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
		public string OrderCode
		{
			set{ _ordercode=value;}
			get{return _ordercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderType
		{
			set{ _ordertype=value;}
			get{return _ordertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MemID
		{
			set{ _memid=value;}
			get{return _memid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemName
		{
			set{ _memname=value;}
			get{return _memname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TotalNumber
		{
			set{ _totalnumber=value;}
			get{return _totalnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DisCountMoney
		{
			set{ _discountmoney=value;}
			get{return _discountmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayInfo
		{
			set{ _payinfo=value;}
			get{return _payinfo;}
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
		public DateTime? CreateDateTime
		{
			set{ _createdatetime=value;}
			get{return _createdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MasterID
		{
			set{ _masterid=value;}
			get{return _masterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MasterName
		{
			set{ _mastername=value;}
			get{return _mastername;}
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
		public int? ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		#endregion Model

	}
}

