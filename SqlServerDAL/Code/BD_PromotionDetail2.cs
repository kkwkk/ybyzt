﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2016 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2016/3/24 13:56:46
//
// 功能描述: 
//
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
using System.Collections;
using System.Collections.Generic;

namespace Hi.SQLServerDAL
{
    /// <summary>
    /// 数据访问类 BD_PromotionDetail2
    /// </summary>
    public partial class BD_PromotionDetail2
    {
        public BD_PromotionDetail2()
        { }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.BD_PromotionDetail2 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [BD_PromotionDetail2](");
            strSql.Append("[ProID],[CompID],[OrderPrice],[Discount],[modifyuser],[CreateUserID])");
            strSql.Append(" values (");
            strSql.Append("@ProID,@CompID,@OrderPrice,@Discount,@modifyuser,@CreateUserID)");
            strSql.Append(";select @@Identity");
            SqlParameter[] parameters = {
                    new SqlParameter("@ProID", SqlDbType.Int),
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@OrderPrice", SqlDbType.Decimal),
                    new SqlParameter("@Discount", SqlDbType.Decimal),
                    new SqlParameter("@modifyuser", SqlDbType.Int),
                    new SqlParameter("@CreateUserID", SqlDbType.Int)
            };
            parameters[0].Value = model.ProID;
            parameters[1].Value = model.CompID;
            parameters[2].Value = model.OrderPrice;
            parameters[3].Value = model.Discount;
            parameters[4].Value = model.modifyuser;
            parameters[5].Value = model.CreateUserID;
            return SqlHelper.GetInt(SqlHelper.GetSingle(SqlHelper.LocalSqlServer, strSql.ToString(), parameters));
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hi.Model.BD_PromotionDetail2 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [BD_PromotionDetail2] set ");
            strSql.Append("[ProID]=@ProID,");
            strSql.Append("[CompID]=@CompID,");
            strSql.Append("[OrderPrice]=@OrderPrice,");
            strSql.Append("[Discount]=@Discount,");
            strSql.Append("[dr]=@dr,");
            strSql.Append("[modifyuser]=@modifyuser,");
            strSql.Append("[CreateDate]=@CreateDate,");
            strSql.Append("[CreateUserID]=@CreateUserID,");
            strSql.Append("[ts]=@ts");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@ProID", SqlDbType.Int),
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@OrderPrice", SqlDbType.Decimal),
                    new SqlParameter("@Discount", SqlDbType.Decimal),
                    new SqlParameter("@dr", SqlDbType.SmallInt),
                    new SqlParameter("@modifyuser", SqlDbType.Int),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@CreateUserID", SqlDbType.Int),
                    new SqlParameter("@ts", SqlDbType.DateTime)
            };
            parameters[0].Value = model.ID;
            parameters[1].Value = model.ProID;
            parameters[2].Value = model.CompID;
            parameters[3].Value = model.OrderPrice;
            parameters[4].Value = model.Discount;
            parameters[5].Value = model.dr;
            parameters[6].Value = model.modifyuser;
            parameters[7].Value = model.CreateDate;
            parameters[8].Value = model.CreateUserID;
            parameters[9].Value = model.ts;

            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete [BD_PromotionDetail2] ");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;

            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return SqlHelper.GetMaxID(SqlHelper.LocalSqlServer, "[ID]", "[BD_PromotionDetail2]");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [BD_PromotionDetail2]");
            strSql.Append(" where [ID]= @ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;
            return SqlHelper.Exists(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hi.Model.BD_PromotionDetail2 GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [BD_PromotionDetail2] ");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;
            DataSet ds = SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow r = ds.Tables[0].Rows[0];
                return GetModel(r);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取数据集,建议只在多表联查时使用
        /// </summary>
        public DataSet GetDataSet(string strSql)
        {
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql);
        }

        /// <summary>
        /// 获取泛型数据列表,建议只在多表联查时使用
        /// </summary>
        public IList<Hi.Model.BD_PromotionDetail2> GetList(string strSql)
        {
            return GetList(GetDataSet(strSql));
        }

        /// <summary>
        /// 获取数据集,在单表查询时使用
        /// </summary>
        public DataSet GetDataSet(string strWhat, string strWhere, string strOrderby)
        {
            if (string.IsNullOrEmpty(strWhat))
                strWhat = "*";
            StringBuilder strSql = new StringBuilder("select " + strWhat + " from [BD_PromotionDetail2]");
            if (!string.IsNullOrEmpty(strWhere))
                strSql.Append(" where " + strWhere);
            if (!string.IsNullOrEmpty(strOrderby))
                strSql.Append(" order by " + strOrderby);
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表,在单表查询时使用
        /// </summary>
        public IList<Hi.Model.BD_PromotionDetail2> GetList(string strWhat, string strWhere, string strOrderby)
        {
            return GetList(GetDataSet(strWhat, strWhere, strOrderby));
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public IList<Hi.Model.BD_PromotionDetail2> GetList(int pageSize, int pageIndex, string fldSort, bool sort, string strCondition, out int pageCount, out int count)
        {
            string strSql;
            DataSet ds = SqlHelper.PageList(SqlHelper.LocalSqlServer, "[BD_PromotionDetail2]", null, pageSize, pageIndex, fldSort, sort, strCondition, "ID", false, out pageCount, out count, out strSql);
            return GetList(ds);
        }
        #endregion

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Hi.Model.BD_PromotionDetail2 GetModel(DataRow r)
        {
            Hi.Model.BD_PromotionDetail2 model = new Hi.Model.BD_PromotionDetail2();
            model.ID = SqlHelper.GetInt(r["ID"]);
            model.ProID = SqlHelper.GetInt(r["ProID"]);
            model.CompID = SqlHelper.GetInt(r["CompID"]);
            model.OrderPrice = SqlHelper.GetDecimal(r["OrderPrice"]);
            model.Discount = SqlHelper.GetDecimal(r["Discount"]);
            model.dr = SqlHelper.GetInt(r["dr"]);
            model.modifyuser = SqlHelper.GetInt(r["modifyuser"]);
            model.CreateDate = SqlHelper.GetDateTime(r["CreateDate"]);
            model.CreateUserID = SqlHelper.GetInt(r["CreateUserID"]);
            model.ts = SqlHelper.GetDateTime(r["ts"]);
            return model;
        }

        /// <summary>
        /// 由数据集得到泛型数据列表
        /// </summary>
        private IList<Hi.Model.BD_PromotionDetail2> GetList(DataSet ds)
        {
            return Common.GetListEntity<Hi.Model.BD_PromotionDetail2>(ds.Tables[0]);
        }
    }
}
