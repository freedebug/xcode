﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:Gift
	/// </summary>
	public partial class Gift
	{
		public Gift()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Gift"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Gift");
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
		public int Add(VipSoft.Model.Gift model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Gift(");
			strSql.Append("GiftCode,Name,Photo,Point,Number,ExchangeNumber)");
			strSql.Append(" values (");
			strSql.Append("@GiftCode,@Name,@Photo,@Point,@Number,@ExchangeNumber)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GiftCode", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Photo", SqlDbType.VarChar,50),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@ExchangeNumber", SqlDbType.Int,4)};
			parameters[0].Value = model.GiftCode;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Photo;
			parameters[3].Value = model.Point;
			parameters[4].Value = model.Number;
			parameters[5].Value = model.ExchangeNumber;

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
		public bool Update(VipSoft.Model.Gift model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Gift set ");
			strSql.Append("GiftCode=@GiftCode,");
			strSql.Append("Name=@Name,");
			strSql.Append("Photo=@Photo,");
			strSql.Append("Point=@Point,");
			strSql.Append("Number=@Number,");
			strSql.Append("ExchangeNumber=@ExchangeNumber");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@GiftCode", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Photo", SqlDbType.VarChar,50),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@ExchangeNumber", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.GiftCode;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Photo;
			parameters[3].Value = model.Point;
			parameters[4].Value = model.Number;
			parameters[5].Value = model.ExchangeNumber;
			parameters[6].Value = model.ID;

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
			strSql.Append("delete from Gift ");
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
			strSql.Append("delete from Gift ");
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
		public VipSoft.Model.Gift GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,GiftCode,Name,Photo,Point,Number,ExchangeNumber from Gift ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.Gift model=new VipSoft.Model.Gift();
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
		public VipSoft.Model.Gift DataRowToModel(DataRow row)
		{
			VipSoft.Model.Gift model=new VipSoft.Model.Gift();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["GiftCode"]!=null)
				{
					model.GiftCode=row["GiftCode"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Photo"]!=null)
				{
					model.Photo=row["Photo"].ToString();
				}
				if(row["Point"]!=null && row["Point"].ToString()!="")
				{
					model.Point=int.Parse(row["Point"].ToString());
				}
				if(row["Number"]!=null && row["Number"].ToString()!="")
				{
					model.Number=int.Parse(row["Number"].ToString());
				}
				if(row["ExchangeNumber"]!=null && row["ExchangeNumber"].ToString()!="")
				{
					model.ExchangeNumber=int.Parse(row["ExchangeNumber"].ToString());
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
			strSql.Append("select ID,GiftCode,Name,Photo,Point,Number,ExchangeNumber ");
			strSql.Append(" FROM Gift ");
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
			strSql.Append(" ID,GiftCode,Name,Photo,Point,Number,ExchangeNumber ");
			strSql.Append(" FROM Gift ");
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
			strSql.Append("select count(1) FROM Gift ");
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
			strSql.Append(")AS Row, T.*  from Gift T ");
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
			parameters[0].Value = "Gift";
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

