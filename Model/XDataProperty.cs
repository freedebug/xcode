using System;
namespace VipSoft.Model
{
	/// <summary>
	/// XDataProperty:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class XDataProperty
	{
		public XDataProperty()
		{}
		#region Model
		private int _id;
		private int? _datanodeid;
		private int? _propertytype;
		private string _propertyvalue;
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
		public int? DataNodeID
		{
			set{ _datanodeid=value;}
			get{return _datanodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PropertyType
		{
			set{ _propertytype=value;}
			get{return _propertytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PropertyValue
		{
			set{ _propertyvalue=value;}
			get{return _propertyvalue;}
		}
		#endregion Model

	}
}

