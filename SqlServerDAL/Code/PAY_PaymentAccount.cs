﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2015 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2015/5/19 13:10:06
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
    /// 数据访问类 PAY_PaymentAccount
    /// </summary>
    public class PAY_PaymentAccount
    {
        public PAY_PaymentAccount()
        { }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.PAY_PaymentAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [PAY_PaymentAccount](");
            strSql.Append("[CompID],[DisID],[Isno],[OrgCode],[payName],[PayCode],[type],[Region],[PayType],[Remark],[Start],[CreateUser],[CreateDate],[ts],[dr],[modifyuser],[vdef1],[vdef2],[vdef3],[vdef4],[vdef5])");
            strSql.Append(" values (");
            strSql.Append("@CompID,@DisID,@Isno,@OrgCode,@payName,@PayCode,@type,@Region,@PayType,@Remark,@Start,@CreateUser,@CreateDate,@ts,@dr,@modifyuser,@vdef1,@vdef2,@vdef3,@vdef4,@vdef5)");
            strSql.Append(";select @@Identity");
            SqlParameter[] parameters = {
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@DisID", SqlDbType.Int),
                    new SqlParameter("@Isno", SqlDbType.Int),
                    new SqlParameter("@OrgCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@payName", SqlDbType.NVarChar,50),
                    new SqlParameter("@PayCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@type", SqlDbType.Int),
                    new SqlParameter("@Region", SqlDbType.NVarChar,20),
                    new SqlParameter("@PayType", SqlDbType.Int),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,200),
                    new SqlParameter("@Start", SqlDbType.Int),
                    new SqlParameter("@CreateUser", SqlDbType.Int),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.SmallInt),
                    new SqlParameter("@modifyuser", SqlDbType.Int),
                    new SqlParameter("@vdef1", SqlDbType.NVarChar,128),
                    new SqlParameter("@vdef2", SqlDbType.NVarChar,128),
                    new SqlParameter("@vdef3", SqlDbType.NVarChar,128),
                    new SqlParameter("@vdef4", SqlDbType.NVarChar,128),
                    new SqlParameter("@vdef5", SqlDbType.NVarChar,128)
            };
            parameters[0].Value = model.CompID;
            parameters[1].Value = model.DisID;
            parameters[2].Value = model.Isno;
            parameters[3].Value = model.OrgCode;
            parameters[4].Value = model.payName;
            parameters[5].Value = model.PayCode;
            parameters[6].Value = model.type;
            parameters[7].Value = model.Region;
            parameters[8].Value = model.PayType;

            if (model.Remark != null)
                parameters[9].Value = model.Remark;
            else
                parameters[9].Value = DBNull.Value;

            parameters[10].Value = model.Start;
            parameters[11].Value = model.CreateUser;

            if (model.CreateDate != DateTime.MinValue)
                parameters[12].Value = model.CreateDate;
            else
                parameters[12].Value = DBNull.Value;


            if (model.ts != DateTime.MinValue)
                parameters[13].Value = model.ts;
            else
                parameters[13].Value = DBNull.Value;

            parameters[14].Value = model.dr;
            parameters[15].Value = model.modifyuser;

            if (model.vdef1 != null)
                parameters[16].Value = model.vdef1;
            else
                parameters[16].Value = DBNull.Value;


            if (model.vdef2 != null)
                parameters[17].Value = model.vdef2;
            else
                parameters[17].Value = DBNull.Value;


            if (model.vdef3 != null)
                parameters[18].Value = model.vdef3;
            else
                parameters[18].Value = DBNull.Value;


            if (model.vdef4 != null)
                parameters[19].Value = model.vdef4;
            else
                parameters[19].Value = DBNull.Value;


            if (model.vdef5 != null)
                parameters[20].Value = model.vdef5;
            else
                parameters[20].Value = DBNull.Value;

            return SqlHelper.GetInt(SqlHelper.GetSingle(SqlHelper.LocalSqlServer, strSql.ToString(), parameters));
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hi.Model.PAY_PaymentAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [PAY_PaymentAccount] set ");
            strSql.Append("[CompID]=@CompID,");
            strSql.Append("[DisID]=@DisID,");
            strSql.Append("[Isno]=@Isno,");
            strSql.Append("[OrgCode]=@OrgCode,");
            strSql.Append("[payName]=@payName,");
            strSql.Append("[PayCode]=@PayCode,");
            strSql.Append("[type]=@type,");
            strSql.Append("[Region]=@Region,");
            strSql.Append("[PayType]=@PayType,");
            strSql.Append("[Remark]=@Remark,");
            strSql.Append("[Start]=@Start,");
            strSql.Append("[CreateUser]=@CreateUser,");
            strSql.Append("[CreateDate]=@CreateDate,");
            strSql.Append("[ts]=@ts,");
            strSql.Append("[dr]=@dr,");
            strSql.Append("[modifyuser]=@modifyuser,");
            strSql.Append("[vdef1]=@vdef1,");
            strSql.Append("[vdef2]=@vdef2,");
            strSql.Append("[vdef3]=@vdef3,");
            strSql.Append("[vdef4]=@vdef4,");
            strSql.Append("[vdef5]=@vdef5");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@DisID", SqlDbType.Int),
                    new SqlParameter("@Isno", SqlDbType.Int),
                    new SqlParameter("@OrgCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@payName", SqlDbType.NVarChar,50),
                    new SqlParameter("@PayCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@type", SqlDbType.Int),
                    new SqlParameter("@Region", SqlDbType.NVarChar,20),
                    new SqlParameter("@PayType", SqlDbType.Int),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,200),
                    new SqlParameter("@Start", SqlDbType.Int),
                    new SqlParameter("@CreateUser", SqlDbType.Int),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.SmallInt),
                    new SqlParameter("@modifyuser", SqlDbType.Int),
                    new SqlParameter("@vdef1", SqlDbType.NVarChar,128),
                    new SqlParameter("@vdef2", SqlDbType.NVarChar,128),
                    new SqlParameter("@vdef3", SqlDbType.NVarChar,128),
                    new SqlParameter("@vdef4", SqlDbType.NVarChar,128),
                    new SqlParameter("@vdef5", SqlDbType.NVarChar,128)
            };
            parameters[0].Value = model.ID;
            parameters[1].Value = model.CompID;
            parameters[2].Value = model.DisID;
            parameters[3].Value = model.Isno;
            parameters[4].Value = model.OrgCode;
            parameters[5].Value = model.payName;
            parameters[6].Value = model.PayCode;
            parameters[7].Value = model.type;
            parameters[8].Value = model.Region;
            parameters[9].Value = model.PayType;

            if (model.Remark != null)
                parameters[10].Value = model.Remark;
            else
                parameters[10].Value = DBNull.Value;

            parameters[11].Value = model.Start;
            parameters[12].Value = model.CreateUser;

            if (model.CreateDate != DateTime.MinValue)
                parameters[13].Value = model.CreateDate;
            else
                parameters[13].Value = DBNull.Value;


            if (model.ts != DateTime.MinValue)
                parameters[14].Value = model.ts;
            else
                parameters[14].Value = DBNull.Value;

            parameters[15].Value = model.dr;
            parameters[16].Value = model.modifyuser;

            if (model.vdef1 != null)
                parameters[17].Value = model.vdef1;
            else
                parameters[17].Value = DBNull.Value;


            if (model.vdef2 != null)
                parameters[18].Value = model.vdef2;
            else
                parameters[18].Value = DBNull.Value;


            if (model.vdef3 != null)
                parameters[19].Value = model.vdef3;
            else
                parameters[19].Value = DBNull.Value;


            if (model.vdef4 != null)
                parameters[20].Value = model.vdef4;
            else
                parameters[20].Value = DBNull.Value;


            if (model.vdef5 != null)
                parameters[21].Value = model.vdef5;
            else
                parameters[21].Value = DBNull.Value;


            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete [PAY_PaymentAccount] ");
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
            return SqlHelper.GetMaxID(SqlHelper.LocalSqlServer, "[ID]", "[PAY_PaymentAccount]");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [PAY_PaymentAccount]");
            strSql.Append(" where [ID]= @ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;
            return SqlHelper.Exists(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hi.Model.PAY_PaymentAccount GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [PAY_PaymentAccount] ");
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
        public IList<Hi.Model.PAY_PaymentAccount> GetList(string strSql)
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
            StringBuilder strSql = new StringBuilder("select " + strWhat + " from [PAY_PaymentAccount]");
            if (!string.IsNullOrEmpty(strWhere))
                strSql.Append(" where " + strWhere);
            if (!string.IsNullOrEmpty(strOrderby))
                strSql.Append(" order by " + strOrderby);
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表,在单表查询时使用
        /// </summary>
        public IList<Hi.Model.PAY_PaymentAccount> GetList(string strWhat, string strWhere, string strOrderby)
        {
            return GetList(GetDataSet(strWhat, strWhere, strOrderby));
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public IList<Hi.Model.PAY_PaymentAccount> GetList(int pageSize, int pageIndex, string fldSort, bool sort, string strCondition, out int pageCount, out int count)
        {
            string strSql;
            DataSet ds = SqlHelper.PageList(SqlHelper.LocalSqlServer, "[PAY_PaymentAccount]", null, pageSize, pageIndex, fldSort, sort, strCondition, "ID", false, out pageCount, out count, out strSql);
            return GetList(ds);
        }
        #endregion

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Hi.Model.PAY_PaymentAccount GetModel(DataRow r)
        {
            Hi.Model.PAY_PaymentAccount model = new Hi.Model.PAY_PaymentAccount();
            model.ID = SqlHelper.GetInt(r["ID"]);
            model.CompID = SqlHelper.GetInt(r["CompID"]);
            model.DisID = SqlHelper.GetInt(r["DisID"]);
            model.Isno = SqlHelper.GetInt(r["Isno"]);
            model.OrgCode = SqlHelper.GetString(r["OrgCode"]);
            model.payName = SqlHelper.GetString(r["payName"]);
            model.PayCode = SqlHelper.GetString(r["PayCode"]);
            model.type = SqlHelper.GetInt(r["type"]);
            model.Region = SqlHelper.GetString(r["Region"]);
            model.PayType = SqlHelper.GetInt(r["PayType"]);
            model.Remark = SqlHelper.GetString(r["Remark"]);
            model.Start = SqlHelper.GetInt(r["Start"]);
            model.CreateUser = SqlHelper.GetInt(r["CreateUser"]);
            model.CreateDate = SqlHelper.GetDateTime(r["CreateDate"]);
            model.ts = SqlHelper.GetDateTime(r["ts"]);
            model.dr = SqlHelper.GetInt(r["dr"]);
            model.modifyuser = SqlHelper.GetInt(r["modifyuser"]);
            model.vdef1 = SqlHelper.GetString(r["vdef1"]);
            model.vdef2 = SqlHelper.GetString(r["vdef2"]);
            model.vdef3 = SqlHelper.GetString(r["vdef3"]);
            model.vdef4 = SqlHelper.GetString(r["vdef4"]);
            model.vdef5 = SqlHelper.GetString(r["vdef5"]);
            return model;
        }

        /// <summary>
        /// 由数据集得到泛型数据列表
        /// </summary>
        private IList<Hi.Model.PAY_PaymentAccount> GetList(DataSet ds)
        {
            return Common.GetListEntity<Hi.Model.PAY_PaymentAccount>(ds.Tables[0]);
        }
    }
}
