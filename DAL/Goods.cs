using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:Goods
	/// </summary>
	public partial class Goods
	{
		public Goods()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Goods"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Goods");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(VipSoft.Model.Goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Goods(");
			strSql.Append("GoodsCode,Name,NameCode,Unit,Number,SaleNumber,ClassID,Price,BuyPrice,Point,MinPercent,GoodsType,PointType,CreateDateTime,ShopID,ShopName,Remark)");
			strSql.Append(" values (");
			strSql.Append("@GoodsCode,@Name,@NameCode,@Unit,@Number,@SaleNumber,@ClassID,@Price,@BuyPrice,@Point,@MinPercent,@GoodsType,@PointType,@CreateDateTime,@ShopID,@ShopName,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GoodsCode", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@NameCode", SqlDbType.VarChar,50),
					new SqlParameter("@Unit", SqlDbType.VarChar,20),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@SaleNumber", SqlDbType.Int,4),
					new SqlParameter("@ClassID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@BuyPrice", SqlDbType.Money,8),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@MinPercent", SqlDbType.Float,8),
					new SqlParameter("@GoodsType", SqlDbType.Bit,1),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000)};
			parameters[0].Value = model.GoodsCode;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.NameCode;
			parameters[3].Value = model.Unit;
			parameters[4].Value = model.Number;
			parameters[5].Value = model.SaleNumber;
			parameters[6].Value = model.ClassID;
			parameters[7].Value = model.Price;
			parameters[8].Value = model.BuyPrice;
			parameters[9].Value = model.Point;
			parameters[10].Value = model.MinPercent;
			parameters[11].Value = model.GoodsType;
			parameters[12].Value = model.PointType;
			parameters[13].Value = model.CreateDateTime;
			parameters[14].Value = model.ShopID;
			parameters[15].Value = model.ShopName;
			parameters[16].Value = model.Remark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(VipSoft.Model.Goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Goods set ");
			strSql.Append("GoodsCode=@GoodsCode,");
			strSql.Append("Name=@Name,");
			strSql.Append("NameCode=@NameCode,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("Number=@Number,");
			strSql.Append("SaleNumber=@SaleNumber,");
			strSql.Append("ClassID=@ClassID,");
			strSql.Append("Price=@Price,");
			strSql.Append("BuyPrice=@BuyPrice,");
			strSql.Append("Point=@Point,");
			strSql.Append("MinPercent=@MinPercent,");
			strSql.Append("GoodsType=@GoodsType,");
			strSql.Append("PointType=@PointType,");
			strSql.Append("CreateDateTime=@CreateDateTime,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("ShopName=@ShopName,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@GoodsCode", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@NameCode", SqlDbType.VarChar,50),
					new SqlParameter("@Unit", SqlDbType.VarChar,20),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@SaleNumber", SqlDbType.Int,4),
					new SqlParameter("@ClassID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@BuyPrice", SqlDbType.Money,8),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@MinPercent", SqlDbType.Float,8),
					new SqlParameter("@GoodsType", SqlDbType.Bit,1),
					new SqlParameter("@PointType", SqlDbType.Int,4),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.GoodsCode;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.NameCode;
			parameters[3].Value = model.Unit;
			parameters[4].Value = model.Number;
			parameters[5].Value = model.SaleNumber;
			parameters[6].Value = model.ClassID;
			parameters[7].Value = model.Price;
			parameters[8].Value = model.BuyPrice;
			parameters[9].Value = model.Point;
			parameters[10].Value = model.MinPercent;
			parameters[11].Value = model.GoodsType;
			parameters[12].Value = model.PointType;
			parameters[13].Value = model.CreateDateTime;
			parameters[14].Value = model.ShopID;
			parameters[15].Value = model.ShopName;
			parameters[16].Value = model.Remark;
			parameters[17].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Goods ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Goods ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public VipSoft.Model.Goods GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,GoodsCode,Name,NameCode,Unit,Number,SaleNumber,ClassID,Price,BuyPrice,Point,MinPercent,GoodsType,PointType,CreateDateTime,ShopID,ShopName,Remark from Goods ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.Goods model=new VipSoft.Model.Goods();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public VipSoft.Model.Goods DataRowToModel(DataRow row)
		{
			VipSoft.Model.Goods model=new VipSoft.Model.Goods();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["GoodsCode"]!=null)
				{
					model.GoodsCode=row["GoodsCode"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["NameCode"]!=null)
				{
					model.NameCode=row["NameCode"].ToString();
				}
				if(row["Unit"]!=null)
				{
					model.Unit=row["Unit"].ToString();
				}
				if(row["Number"]!=null && row["Number"].ToString()!="")
				{
					model.Number=int.Parse(row["Number"].ToString());
				}
				if(row["SaleNumber"]!=null && row["SaleNumber"].ToString()!="")
				{
					model.SaleNumber=int.Parse(row["SaleNumber"].ToString());
				}
				if(row["ClassID"]!=null && row["ClassID"].ToString()!="")
				{
					model.ClassID=int.Parse(row["ClassID"].ToString());
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["BuyPrice"]!=null && row["BuyPrice"].ToString()!="")
				{
					model.BuyPrice=decimal.Parse(row["BuyPrice"].ToString());
				}
				if(row["Point"]!=null && row["Point"].ToString()!="")
				{
					model.Point=int.Parse(row["Point"].ToString());
				}
				if(row["MinPercent"]!=null && row["MinPercent"].ToString()!="")
				{
					model.MinPercent=decimal.Parse(row["MinPercent"].ToString());
				}
				if(row["GoodsType"]!=null && row["GoodsType"].ToString()!="")
				{
					if((row["GoodsType"].ToString()=="1")||(row["GoodsType"].ToString().ToLower()=="true"))
					{
						model.GoodsType=true;
					}
					else
					{
						model.GoodsType=false;
					}
				}
				if(row["PointType"]!=null && row["PointType"].ToString()!="")
				{
					model.PointType=int.Parse(row["PointType"].ToString());
				}
				if(row["CreateDateTime"]!=null && row["CreateDateTime"].ToString()!="")
				{
					model.CreateDateTime=DateTime.Parse(row["CreateDateTime"].ToString());
				}
				if(row["ShopID"]!=null && row["ShopID"].ToString()!="")
				{
					model.ShopID=int.Parse(row["ShopID"].ToString());
				}
				if(row["ShopName"]!=null)
				{
					model.ShopName=row["ShopName"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,GoodsCode,Name,NameCode,Unit,Number,SaleNumber,ClassID,Price,BuyPrice,Point,MinPercent,GoodsType,PointType,CreateDateTime,ShopID,ShopName,Remark ");
			strSql.Append(" FROM Goods ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,GoodsCode,Name,NameCode,Unit,Number,SaleNumber,ClassID,Price,BuyPrice,Point,MinPercent,GoodsType,PointType,CreateDateTime,ShopID,ShopName,Remark ");
			strSql.Append(" FROM Goods ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Goods ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Goods T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Goods";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

