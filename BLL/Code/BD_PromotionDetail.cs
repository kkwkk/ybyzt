﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2016 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2016/3/21 14:10:31
//
// 功能描述: 
//
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;
using System.Data;
using Hi.Model;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Caching;

namespace Hi.BLL
{
    /// <summary>
    /// 业务逻辑类 BD_PromotionDetail
    /// </summary>
    public partial class BD_PromotionDetail
    {
        private readonly Hi.SQLServerDAL.BD_PromotionDetail dal = new Hi.SQLServerDAL.BD_PromotionDetail();
        public BD_PromotionDetail()
        { }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.BD_PromotionDetail model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加多条数据
        /// </summary>
        public void Add(List<Hi.Model.BD_PromotionDetail> l)
        {
            foreach (Hi.Model.BD_PromotionDetail model in l)
                dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hi.Model.BD_PromotionDetail model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新多条数据
        /// </summary>
        public void Update(List<Hi.Model.BD_PromotionDetail> l)
        {
            foreach (Hi.Model.BD_PromotionDetail model in l)
                dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            return dal.Delete(ID);
        }

        /// <summary>
        /// 删除多条数据
        /// </summary>
        public void Delete(List<int> l)
        {
            foreach (int ID in l)
                dal.Delete(ID);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hi.Model.BD_PromotionDetail GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到数据总条数
        /// </summary>
        public int GetCount()
        {
            DataSet ds = dal.GetDataSet("count(*)", null, null);
            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }

        /// <summary>
        /// 获得泛型数据列表,不建议直接使用此方法,请根据业务逻辑重写
        /// </summary>
        public List<Hi.Model.BD_PromotionDetail> GetList(string strWhat, string strWhere, string strOrderby)
        {
            return dal.GetList(strWhat, strWhere, strOrderby) as List<Hi.Model.BD_PromotionDetail>;
        }

        /// <summary>
        /// 分页获取泛型数据列表,不建议直接使用此方法,请根据业务逻辑重写
        /// </summary>
        public List<Hi.Model.BD_PromotionDetail> GetList(int pageSize, int pageIndex, string fldSort, bool Sort, string strCondition, out int pageCount, out int Counts)
        {
            return dal.GetList(pageSize, pageIndex, fldSort, Sort, strCondition, out pageCount, out Counts) as List<Hi.Model.BD_PromotionDetail>;
        }
        #endregion

        #region  扩展方法
        /// <summary>
        /// 获得全部泛型数据列表
        /// </summary>
        public List<Hi.Model.BD_PromotionDetail> GetAllList()
        {
            return GetList(null, null, null);
        }
        #endregion
    }
}
