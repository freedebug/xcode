using System;
namespace VipSoft.Model
{
	/// <summary>
	/// Coupon:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Coupon
	{
		public Coupon()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _prefix;
		private string _startcouponnumber;
		private DateTime? _starttime;
		private DateTime? _endtime;
		private decimal? _money;
		private string _shopidinfo;
		private string _goodsclassinfo;
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
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Prefix
		{
			set{ _prefix=value;}
			get{return _prefix;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartCouponNumber
		{
			set{ _startcouponnumber=value;}
			get{return _startcouponnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
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
		public string ShopIDInfo
		{
			set{ _shopidinfo=value;}
			get{return _shopidinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsClassInfo
		{
			set{ _goodsclassinfo=value;}
			get{return _goodsclassinfo;}
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

