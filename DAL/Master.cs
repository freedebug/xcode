﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:Master
	/// </summary>
	public partial class Master
	{
		public Master()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Master"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Master");
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
		public int Add(VipSoft.Model.Master model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Master(");
			strSql.Append("Account,Password,Name,Sex,TelPhone,IsSuper,Authority,ShopID,ShopName)");
			strSql.Append(" values (");
			strSql.Append("@Account,@Password,@Name,@Sex,@TelPhone,@IsSuper,@Authority,@ShopID,@ShopName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Account", SqlDbType.VarChar,20),
					new SqlParameter("@Password", SqlDbType.VarChar,20),
					new SqlParameter("@Name", SqlDbType.VarChar,20),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@TelPhone", SqlDbType.VarChar,20),
					new SqlParameter("@IsSuper", SqlDbType.Bit,1),
					new SqlParameter("@Authority", SqlDbType.VarChar,1000),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Account;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.TelPhone;
			parameters[5].Value = model.IsSuper;
			parameters[6].Value = model.Authority;
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
		public bool Update(VipSoft.Model.Master model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Master set ");
			strSql.Append("Account=@Account,");
			strSql.Append("Password=@Password,");
			strSql.Append("Name=@Name,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("TelPhone=@TelPhone,");
			strSql.Append("IsSuper=@IsSuper,");
			strSql.Append("Authority=@Authority,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("ShopName=@ShopName");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Account", SqlDbType.VarChar,20),
					new SqlParameter("@Password", SqlDbType.VarChar,20),
					new SqlParameter("@Name", SqlDbType.VarChar,20),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@TelPhone", SqlDbType.VarChar,20),
					new SqlParameter("@IsSuper", SqlDbType.Bit,1),
					new SqlParameter("@Authority", SqlDbType.VarChar,1000),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Account;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.TelPhone;
			parameters[5].Value = model.IsSuper;
			parameters[6].Value = model.Authority;
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
			strSql.Append("delete from Master ");
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
			strSql.Append("delete from Master ");
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
		public VipSoft.Model.Master GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Account,Password,Name,Sex,TelPhone,IsSuper,Authority,ShopID,ShopName from Master ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.Master model=new VipSoft.Model.Master();
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
		public VipSoft.Model.Master DataRowToModel(DataRow row)
		{
			VipSoft.Model.Master model=new VipSoft.Model.Master();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Account"]!=null)
				{
					model.Account=row["Account"].ToString();
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Sex"]!=null && row["Sex"].ToString()!="")
				{
					model.Sex=int.Parse(row["Sex"].ToString());
				}
				if(row["TelPhone"]!=null)
				{
					model.TelPhone=row["TelPhone"].ToString();
				}
				if(row["IsSuper"]!=null && row["IsSuper"].ToString()!="")
				{
					if((row["IsSuper"].ToString()=="1")||(row["IsSuper"].ToString().ToLower()=="true"))
					{
						model.IsSuper=true;
					}
					else
					{
						model.IsSuper=false;
					}
				}
				if(row["Authority"]!=null)
				{
					model.Authority=row["Authority"].ToString();
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
			strSql.Append("select ID,Account,Password,Name,Sex,TelPhone,IsSuper,Authority,ShopID,ShopName ");
			strSql.Append(" FROM Master ");
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
			strSql.Append(" ID,Account,Password,Name,Sex,TelPhone,IsSuper,Authority,ShopID,ShopName ");
			strSql.Append(" FROM Master ");
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
			strSql.Append("select count(1) FROM Master ");
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
			strSql.Append(")AS Row, T.*  from Master T ");
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
			parameters[0].Value = "Master";
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

