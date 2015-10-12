using System;
namespace VipSoft.Model
{
	/// <summary>
	/// XExtensionValue:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class XExtensionValue
	{
		public XExtensionValue()
		{}
		#region Model
		private int _id;
		private int? _parentid;
		private int? _recordid;
		private string _extvalue0;
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
		public int? ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RecordID
		{
			set{ _recordid=value;}
			get{return _recordid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExtValue0
		{
			set{ _extvalue0=value;}
			get{return _extvalue0;}
		}
		#endregion Model

	}
}

