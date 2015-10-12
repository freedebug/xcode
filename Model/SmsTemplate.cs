using System;
namespace VipSoft.Model
{
	/// <summary>
	/// SmsTemplate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SmsTemplate
	{
		public SmsTemplate()
		{}
		#region Model
		private int _id;
		private string _templatename;
		private string _templatecontent;
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
		public string TemplateName
		{
			set{ _templatename=value;}
			get{return _templatename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TemplateContent
		{
			set{ _templatecontent=value;}
			get{return _templatecontent;}
		}
		#endregion Model

	}
}

