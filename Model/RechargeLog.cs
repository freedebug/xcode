using System;
namespace VipSoft.Model
{
	/// <summary>
	/// RechargeLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RechargeLog
	{
		public RechargeLog()
		{}
		#region Model
		private int _id;
		private int? _memid;
		private string _cardid;
		private string _memname;
		private int? _type;
		private decimal? _money;
		private decimal? _givemoney;
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
		public string MemName
		{
			set{ _memname=value;}
			get{return _memname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
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
		public decimal? GiveMoney
		{
			set{ _givemoney=value;}
			get{return _givemoney;}
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

