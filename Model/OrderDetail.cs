using System;
namespace VipSoft.Model
{
	/// <summary>
	/// OrderDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderDetail
	{
		public OrderDetail()
		{}
		#region Model
		private int _id;
		private string _ordercode;
		private int? _goodsid;
		private string _goodscode;
		private string _goodsname;
		private decimal? _price;
		private decimal? _discountprice;
		private int? _number;
		private decimal? _percent;
		private bool _isservice;
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
		public string OrderCode
		{
			set{ _ordercode=value;}
			get{return _ordercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GoodsID
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsCode
		{
			set{ _goodscode=value;}
			get{return _goodscode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsName
		{
			set{ _goodsname=value;}
			get{return _goodsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DiscountPrice
		{
			set{ _discountprice=value;}
			get{return _discountprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
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
		public bool IsService
		{
			set{ _isservice=value;}
			get{return _isservice;}
		}
		#endregion Model

	}
}

