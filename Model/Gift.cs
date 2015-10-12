using System;
namespace VipSoft.Model
{
	/// <summary>
	/// Gift:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Gift
	{
		public Gift()
		{}
		#region Model
		private int _id;
		private string _giftcode;
		private string _name;
		private string _photo;
		private int? _point;
		private int? _number;
		private int? _exchangenumber;
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
		public string GiftCode
		{
			set{ _giftcode=value;}
			get{return _giftcode;}
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
		public string Photo
		{
			set{ _photo=value;}
			get{return _photo;}
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
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExchangeNumber
		{
			set{ _exchangenumber=value;}
			get{return _exchangenumber;}
		}
		#endregion Model

	}
}

