using System;
namespace VipSoft.Model
{
	/// <summary>
	/// MoneyRule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MoneyRule
	{
		public MoneyRule()
		{}
		#region Model
		private int? _id;
		private string _name;
		private decimal? _onehour;
		private decimal? _secondhour;
		private decimal? _thirdhour;
		private int? _thantime;
		/// <summary>
		/// 
		/// </summary>
		public int? ID
		{
			set{ _id=value;}
			get{return _id;}
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
		public decimal? OneHour
		{
			set{ _onehour=value;}
			get{return _onehour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SecondHour
		{
			set{ _secondhour=value;}
			get{return _secondhour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ThirdHour
		{
			set{ _thirdhour=value;}
			get{return _thirdhour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ThanTime
		{
			set{ _thantime=value;}
			get{return _thantime;}
		}
		#endregion Model

	}
}

