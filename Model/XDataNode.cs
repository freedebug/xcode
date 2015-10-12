using System;
namespace VipSoft.Model
{
	/// <summary>
	/// XDataNode:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class XDataNode
	{
		public XDataNode()
		{}
		#region Model
		private int _id;
		private int? _parentid;
		private int? _nodetype;
		private string _name;
		private int? _fieldposition;
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
		public int? NodeType
		{
			set{ _nodetype=value;}
			get{return _nodetype;}
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
		public int? FieldPosition
		{
			set{ _fieldposition=value;}
			get{return _fieldposition;}
		}
		#endregion Model

	}
}

