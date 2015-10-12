using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:Coupon
	/// </summary>
	public partial class Coupon
	{
		public Coupon()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Coupon"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Coupon");
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
		public int Add(VipSoft.Model.Coupon model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Coupon(");
			strSql.Append("Title,Prefix,StartCouponNumber,StartTime,EndTime,Money,ShopIDInfo,GoodsClassInfo,Remark)");
			strSql.Append(" values (");
			strSql.Append("@Title,@Prefix,@StartCouponNumber,@StartTime,@EndTime,@Money,@ShopIDInfo,@GoodsClassInfo,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.VarChar,50),
					new SqlParameter("@Prefix", SqlDbType.VarChar,20),
					new SqlParameter("@StartCouponNumber", SqlDbType.VarChar,20),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@Money", SqlDbType.Money,8),
					new SqlParameter("@ShopIDInfo", SqlDbType.VarChar,255),
					new SqlParameter("@GoodsClassInfo", SqlDbType.VarChar,255),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Prefix;
			parameters[2].Value = model.StartCouponNumber;
			parameters[3].Value = model.StartTime;
			parameters[4].Value = model.EndTime;
			parameters[5].Value = model.Money;
			parameters[6].Value = model.ShopIDInfo;
			parameters[7].Value = model.GoodsClassInfo;
			parameters[8].Value = model.Remark;

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
		public bool Update(VipSoft.Model.Coupon model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Coupon set ");
			strSql.Append("Title=@Title,");
			strSql.Append("Prefix=@Prefix,");
			strSql.Append("StartCouponNumber=@StartCouponNumber,");
			strSql.Append("StartTime=@StartTime,");
			strSql.Append("EndTime=@EndTime,");
			strSql.Append("Money=@Money,");
			strSql.Append("ShopIDInfo=@ShopIDInfo,");
			strSql.Append("GoodsClassInfo=@GoodsClassInfo,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.VarChar,50),
					new SqlParameter("@Prefix", SqlDbType.VarChar,20),
					new SqlParameter("@StartCouponNumber", SqlDbType.VarChar,20),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@Money", SqlDbType.Money,8),
					new SqlParameter("@ShopIDInfo", SqlDbType.VarChar,255),
					new SqlParameter("@GoodsClassInfo", SqlDbType.VarChar,255),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Prefix;
			parameters[2].Value = model.StartCouponNumber;
			parameters[3].Value = model.StartTime;
			parameters[4].Value = model.EndTime;
			parameters[5].Value = model.Money;
			parameters[6].Value = model.ShopIDInfo;
			parameters[7].Value = model.GoodsClassInfo;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.ID;

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
			strSql.Append("delete from Coupon ");
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
			strSql.Append("delete from Coupon ");
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
		public VipSoft.Model.Coupon GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Title,Prefix,StartCouponNumber,StartTime,EndTime,Money,ShopIDInfo,GoodsClassInfo,Remark from Coupon ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.Coupon model=new VipSoft.Model.Coupon();
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
		public VipSoft.Model.Coupon DataRowToModel(DataRow row)
		{
			VipSoft.Model.Coupon model=new VipSoft.Model.Coupon();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Prefix"]!=null)
				{
					model.Prefix=row["Prefix"].ToString();
				}
				if(row["StartCouponNumber"]!=null)
				{
					model.StartCouponNumber=row["StartCouponNumber"].ToString();
				}
				if(row["StartTime"]!=null && row["StartTime"].ToString()!="")
				{
					model.StartTime=DateTime.Parse(row["StartTime"].ToString());
				}
				if(row["EndTime"]!=null && row["EndTime"].ToString()!="")
				{
					model.EndTime=DateTime.Parse(row["EndTime"].ToString());
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["ShopIDInfo"]!=null)
				{
					model.ShopIDInfo=row["ShopIDInfo"].ToString();
				}
				if(row["GoodsClassInfo"]!=null)
				{
					model.GoodsClassInfo=row["GoodsClassInfo"].ToString();
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
			strSql.Append("select ID,Title,Prefix,StartCouponNumber,StartTime,EndTime,Money,ShopIDInfo,GoodsClassInfo,Remark ");
			strSql.Append(" FROM Coupon ");
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
			strSql.Append(" ID,Title,Prefix,StartCouponNumber,StartTime,EndTime,Money,ShopIDInfo,GoodsClassInfo,Remark ");
			strSql.Append(" FROM Coupon ");
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
			strSql.Append("select count(1) FROM Coupon ");
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
			strSql.Append(")AS Row, T.*  from Coupon T ");
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
			parameters[0].Value = "Coupon";
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

