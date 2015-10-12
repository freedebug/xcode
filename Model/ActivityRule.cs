using System;
namespace VipSoft.Model
{
	/// <summary>
	/// ActivityRule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ActivityRule
	{
		public ActivityRule()
		{}
		#region Model
		private int _id;
		private string _title;
		private int? _target;
		private int? _deadlinetype;
		private int? _deadline;
		private int? _type;
		private string _rule;
		private string _remark;
		private DateTime? _createdatetime;
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
		public int? Target
		{
			set{ _target=value;}
			get{return _target;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeadLineType
		{
			set{ _deadlinetype=value;}
			get{return _deadlinetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeadLine
		{
			set{ _deadline=value;}
			get{return _deadline;}
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
		public string Rule
		{
			set{ _rule=value;}
			get{return _rule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDateTime
		{
			set{ _createdatetime=value;}
			get{return _createdatetime;}
		}
		#endregion Model

	}
}

