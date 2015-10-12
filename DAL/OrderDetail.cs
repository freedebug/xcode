using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:OrderDetail
	/// </summary>
	public partial class OrderDetail
	{
		public OrderDetail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "OrderDetail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OrderDetail");
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
		public int Add(VipSoft.Model.OrderDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OrderDetail(");
			strSql.Append("OrderCode,GoodsID,GoodsCode,GoodsName,Price,DiscountPrice,Number,Percent,IsService)");
			strSql.Append(" values (");
			strSql.Append("@OrderCode,@GoodsID,@GoodsCode,@GoodsName,@Price,@DiscountPrice,@Number,@Percent,@IsService)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderCode", SqlDbType.VarChar,50),
					new SqlParameter("@GoodsID", SqlDbType.Int,4),
					new SqlParameter("@GoodsCode", SqlDbType.VarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@DiscountPrice", SqlDbType.Money,8),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@Percent", SqlDbType.Float,8),
					new SqlParameter("@IsService", SqlDbType.Bit,1)};
			parameters[0].Value = model.OrderCode;
			parameters[1].Value = model.GoodsID;
			parameters[2].Value = model.GoodsCode;
			parameters[3].Value = model.GoodsName;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.DiscountPrice;
			parameters[6].Value = model.Number;
			parameters[7].Value = model.Percent;
			parameters[8].Value = model.IsService;

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
		public bool Update(VipSoft.Model.OrderDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OrderDetail set ");
			strSql.Append("OrderCode=@OrderCode,");
			strSql.Append("GoodsID=@GoodsID,");
			strSql.Append("GoodsCode=@GoodsCode,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("Price=@Price,");
			strSql.Append("DiscountPrice=@DiscountPrice,");
			strSql.Append("Number=@Number,");
			strSql.Append("Percent=@Percent,");
			strSql.Append("IsService=@IsService");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderCode", SqlDbType.VarChar,50),
					new SqlParameter("@GoodsID", SqlDbType.Int,4),
					new SqlParameter("@GoodsCode", SqlDbType.VarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@DiscountPrice", SqlDbType.Money,8),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@Percent", SqlDbType.Float,8),
					new SqlParameter("@IsService", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.OrderCode;
			parameters[1].Value = model.GoodsID;
			parameters[2].Value = model.GoodsCode;
			parameters[3].Value = model.GoodsName;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.DiscountPrice;
			parameters[6].Value = model.Number;
			parameters[7].Value = model.Percent;
			parameters[8].Value = model.IsService;
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
			strSql.Append("delete from OrderDetail ");
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
			strSql.Append("delete from OrderDetail ");
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
		public VipSoft.Model.OrderDetail GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OrderCode,GoodsID,GoodsCode,GoodsName,Price,DiscountPrice,Number,Percent,IsService from OrderDetail ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.OrderDetail model=new VipSoft.Model.OrderDetail();
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
		public VipSoft.Model.OrderDetail DataRowToModel(DataRow row)
		{
			VipSoft.Model.OrderDetail model=new VipSoft.Model.OrderDetail();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["OrderCode"]!=null)
				{
					model.OrderCode=row["OrderCode"].ToString();
				}
				if(row["GoodsID"]!=null && row["GoodsID"].ToString()!="")
				{
					model.GoodsID=int.Parse(row["GoodsID"].ToString());
				}
				if(row["GoodsCode"]!=null)
				{
					model.GoodsCode=row["GoodsCode"].ToString();
				}
				if(row["GoodsName"]!=null)
				{
					model.GoodsName=row["GoodsName"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["DiscountPrice"]!=null && row["DiscountPrice"].ToString()!="")
				{
					model.DiscountPrice=decimal.Parse(row["DiscountPrice"].ToString());
				}
				if(row["Number"]!=null && row["Number"].ToString()!="")
				{
					model.Number=int.Parse(row["Number"].ToString());
				}
				if(row["Percent"]!=null && row["Percent"].ToString()!="")
				{
					model.Percent=decimal.Parse(row["Percent"].ToString());
				}
				if(row["IsService"]!=null && row["IsService"].ToString()!="")
				{
					if((row["IsService"].ToString()=="1")||(row["IsService"].ToString().ToLower()=="true"))
					{
						model.IsService=true;
					}
					else
					{
						model.IsService=false;
					}
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
			strSql.Append("select ID,OrderCode,GoodsID,GoodsCode,GoodsName,Price,DiscountPrice,Number,Percent,IsService ");
			strSql.Append(" FROM OrderDetail ");
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
			strSql.Append(" ID,OrderCode,GoodsID,GoodsCode,GoodsName,Price,DiscountPrice,Number,Percent,IsService ");
			strSql.Append(" FROM OrderDetail ");
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
			strSql.Append("select count(1) FROM OrderDetail ");
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
			strSql.Append(")AS Row, T.*  from OrderDetail T ");
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
			parameters[0].Value = "OrderDetail";
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

