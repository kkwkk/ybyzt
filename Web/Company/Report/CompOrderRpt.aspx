﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CompOrderRpt.aspx.cs" Inherits="Company_Report_CompOrderRpt" %>
<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager, Version=7.2.0.0, Culture=neutral, PublicKeyToken=fb0a0fe055d40fd4" %>
<%@ Register Src="~/UserControl/ButtonToExcel.ascx" TagPrefix="uc1" TagName="ToExcel" %>
<%@ Register Src="~/Company/UserControl/TopControl.ascx" TagPrefix="uc1" TagName="Top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>销售订单查询</title>
    <link href="../../Company/css/style.css" rel="stylesheet" type="text/css" />
    <link href="../css/global-2.0.css" rel="stylesheet" type="text/css" />
    <script src="../../Company/js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="../../Company/js/js.js" type="text/javascript"></script>
    <script src="../../js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script src="../../js/layer/layer.js" type="text/javascript"></script>
    <script src="../../js/layerCommon.js" type="text/javascript"></script>
    <script src="../../js/CommonJs.js" type="text/javascript"></script>

    <script src="../js/order.js" type="text/javascript"></script>

    <script type="text/javascript">

        $(function () {
            $(document).on("keydown", function (e) {
                if (e.keyCode == 13) {
                    $("#btnSearch").trigger("click");
                }
            })
        })
        $(document).ready(function () {
            //table 行样式
            $('.tablelist tbody tr:odd').addClass('odd');
            //订单生成 搜索
            $("#Search").on("click", function () {
                $("#btnSearch").trigger("click");
            });

            ///重置
            $("#li_Reset").click(function () {
                window.location.href = 'CompOrderRpt.aspx';
            });
        });

        //转到详细页
        function GotReturnInfo(Id) {
            var height = document.documentElement.clientHeight;
            var layerOffsetY = (height - 550) / 2; //计算宽度
            var index = layerCommon.openWindow('订单详情', '../Order/OrderCreateInfo.aspx?PostType=3&left=1&KeyID=' + Id, '900px', '450px');
            $("#hid_Alert").val(index);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:top ID="top1" runat="server" ShowID="nav-5" />
        
        <input type="hidden" id="hid_Alert" />
        <asp:Button ID="btnSearch" Text="搜索" runat="server" onclick="btnSearch_Click" style=" display:none"  />
        <div class="rightinfo">
              <!--当前位置 start-->
            <div class="place">
	            <ul class="placeul">
                    <li><a href="../jsc.aspx">我的桌面 </a></li><li>></li>
                    <li><a href="CompOrderRpt.aspx">销售订单查询</a></li>
	            </ul>
            </div>
            <!--当前位置 end--> 
            <!--功能按钮 start-->
            <div class="tools">
                <ul class="toolbar left">
                </ul>
                <div class="right">
                    <ul class="toolbar right">
                        <li id="Search"><span><img src="../../Company/images/t04.png" /></span>搜索</li>
                        <uc1:ToExcel runat="server" ID="ToExcel" contect="TbList" />
                        <li class="liSenior"><span><img src="../images/t07.png" /></span>高级</li>
                        <%--<li id="li_Print"><span><img src="../../Company/images/t10.png" /></span>导出</li>--%>
                    </ul>
                    <ul class="toolbar3">
                        <li>
                            代理商名称:<input name="txtDisName" type="text" id="txtDisName" runat="server" class="textBox"/>
                        </li>
                        <li>
                            订单编号:<input name="txtReceiptNo" type="text" id="txtReceiptNo" runat="server" class="textBox"/>&nbsp;&nbsp;
                        </li>
                            <li>
                             下单日期:<input name="txtCreateDate" runat="server" onclick="WdatePicker()" style="width: 115px;" id="txtCreateDate" readonly="readonly" type="text" class="Wdate" value="" />
                              -
                             <input name="txtECreateDate" runat="server" onclick="WdatePicker()" style="width: 115px;" id="txtECreateDate" readonly="readonly" type="text" class="Wdate" value="" />&nbsp;&nbsp;
                             </li>                       
                    </ul>
                </div>
            </div>
            <!--功能按钮 end-->
            
            <div class="hidden">
               <ul style=" width:900px;">
                  <li>
                     每页<input type="text" onkeyup='KeyInt(this)' id="txtPager" name="txtPager" runat="server" class="textBox" style=" width:40px;" />&nbsp;条
                  </li>
                  <li>总价区间：
                    <input name="txtTotalAmount1" id="txtTotalAmount1" runat="server" type="text" class="textBox2"/>
                     -
                    <input name="txtTotalAmount2" id="txtTotalAmount2" runat="server" type="text" class="textBox2"/>&nbsp;&nbsp;
                  </li>   
                   <li>支付状态:
                            <select name="PayState" runat="server" id="ddrPayState" class="downBox">
                                <option value="-1">全部</option>
                                <option value="0">未支付</option>
                                <option value="1">部分支付</option>
                                <option value="2">已支付</option>                               
                            </select>&nbsp;&nbsp;
                        </li>
                        <li>
                            订单状态：<select id="ddrOState" name="" runat="server" class="downBox">
                                <option value="-2">全部</option>                                
                                <option value="2">已审核</option>
                                <option value="4">已发货</option>
                                <option value="5">已到货</option>
                            </select>&nbsp;&nbsp;</li>             
               </ul>
             </div>

            <!--信息列表 start-->
                <asp:Repeater ID="rptOrder" runat="server" >
                    <HeaderTemplate>
                        <table class="tablelist" id="TbList">
                            <thead>
                                <tr>
                                    <%--<th><input type="checkbox" id="CB_SelAll" onclick="SelectAll(this)"/></th>--%>
                                    <th>代理商名称</th>
                                    <%--<th>代理商代码</th>--%>
                                    <th>订单编号</th>
                                    <th>订单状态</th>
                                    <th>支付状态</th>                                    
                                    <th>订单金额</th>
                                    <th>支付金额</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr id='tr_<%# Eval("ID") %>' >
                            <%--<td>
                                <asp:CheckBox ID="CB_SelItem" runat="server"></asp:CheckBox>
                                <asp:HiddenField ID="Hd_Id" runat="server" Value='<%# Eval("Id") %>' />        
                            </td>--%>
                            <td><%# Common.GetDis(Eval("DisID").ToString().ToInt(0),"DisName") %></td>
                            <%--<td><%# Common.GetDis(Eval("DisID").ToString().ToInt(0), "DisCode")%></td>--%>
                            <td><a style=" text-decoration:underline;" href="javascript:void(0)" onclick='GotReturnInfo(<%# Eval("ID") %>);'>
                                    <%# OrderInfoType.getOrder(Eval("ID"), "ReceiptNo")%>
                                </a>
                            </td>
                            <td><%# OrderInfoType.OState(Convert.ToInt16(Eval("ID").ToString()))%></td>
                            <td><%# GetPayState(Eval("PayState").ToString())%></td>
                            <td><%# Convert.ToDecimal(Eval("AuditAmount").ToString() == "" ? "0" : Eval("AuditAmount").ToString()).ToString("N")%></td>
                            <td><%# Convert.ToDecimal(Eval("PayedAmount").ToString() == "" ? "0" : Eval("PayedAmount").ToString()).ToString("N")%></td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        <tr id="trTotal" runat="server" visible='<%#bool.Parse((pageCount == Pager.CurrentPageIndex&&rptOrder.Items.Count!=0).ToString())%>'>
                            <td><font color="red">总计</font></td>
                            <td colspan="3">&nbsp;</td>
                            <td>
                                <asp:label ID="total1" runat="server" Text="" style="color:Red;"><%=ta.ToString("N") %></asp:label>
                            </td>
                            <td>
                                <asp:label ID="total2" runat="server" Text="" style="color:Red;"><%=tb.ToString("N") %></asp:label>
                            </td>
                        </tr>
                            </tbody>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            <!--信息列表 end-->

            <!--列表分页 start--> 
            <div class="pagin">
                <webdiyer:AspNetPager ID="Pager" runat="server" EnableTheming="true" PageIndexBoxType="TextBox"
                     NextPageText=">"  PageSize="12" PrevPageText="<" AlwaysShow="True" UrlPaging="false"
             ShowPageIndexBox="Always" TextAfterPageIndexBox="<span class='pagiPage'>页</span>"
                       TextBeforePageIndexBox="<span class='jump'>跳转到:</span>"
                                    CustomInfoSectionWidth="20%"  CustomInfoStyle="padding:5px 0 0 20px;cursor: default;color: #737373;"  CustomInfoClass="message" ShowCustomInfoSection="Left"
                  CustomInfoHTML="共%PageCount%页，每页%PageSize%条，共%RecordCount%条"
                     CssClass="paginList" CurrentPageButtonClass="paginItem" NumericButtonCount="5"
                    OnPageChanged="Pager_PageChanged" >
                    </webdiyer:AspNetPager>
            </div>
            <!--列表分页 end--> 
        </div>
        <div style=" margin-left:120px;"><span style="padding: 20px 0px 0px 20px;color:red;">备注：销售统计订单为已审核、已发货、已到货状态的订单。</span></div>
    </form>
</body>
</html>
