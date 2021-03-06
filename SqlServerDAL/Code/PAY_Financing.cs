﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2015 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2015/10/12 11:19:53
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
    /// 数据访问类 PAY_Financing
    /// </summary>
    public class PAY_Financing
    {
        public PAY_Financing()
        { }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.PAY_Financing model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [PAY_Financing](");
            strSql.Append("[DisID],[CompID],[State],[OpenAccID],[OrderID],[AclAmt],[Guid],[Type],[RspCode],[RspMsg],[ReqXml],[vdef1],[vdef2],[vdef3],[ts],[dr],[modifyuser])");
            strSql.Append(" values (");
            strSql.Append("@DisID,@CompID,@State,@OpenAccID,@OrderID,@AclAmt,@Guid,@Type,@RspCode,@RspMsg,@ReqXml,@vdef1,@vdef2,@vdef3,@ts,@dr,@modifyuser)");
            strSql.Append(";select @@Identity");
            SqlParameter[] parameters = {
                    new SqlParameter("@DisID", SqlDbType.Int),
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@State", SqlDbType.Int),
                    new SqlParameter("@OpenAccID", SqlDbType.BigInt),
                    new SqlParameter("@OrderID", SqlDbType.BigInt),
                    new SqlParameter("@AclAmt", SqlDbType.Decimal),
                    new SqlParameter("@Guid", SqlDbType.NVarChar,50),
                    new SqlParameter("@Type", SqlDbType.Int),
                    new SqlParameter("@RspCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@RspMsg", SqlDbType.NVarChar,200),
                    new SqlParameter("@ReqXml", SqlDbType.NVarChar,500),
                    new SqlParameter("@vdef1", SqlDbType.NVarChar,50),
                    new SqlParameter("@vdef2", SqlDbType.NVarChar,50),
                    new SqlParameter("@vdef3", SqlDbType.NVarChar,50),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.SmallInt),
                    new SqlParameter("@modifyuser", SqlDbType.Int)
            };
            parameters[0].Value = model.DisID;
            parameters[1].Value = model.CompID;
            parameters[2].Value = model.State;
            parameters[3].Value = model.OpenAccID;
            parameters[4].Value = model.OrderID;
            parameters[5].Value = model.AclAmt;
            parameters[6].Value = model.Guid;
            parameters[7].Value = model.Type;

            if (model.RspCode != null)
                parameters[8].Value = model.RspCode;
            else
                parameters[8].Value = DBNull.Value;


            if (model.RspMsg != null)
                parameters[9].Value = model.RspMsg;
            else
                parameters[9].Value = DBNull.Value;


            if (model.ReqXml != null)
                parameters[10].Value = model.ReqXml;
            else
                parameters[10].Value = DBNull.Value;


            if (model.vdef1 != null)
                parameters[11].Value = model.vdef1;
            else
                parameters[11].Value = DBNull.Value;


            if (model.vdef2 != null)
                parameters[12].Value = model.vdef2;
            else
                parameters[12].Value = DBNull.Value;


            if (model.vdef3 != null)
                parameters[13].Value = model.vdef3;
            else
                parameters[13].Value = DBNull.Value;

            parameters[14].Value = model.ts;
            parameters[15].Value = model.dr;
            parameters[16].Value = model.modifyuser;
            return SqlHelper.GetInt(SqlHelper.GetSingle(SqlHelper.LocalSqlServer, strSql.ToString(), parameters));
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hi.Model.PAY_Financing model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [PAY_Financing] set ");
            strSql.Append("[DisID]=@DisID,");
            strSql.Append("[CompID]=@CompID,");
            strSql.Append("[State]=@State,");
            strSql.Append("[OpenAccID]=@OpenAccID,");
            strSql.Append("[OrderID]=@OrderID,");
            strSql.Append("[AclAmt]=@AclAmt,");
            strSql.Append("[Guid]=@Guid,");
            strSql.Append("[Type]=@Type,");
            strSql.Append("[RspCode]=@RspCode,");
            strSql.Append("[RspMsg]=@RspMsg,");
            strSql.Append("[ReqXml]=@ReqXml,");
            strSql.Append("[CcyCd]=@CcyCd,");
            strSql.Append("[vdef1]=@vdef1,");
            strSql.Append("[vdef2]=@vdef2,");
            strSql.Append("[vdef3]=@vdef3,");
            strSql.Append("[ts]=@ts,");
            strSql.Append("[dr]=@dr,");
            strSql.Append("[modifyuser]=@modifyuser");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.BigInt),
                    new SqlParameter("@DisID", SqlDbType.Int),
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@State", SqlDbType.Int),
                    new SqlParameter("@OpenAccID", SqlDbType.BigInt),
                    new SqlParameter("@OrderID", SqlDbType.BigInt),
                    new SqlParameter("@AclAmt", SqlDbType.Decimal),
                    new SqlParameter("@Guid", SqlDbType.NVarChar,50),
                    new SqlParameter("@Type", SqlDbType.Int),
                    new SqlParameter("@RspCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@RspMsg", SqlDbType.NVarChar,200),
                    new SqlParameter("@ReqXml", SqlDbType.NVarChar,500),
                    new SqlParameter("@CcyCd", SqlDbType.NVarChar,20),
                    new SqlParameter("@vdef1", SqlDbType.NVarChar,50),
                    new SqlParameter("@vdef2", SqlDbType.NVarChar,50),
                    new SqlParameter("@vdef3", SqlDbType.NVarChar,50),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.SmallInt),
                    new SqlParameter("@modifyuser", SqlDbType.Int)
            };
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DisID;
            parameters[2].Value = model.CompID;
            parameters[3].Value = model.State;
            parameters[4].Value = model.OpenAccID;
            parameters[5].Value = model.OrderID;
            parameters[6].Value = model.AclAmt;
            parameters[7].Value = model.Guid;
            parameters[8].Value = model.Type;

            if (model.RspCode != null)
                parameters[9].Value = model.RspCode;
            else
                parameters[9].Value = DBNull.Value;


            if (model.RspMsg != null)
                parameters[10].Value = model.RspMsg;
            else
                parameters[10].Value = DBNull.Value;


            if (model.ReqXml != null)
                parameters[11].Value = model.ReqXml;
            else
                parameters[11].Value = DBNull.Value;

            parameters[12].Value = model.CcyCd;

            if (model.vdef1 != null)
                parameters[13].Value = model.vdef1;
            else
                parameters[13].Value = DBNull.Value;


            if (model.vdef2 != null)
                parameters[14].Value = model.vdef2;
            else
                parameters[14].Value = DBNull.Value;


            if (model.vdef3 != null)
                parameters[15].Value = model.vdef3;
            else
                parameters[15].Value = DBNull.Value;

            parameters[16].Value = model.ts;
            parameters[17].Value = model.dr;
            parameters[18].Value = model.modifyuser;

            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete [PAY_Financing] ");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.BigInt)};
            parameters[0].Value = ID;

            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return SqlHelper.GetMaxID(SqlHelper.LocalSqlServer, "[ID]", "[PAY_Financing]");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [PAY_Financing]");
            strSql.Append(" where [ID]= @ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.BigInt)};
            parameters[0].Value = ID;
            return SqlHelper.Exists(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hi.Model.PAY_Financing GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [PAY_Financing] ");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.BigInt)};
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
        public IList<Hi.Model.PAY_Financing> GetList(string strSql)
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
            StringBuilder strSql = new StringBuilder("select " + strWhat + " from [PAY_Financing]");
            if (!string.IsNullOrEmpty(strWhere))
                strSql.Append(" where " + strWhere);
            if (!string.IsNullOrEmpty(strOrderby))
                strSql.Append(" order by " + strOrderby);
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表,在单表查询时使用
        /// </summary>
        public IList<Hi.Model.PAY_Financing> GetList(string strWhat, string strWhere, string strOrderby)
        {
            return GetList(GetDataSet(strWhat, strWhere, strOrderby));
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public IList<Hi.Model.PAY_Financing> GetList(int pageSize, int pageIndex, string fldSort, bool sort, string strCondition, out int pageCount, out int count)
        {
            string strSql;
            DataSet ds = SqlHelper.PageList(SqlHelper.LocalSqlServer, "[PAY_Financing]", null, pageSize, pageIndex, fldSort, sort, strCondition, "ID", false, out pageCount, out count, out strSql);
            return GetList(ds);
        }
        #endregion

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Hi.Model.PAY_Financing GetModel(DataRow r)
        {
            Hi.Model.PAY_Financing model = new Hi.Model.PAY_Financing();
            model.ID = SqlHelper.GetInt(r["ID"]);
            model.DisID = SqlHelper.GetInt(r["DisID"]);
            model.CompID = SqlHelper.GetInt(r["CompID"]);
            model.State = SqlHelper.GetInt(r["State"]);
            model.OpenAccID = SqlHelper.GetInt(r["OpenAccID"]);
            model.OrderID = SqlHelper.GetInt(r["OrderID"]);
            model.AclAmt = SqlHelper.GetDecimal(r["AclAmt"]);
            model.Guid = SqlHelper.GetString(r["Guid"]);
            model.Type = SqlHelper.GetInt(r["Type"]);
            model.RspCode = SqlHelper.GetString(r["RspCode"]);
            model.RspMsg = SqlHelper.GetString(r["RspMsg"]);
            model.ReqXml = SqlHelper.GetString(r["ReqXml"]);
            model.CcyCd = SqlHelper.GetString(r["CcyCd"]);
            model.vdef1 = SqlHelper.GetString(r["vdef1"]);
            model.vdef2 = SqlHelper.GetString(r["vdef2"]);
            model.vdef3 = SqlHelper.GetString(r["vdef3"]);
            model.ts = SqlHelper.GetDateTime(r["ts"]);
            model.dr = SqlHelper.GetInt(r["dr"]);
            model.modifyuser = SqlHelper.GetInt(r["modifyuser"]);
            return model;
        }

        /// <summary>
        /// 由数据集得到泛型数据列表
        /// </summary>
        private IList<Hi.Model.PAY_Financing> GetList(DataSet ds)
        {
            return Common.GetListEntity<Hi.Model.PAY_Financing>(ds.Tables[0]);
        }
    }
}
