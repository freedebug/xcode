using System;
namespace VipSoft.Model
{
	/// <summary>
	/// CardLevel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CardLevel
	{
		public CardLevel()
		{}
		#region Model
		private int _id;
		private string _levelname;
		private int? _needpoint;
		private int? _point;
		private decimal? _percent;
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
		public string LevelName
		{
			set{ _levelname=value;}
			get{return _levelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NeedPoint
		{
			set{ _needpoint=value;}
			get{return _needpoint;}
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
		public decimal? Percent
		{
			set{ _percent=value;}
			get{return _percent;}
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

