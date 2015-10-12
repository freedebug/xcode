using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace VipSoft.DAL
{
	/// <summary>
	/// 数据访问类:MemCard
	/// </summary>
	public partial class MemCard
	{
		public MemCard()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "MemCard"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MemCard");
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
		public int Add(VipSoft.Model.MemCard model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MemCard(");
			strSql.Append("CardID,CardMianID,Name,Sex,Password,Mobile,Photo,LevelID,IsPast,PastTime,Point,State,IsPointAuto,Money,TotalMoney,ShopID,ShopName,LastTime,Email,PayMoney,Remark,CardTypeID)");
			strSql.Append(" values (");
			strSql.Append("@CardID,@CardMianID,@Name,@Sex,@Password,@Mobile,@Photo,@LevelID,@IsPast,@PastTime,@Point,@State,@IsPointAuto,@Money,@TotalMoney,@ShopID,@ShopName,@LastTime,@Email,@PayMoney,@Remark,@CardTypeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@CardMianID", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@Password", SqlDbType.VarChar,20),
					new SqlParameter("@Mobile", SqlDbType.VarChar,20),
					new SqlParameter("@Photo", SqlDbType.VarChar,20),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@IsPast", SqlDbType.Bit,1),
					new SqlParameter("@PastTime", SqlDbType.DateTime),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsPointAuto", SqlDbType.Bit,1),
					new SqlParameter("@Money", SqlDbType.Money,8),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50),
					new SqlParameter("@LastTime", SqlDbType.DateTime),
					new SqlParameter("@Email", SqlDbType.VarChar,50),
					new SqlParameter("@PayMoney", SqlDbType.Money,8),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@CardTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.CardMianID;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.Password;
			parameters[5].Value = model.Mobile;
			parameters[6].Value = model.Photo;
			parameters[7].Value = model.LevelID;
			parameters[8].Value = model.IsPast;
			parameters[9].Value = model.PastTime;
			parameters[10].Value = model.Point;
			parameters[11].Value = model.State;
			parameters[12].Value = model.IsPointAuto;
			parameters[13].Value = model.Money;
			parameters[14].Value = model.TotalMoney;
			parameters[15].Value = model.ShopID;
			parameters[16].Value = model.ShopName;
			parameters[17].Value = model.LastTime;
			parameters[18].Value = model.Email;
			parameters[19].Value = model.PayMoney;
			parameters[20].Value = model.Remark;
			parameters[21].Value = model.CardTypeID;

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
		public bool Update(VipSoft.Model.MemCard model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MemCard set ");
			strSql.Append("CardID=@CardID,");
			strSql.Append("CardMianID=@CardMianID,");
			strSql.Append("Name=@Name,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Password=@Password,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("Photo=@Photo,");
			strSql.Append("LevelID=@LevelID,");
			strSql.Append("IsPast=@IsPast,");
			strSql.Append("PastTime=@PastTime,");
			strSql.Append("Point=@Point,");
			strSql.Append("State=@State,");
			strSql.Append("IsPointAuto=@IsPointAuto,");
			strSql.Append("Money=@Money,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("ShopName=@ShopName,");
			strSql.Append("LastTime=@LastTime,");
			strSql.Append("Email=@Email,");
			strSql.Append("PayMoney=@PayMoney,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("CardTypeID=@CardTypeID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@CardMianID", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@Password", SqlDbType.VarChar,20),
					new SqlParameter("@Mobile", SqlDbType.VarChar,20),
					new SqlParameter("@Photo", SqlDbType.VarChar,20),
					new SqlParameter("@LevelID", SqlDbType.Int,4),
					new SqlParameter("@IsPast", SqlDbType.Bit,1),
					new SqlParameter("@PastTime", SqlDbType.DateTime),
					new SqlParameter("@Point", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@IsPointAuto", SqlDbType.Bit,1),
					new SqlParameter("@Money", SqlDbType.Money,8),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@ShopName", SqlDbType.VarChar,50),
					new SqlParameter("@LastTime", SqlDbType.DateTime),
					new SqlParameter("@Email", SqlDbType.VarChar,50),
					new SqlParameter("@PayMoney", SqlDbType.Money,8),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@CardTypeID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.CardMianID;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.Password;
			parameters[5].Value = model.Mobile;
			parameters[6].Value = model.Photo;
			parameters[7].Value = model.LevelID;
			parameters[8].Value = model.IsPast;
			parameters[9].Value = model.PastTime;
			parameters[10].Value = model.Point;
			parameters[11].Value = model.State;
			parameters[12].Value = model.IsPointAuto;
			parameters[13].Value = model.Money;
			parameters[14].Value = model.TotalMoney;
			parameters[15].Value = model.ShopID;
			parameters[16].Value = model.ShopName;
			parameters[17].Value = model.LastTime;
			parameters[18].Value = model.Email;
			parameters[19].Value = model.PayMoney;
			parameters[20].Value = model.Remark;
			parameters[21].Value = model.CardTypeID;
			parameters[22].Value = model.ID;

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
			strSql.Append("delete from MemCard ");
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
			strSql.Append("delete from MemCard ");
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
		public VipSoft.Model.MemCard GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CardID,CardMianID,Name,Sex,Password,Mobile,Photo,LevelID,IsPast,PastTime,Point,State,IsPointAuto,Money,TotalMoney,ShopID,ShopName,LastTime,Email,PayMoney,Remark,CardTypeID from MemCard ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			VipSoft.Model.MemCard model=new VipSoft.Model.MemCard();
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
		public VipSoft.Model.MemCard DataRowToModel(DataRow row)
		{
			VipSoft.Model.MemCard model=new VipSoft.Model.MemCard();
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
				if(row["CardMianID"]!=null)
				{
					model.CardMianID=row["CardMianID"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Sex"]!=null && row["Sex"].ToString()!="")
				{
					model.Sex=int.Parse(row["Sex"].ToString());
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["Photo"]!=null)
				{
					model.Photo=row["Photo"].ToString();
				}
				if(row["LevelID"]!=null && row["LevelID"].ToString()!="")
				{
					model.LevelID=int.Parse(row["LevelID"].ToString());
				}
				if(row["IsPast"]!=null && row["IsPast"].ToString()!="")
				{
					if((row["IsPast"].ToString()=="1")||(row["IsPast"].ToString().ToLower()=="true"))
					{
						model.IsPast=true;
					}
					else
					{
						model.IsPast=false;
					}
				}
				if(row["PastTime"]!=null && row["PastTime"].ToString()!="")
				{
					model.PastTime=DateTime.Parse(row["PastTime"].ToString());
				}
				if(row["Point"]!=null && row["Point"].ToString()!="")
				{
					model.Point=int.Parse(row["Point"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["IsPointAuto"]!=null && row["IsPointAuto"].ToString()!="")
				{
					if((row["IsPointAuto"].ToString()=="1")||(row["IsPointAuto"].ToString().ToLower()=="true"))
					{
						model.IsPointAuto=true;
					}
					else
					{
						model.IsPointAuto=false;
					}
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
				}
				if(row["ShopID"]!=null && row["ShopID"].ToString()!="")
				{
					model.ShopID=int.Parse(row["ShopID"].ToString());
				}
				if(row["ShopName"]!=null)
				{
					model.ShopName=row["ShopName"].ToString();
				}
				if(row["LastTime"]!=null && row["LastTime"].ToString()!="")
				{
					model.LastTime=DateTime.Parse(row["LastTime"].ToString());
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["PayMoney"]!=null && row["PayMoney"].ToString()!="")
				{
					model.PayMoney=decimal.Parse(row["PayMoney"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["CardTypeID"]!=null && row["CardTypeID"].ToString()!="")
				{
					model.CardTypeID=int.Parse(row["CardTypeID"].ToString());
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
			strSql.Append("select ID,CardID,CardMianID,Name,Sex,Password,Mobile,Photo,LevelID,IsPast,PastTime,Point,State,IsPointAuto,Money,TotalMoney,ShopID,ShopName,LastTime,Email,PayMoney,Remark,CardTypeID ");
			strSql.Append(" FROM MemCard ");
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
			strSql.Append(" ID,CardID,CardMianID,Name,Sex,Password,Mobile,Photo,LevelID,IsPast,PastTime,Point,State,IsPointAuto,Money,TotalMoney,ShopID,ShopName,LastTime,Email,PayMoney,Remark,CardTypeID ");
			strSql.Append(" FROM MemCard ");
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
			strSql.Append("select count(1) FROM MemCard ");
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
			strSql.Append(")AS Row, T.*  from MemCard T ");
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
			parameters[0].Value = "MemCard";
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

