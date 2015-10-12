using System;
namespace VipSoft.Model
{
	/// <summary>
	/// CouponDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CouponDetail
	{
		public CouponDetail()
		{}
		#region Model
		private int _id;
		private int? _couponid;
		private string _couponnumber;
		private int? _state;
		private DateTime? _usedtime;
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
		public int? CouponID
		{
			set{ _couponid=value;}
			get{return _couponid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CouponNumber
		{
			set{ _couponnumber=value;}
			get{return _couponnumber;}
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
		public DateTime? UsedTime
		{
			set{ _usedtime=value;}
			get{return _usedtime;}
		}
		#endregion Model

	}
}

