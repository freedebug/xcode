using System;
namespace VipSoft.Model
{
	/// <summary>
	/// SysLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SysLog
	{
		public SysLog()
		{}
		#region Model
		private int _id;
		private string _masteraccount;
		private string _mastername;
		private string _area;
		private string _detail;
		private DateTime? _createdatetime;
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
		public string MasterAccount
		{
			set{ _masteraccount=value;}
			get{return _masteraccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MasterName
		{
			set{ _mastername=value;}
			get{return _mastername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Detail
		{
			set{ _detail=value;}
			get{return _detail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDateTime
		{
			set{ _createdatetime=value;}
			get{return _createdatetime;}
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

