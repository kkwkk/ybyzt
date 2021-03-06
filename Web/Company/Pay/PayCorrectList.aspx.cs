﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_Pay_PayCorrectList : CompPageBase
{
    public string page = "1";//默认初始页
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.txtPager.Value = "12";
            Bind();
        }
    }

    /// <summary>
    /// 代理商列表显示
    /// </summary>
    public void Bind()
    {
        //查询代理商
        int pageCount = 0;
        int Counts = 0;
        string strwhere = string.Empty;


        if (ViewState["strwhere"] != null)
        {
            strwhere += ViewState["strwhere"].ToString();
        }
  

        if (this.txtPager.Value.Trim().ToString() != "")
        {
            if (this.txtPager.Value.Trim().Length >= 5)
            {
                Pager.PageSize = 100;
                this.txtPager.Value = "100";
            }
            else
            {
                Pager.PageSize = this.txtPager.Value.Trim().ToInt(0);
            }
        }
        List<Hi.Model.BD_Distributor> dis = new Hi.BLL.BD_Distributor().GetList(Pager.PageSize, Pager.CurrentPageIndex, "shortindex", true, strwhere, out pageCount, out Counts);

        this.rptDis.DataSource = dis;
        this.rptDis.DataBind();

        Pager.RecordCount = Counts;
        page = Pager.CurrentPageIndex.ToString();
    }

    /// <summary>
    /// 代理商搜索
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string strWhere = string.Empty;

        if (this.txtDisID.Value != "")
        {
            strWhere += " and ID=" + this.hidDisId.Value;
        }

        ViewState["strwhere"] = strWhere;
        Bind();
    }


    /// <summary>
    /// 分页控件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Pager_PageChanged(object sender, EventArgs e)
    {
        page = Pager.CurrentPageIndex.ToString();
        Bind();
    }
    /// <summary>
    /// 新建冲正企业钱包
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //定义冲正的变量
        string txtPayCorrectDis = string.Empty;
        string txtPayCorrectPrice = string.Empty;
        //string txtPayCorrectDate = string.Empty;
        string txtPayCorrectType = string.Empty;
        string txtPayCorrectRemark = string.Empty;
        //获取冲正输入的数据
        txtPayCorrectDis = this.txtPayCorrectDis.Value.Trim().ToString();
        txtPayCorrectPrice = this.txtPayCorrectPrice.Value.Trim().ToString();
        //txtPayCorrectDate = this.txtPayCorrectDate.Value.Trim().ToString();
        txtPayCorrectType = this.txtPayCorrectType.Value.Trim().ToString();
        txtPayCorrectRemark = this.txtPayCorrectRemark.Value.Trim().ToString();
        //调用model,对属性进行赋值
        Hi.Model.PAY_PrePayment prepaymentmodel = new Hi.Model.PAY_PrePayment();
        prepaymentmodel.CompID = 1;
        prepaymentmodel.DisID = Convert.ToInt32(txtPayCorrectDis);
        prepaymentmodel.Start = 1;
        prepaymentmodel.PreType = Convert.ToInt32(txtPayCorrectType);
        prepaymentmodel.price =-Convert.ToDecimal(txtPayCorrectPrice);
        prepaymentmodel.Paytime = DateTime.Now;
        prepaymentmodel.CreatDate = DateTime.Now;
        prepaymentmodel.CrateUser = 1;
        prepaymentmodel.AuditState = 0;
        prepaymentmodel.IsEnabled = 1;
        prepaymentmodel.ts = DateTime.Now;
        prepaymentmodel.dr = 1;
        prepaymentmodel.modifyuser = 1;
        prepaymentmodel.vdef1 = txtPayCorrectRemark;
        //调用保存方法
        Hi.BLL.PAY_PrePayment prepaymentsave = new Hi.BLL.PAY_PrePayment();
        int reslut = prepaymentsave.Add(prepaymentmodel);
        //判断返回值int
        if (reslut > 0)
        {
            //sum代理商全部录入，冲正金额
            //decimal sums = prepaymentsave.sums(txtPayCorrectDis);
            //修改代理商的企业钱包金额
            //调用model,对属性进行赋值
            //Hi.Model.BD_Distributor dismodel = new Hi.BLL.BD_Distributor().GetModel(Convert.ToInt32(txtPayCorrectDis));
            //dismodel.DisAccount = sums;
            //调用修改方法    
            //Hi.BLL.BD_Distributor disupdate = new Hi.BLL.BD_Distributor();
            //bool disup = disupdate.Update(dismodel);

            JScript.AlertMethod(this, "冲正成功！", JScript.IconOption.笑脸, "function (){ location.replace('" + ("PayCorrectList.aspx") + "'); }");
        }
        else
        {
            JScript.AlertMethod(this, "冲正失败！", JScript.IconOption.哭脸, "function (){ location.replace('" + ("PayCorrectList.aspx") + "'); }");
        }



        
    }
}