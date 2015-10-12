using System;
namespace VipSoft.Model
{
	/// <summary>
	/// ExchangeLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExchangeLog
	{
		public ExchangeLog()
		{}
		#region Model
		private int _id;
		private int? _memid;
		private string _cardid;
		private string _name;
		private int? _giftid;
		private string _giftcode;
		private string _giftname;
		private int? _number;
		private int? _point;
		private int? _masterid;
		private string _mastername;
		private int? _shopid;
		private string _shopname;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GiftID
		{
			set{ _giftid=value;}
			get{return _giftid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GiftCode
		{
			set{ _giftcode=value;}
			get{return _giftcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GiftName
		{
			set{ _giftname=value;}
			get{return _giftname;}
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
		public int? Point
		{
			set{ _point=value;}
			get{return _point;}
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
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		#endregion Model

	}
}

