﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Hi.BLL
{
    public partial class BD_TemplateAttrValue
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.BD_TemplateAttrValue model, System.Data.SqlClient.SqlTransaction Tran)
        {
            return dal.Add(model, Tran);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID, SqlTransaction Tran)
        {
            return dal.Delete(ID, Tran);
        }
    }
}
