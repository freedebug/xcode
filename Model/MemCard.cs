using System;
namespace VipSoft.Model
{
	/// <summary>
	/// MemCard:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MemCard
	{
		public MemCard()
		{}
		#region Model
		private int _id;
		private string _cardid;
		private string _cardmianid;
		private string _name;
		private int? _sex;
		private string _password;
		private string _mobile;
		private string _photo;
		private int? _levelid;
		private bool _ispast;
		private DateTime? _pasttime;
		private int? _point;
		private int? _state;
		private bool _ispointauto;
		private decimal? _money;
		private decimal? _totalmoney;
		private int? _shopid;
		private string _shopname;
		private DateTime? _lasttime;
		private string _email;
		private decimal? _paymoney;
		private string _remark;
		private int? _cardtypeid;
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
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardMianID
		{
			set{ _cardmianid=value;}
			get{return _cardmianid;}
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
		public int? Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LevelID
		{
			set{ _levelid=value;}
			get{return _levelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsPast
		{
			set{ _ispast=value;}
			get{return _ispast;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PastTime
		{
			set{ _pasttime=value;}
			get{return _pasttime;}
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
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsPointAuto
		{
			set{ _ispointauto=value;}
			get{return _ispointauto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Money
		{
			set{ _money=value;}
			get{return _money;}
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
		public DateTime? LastTime
		{
			set{ _lasttime=value;}
			get{return _lasttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PayMoney
		{
			set{ _paymoney=value;}
			get{return _paymoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CardTypeID
		{
			set{ _cardtypeid=value;}
			get{return _cardtypeid;}
		}
		#endregion Model

	}
}

