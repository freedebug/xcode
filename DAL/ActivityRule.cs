﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:ActivityRule
	/// </summary>
	public partial class ActivityRule
	{
		public ActivityRule()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ActivityRule"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ActivityRule");
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
		public int Add(VipSoft.Model.ActivityRule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ActivityRule(");
			strSql.Append("Title,Target,DeadLineType,DeadLine,Type,Rule,Remark,CreateDateTime)");
			strSql.Append(" values (");
			strSql.Append("@Title,@Target,@DeadLineType,@DeadLine,@Type,@Rule,@Remark,@CreateDateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.VarChar,255),
					new SqlParameter("@Target", SqlDbType.Int,4),
					new SqlParameter("@DeadLineType", SqlDbType.Int,4),
					new SqlParameter("@DeadLine", SqlDbType.Int,4),
					new SqlParameter("@Type", SqlDbType.Int,4),
					new SqlParameter("@Rule", SqlDbType.VarChar,255),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Target;
			parameters[2].Value = model.DeadLineType;
			parameters[3].Value = model.DeadLine;
			parameters[4].Value = model.Type;
			parameters[5].Value = model.Rule;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.CreateDateTime;

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
		public bool Update(VipSoft.Model.ActivityRule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ActivityRule set ");
			strSql.Append("Title=@Title,");
			strSql.Append("Target=@Target,");
			strSql.Append("DeadLineType=@DeadLineType,");
			strSql.Append("DeadLine=@DeadLine,");
			strSql.Append("Type=@Type,");
			strSql.Append("Rule=@Rule,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("CreateDateTime=@CreateDateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.VarChar,255),
					new SqlParameter("@Target", SqlDbType.Int,4),
					new SqlParameter("@DeadLineType", SqlDbType.Int,4),
					new SqlParameter("@DeadLine", SqlDbType.Int,4),
					new SqlParameter("@Type", SqlDbType.Int,4),
					new SqlParameter("@Rule", SqlDbType.VarChar,255),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Target;
			parameters[2].Value = model.DeadLineType;
			parameters[3].Value = model.DeadLine;
			parameters[4].Value = model.Type;
			parameters[5].Value = model.Rule;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.CreateDateTime;
			parameters[8].Value = model.ID;

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
			strSql.Append("delete from ActivityRule ");
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
			strSql.Append("delete from ActivityRule ");
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
		public VipSoft.Model.ActivityRule GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Title,Target,DeadLineType,DeadLine,Type,Rule,Remark,CreateDateTime from ActivityRule ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.ActivityRule model=new VipSoft.Model.ActivityRule();
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
		public VipSoft.Model.ActivityRule DataRowToModel(DataRow row)
		{
			VipSoft.Model.ActivityRule model=new VipSoft.Model.ActivityRule();
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
				if(row["Target"]!=null && row["Target"].ToString()!="")
				{
					model.Target=int.Parse(row["Target"].ToString());
				}
				if(row["DeadLineType"]!=null && row["DeadLineType"].ToString()!="")
				{
					model.DeadLineType=int.Parse(row["DeadLineType"].ToString());
				}
				if(row["DeadLine"]!=null && row["DeadLine"].ToString()!="")
				{
					model.DeadLine=int.Parse(row["DeadLine"].ToString());
				}
				if(row["Type"]!=null && row["Type"].ToString()!="")
				{
					model.Type=int.Parse(row["Type"].ToString());
				}
				if(row["Rule"]!=null)
				{
					model.Rule=row["Rule"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["CreateDateTime"]!=null && row["CreateDateTime"].ToString()!="")
				{
					model.CreateDateTime=DateTime.Parse(row["CreateDateTime"].ToString());
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
			strSql.Append("select ID,Title,Target,DeadLineType,DeadLine,Type,Rule,Remark,CreateDateTime ");
			strSql.Append(" FROM ActivityRule ");
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
			strSql.Append(" ID,Title,Target,DeadLineType,DeadLine,Type,Rule,Remark,CreateDateTime ");
			strSql.Append(" FROM ActivityRule ");
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
			strSql.Append("select count(1) FROM ActivityRule ");
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
			strSql.Append(")AS Row, T.*  from ActivityRule T ");
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
			parameters[0].Value = "ActivityRule";
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
