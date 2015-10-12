using System;
namespace VipSoft.Model
{
	/// <summary>
	/// CardType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CardType
	{
		public CardType()
		{}
		#region Model
		private int _id;
		private int? _type;
		private bool _isexpensegoods;
		private bool _isexpensepoint;
		private bool _ispointauto;
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
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsExpenseGoods
		{
			set{ _isexpensegoods=value;}
			get{return _isexpensegoods;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsExpensePoint
		{
			set{ _isexpensepoint=value;}
			get{return _isexpensepoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsPointAuto
		{
			set{ _ispointauto=value;}
			get{return _ispointauto;}
		}
		#endregion Model

	}
}

