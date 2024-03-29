﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:MoneyRule
	/// </summary>
	public partial class MoneyRule
	{
		public MoneyRule()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(VipSoft.Model.MoneyRule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MoneyRule(");
			strSql.Append("ID,Name,OneHour,SecondHour,ThirdHour,ThanTime)");
			strSql.Append(" values (");
			strSql.Append("@ID,@Name,@OneHour,@SecondHour,@ThirdHour,@ThanTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@OneHour", SqlDbType.Money,8),
					new SqlParameter("@SecondHour", SqlDbType.Money,8),
					new SqlParameter("@ThirdHour", SqlDbType.Money,8),
					new SqlParameter("@ThanTime", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.OneHour;
			parameters[3].Value = model.SecondHour;
			parameters[4].Value = model.ThirdHour;
			parameters[5].Value = model.ThanTime;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(VipSoft.Model.MoneyRule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MoneyRule set ");
			strSql.Append("ID=@ID,");
			strSql.Append("Name=@Name,");
			strSql.Append("OneHour=@OneHour,");
			strSql.Append("SecondHour=@SecondHour,");
			strSql.Append("ThirdHour=@ThirdHour,");
			strSql.Append("ThanTime=@ThanTime");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@OneHour", SqlDbType.Money,8),
					new SqlParameter("@SecondHour", SqlDbType.Money,8),
					new SqlParameter("@ThirdHour", SqlDbType.Money,8),
					new SqlParameter("@ThanTime", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.OneHour;
			parameters[3].Value = model.SecondHour;
			parameters[4].Value = model.ThirdHour;
			parameters[5].Value = model.ThanTime;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MoneyRule ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public VipSoft.Model.MoneyRule GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Name,OneHour,SecondHour,ThirdHour,ThanTime from MoneyRule ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			VipSoft.Model.MoneyRule model=new VipSoft.Model.MoneyRule();
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
		public VipSoft.Model.MoneyRule DataRowToModel(DataRow row)
		{
			VipSoft.Model.MoneyRule model=new VipSoft.Model.MoneyRule();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["OneHour"]!=null && row["OneHour"].ToString()!="")
				{
					model.OneHour=decimal.Parse(row["OneHour"].ToString());
				}
				if(row["SecondHour"]!=null && row["SecondHour"].ToString()!="")
				{
					model.SecondHour=decimal.Parse(row["SecondHour"].ToString());
				}
				if(row["ThirdHour"]!=null && row["ThirdHour"].ToString()!="")
				{
					model.ThirdHour=decimal.Parse(row["ThirdHour"].ToString());
				}
				if(row["ThanTime"]!=null && row["ThanTime"].ToString()!="")
				{
					model.ThanTime=int.Parse(row["ThanTime"].ToString());
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
			strSql.Append("select ID,Name,OneHour,SecondHour,ThirdHour,ThanTime ");
			strSql.Append(" FROM MoneyRule ");
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
			strSql.Append(" ID,Name,OneHour,SecondHour,ThirdHour,ThanTime ");
			strSql.Append(" FROM MoneyRule ");
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
			strSql.Append("select count(1) FROM MoneyRule ");
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
			strSql.Append(")AS Row, T.*  from MoneyRule T ");
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
			parameters[0].Value = "MoneyRule";
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

