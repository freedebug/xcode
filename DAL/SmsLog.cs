using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:SmsLog
	/// </summary>
	public partial class SmsLog
	{
		public SmsLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SmsLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SmsLog");
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
		public int Add(VipSoft.Model.SmsLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SmsLog(");
			strSql.Append("CardID,Name,Mobile,Content,SendTime,State,Number,ShopID,ShopName)");
			strSql.Append(" values (");
			strSql.Append("@CardID,@Name,@Mobile,@Content,@SendTime,@State,@Number,@ShopID,@ShopName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,20),
					new SqlParameter("@Mobile", SqlDbType.VarChar,20),
					new SqlParameter("@Content", SqlDbType.VarChar,255),
					new SqlParameter("@SendTime", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Mobile;
			parameters[3].Value = model.Content;
			parameters[4].Value = model.SendTime;
			parameters[5].Value = model.State;
			parameters[6].Value = model.Number;
			parameters[7].Value = model.ShopID;
			parameters[8].Value = model.ShopName;

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
		public bool Update(VipSoft.Model.SmsLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SmsLog set ");
			strSql.Append("CardID=@CardID,");
			strSql.Append("Name=@Name,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("Content=@Content,");
			strSql.Append("SendTime=@SendTime,");
			strSql.Append("State=@State,");
			strSql.Append("Number=@Number,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("ShopName=@ShopName");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,20),
					new SqlParameter("@Mobile", SqlDbType.VarChar,20),
					new SqlParameter("@Content", SqlDbType.VarChar,255),
					new SqlParameter("@SendTime", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Mobile;
			parameters[3].Value = model.Content;
			parameters[4].Value = model.SendTime;
			parameters[5].Value = model.State;
			parameters[6].Value = model.Number;
			parameters[7].Value = model.ShopID;
			parameters[8].Value = model.ShopName;
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
			strSql.Append("delete from SmsLog ");
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
			strSql.Append("delete from SmsLog ");
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
		public VipSoft.Model.SmsLog GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CardID,Name,Mobile,Content,SendTime,State,Number,ShopID,ShopName from SmsLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.SmsLog model=new VipSoft.Model.SmsLog();
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
		public VipSoft.Model.SmsLog DataRowToModel(DataRow row)
		{
			VipSoft.Model.SmsLog model=new VipSoft.Model.SmsLog();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["CardID"]!=null)
				{
					model.CardID=row["CardID"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["SendTime"]!=null && row["SendTime"].ToString()!="")
				{
					model.SendTime=DateTime.Parse(row["SendTime"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["Number"]!=null && row["Number"].ToString()!="")
				{
					model.Number=int.Parse(row["Number"].ToString());
				}
				if(row["ShopID"]!=null && row["ShopID"].ToString()!="")
				{
					model.ShopID=int.Parse(row["ShopID"].ToString());
				}
				if(row["ShopName"]!=null)
				{
					model.ShopName=row["ShopName"].ToString();
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
			strSql.Append("select ID,CardID,Name,Mobile,Content,SendTime,State,Number,ShopID,ShopName ");
			strSql.Append(" FROM SmsLog ");
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
			strSql.Append(" ID,CardID,Name,Mobile,Content,SendTime,State,Number,ShopID,ShopName ");
			strSql.Append(" FROM SmsLog ");
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
			strSql.Append("select count(1) FROM SmsLog ");
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
			strSql.Append(")AS Row, T.*  from SmsLog T ");
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
			parameters[0].Value = "SmsLog";
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

