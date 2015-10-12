using System;
namespace VipSoft.Model
{
	/// <summary>
	/// SysParameter:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SysParameter
	{
		public SysParameter()
		{}
		#region Model
		private int _id;
		private string _keyname;
		private string _title;
		private int? _type;
		private int? _maxlength;
		private string _grouptitle;
		private string _value;
		private string _description;
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
		public string KeyName
		{
			set{ _keyname=value;}
			get{return _keyname;}
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
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxLength
		{
			set{ _maxlength=value;}
			get{return _maxlength;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GroupTitle
		{
			set{ _grouptitle=value;}
			get{return _grouptitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Value
		{
			set{ _value=value;}
			get{return _value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

