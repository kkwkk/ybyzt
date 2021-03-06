﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShopMessage.aspx.cs" Inherits="Company_ShopManager_ShopMessage" %>

<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager, Version=7.2.0.0, Culture=neutral, PublicKeyToken=fb0a0fe055d40fd4" %>
<%@ Register Src="~/Company/UserControl/TopControl.ascx" TagPrefix="uc1" TagName="Top" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Cache-Control" content="no-cache">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>店铺留言</title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../css/global-2.0.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="../js/js.js" type="text/javascript"></script>
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
            $("#Search").on("click", function () {
                $("#btnSearch").trigger("click");
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:Top ID="top1" runat="server" ShowID="nav-6" />
    <div class="rightinfo">
        <!--当前位置 start-->
        <div class="place">
            <ul class="placeul">
                <li><a href="../jsc.aspx">我的桌面 </a></li>
                <li>></li>
                <li><a href="javascript:;">店铺留言</a></li>
            </ul>
        </div>
        <!--当前位置 end-->
        <asp:Button ID="btnSearch" Text="搜索" runat="server" OnClick="btnSearch_Click" Style="display: none" />
        <!--功能按钮 start-->
        <div class="tools">
            <ul class="toolbar left">
            </ul>
            <div class="right">
                <ul class="toolbar right">
                    <li id="Search"><span>
                        <img src="../images/t04.png" /></span>搜索</li>
                </ul>
                <ul class="toolbar3">
                    <li>内容:<input id="txtPhone" runat="server" type="text" class="textBox txtPhone" />
                    </li>
                    <li>&nbsp;状态:
                        <asp:DropDownList ID="ddlRead" runat="server" Width="72px" CssClass="textBox">
                            <asp:ListItem Value="2">全部</asp:ListItem>
                            <asp:ListItem Value="1">已读</asp:ListItem>
                            <asp:ListItem Value="0">未读</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp; &nbsp; </li>
                    <li>每页<input runat="server" id="txtPageSize" onkeyup='KeyInt(this)' type="text" style="width: 40px;"
                        class="textBox" />行</li>
                </ul>
            </div>
        </div>
        <!--功能按钮 end-->
        <div class="hidden">
            <ul>
            </ul>
        </div>
        <!--信息列表 start-->
        <table class="tablelist">
            <thead>
                <tr>
                    <th class="t3">
                        姓名
                    </th>
                    <th class="t1">
                        手机
                    </th>
                    <th class="t6">
                        内容
                    </th>
                    <th class="t2">
                        状态
                    </th>
                    <th class="t2">
                        留言时间
                    </th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Rpt_Role" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <div class="tcle">
                                    <%# Eval("name")%></div>
                            </td>
                            <td>
                                <div class="tcle">
                                    <%#Eval("phone").ToString()%></div>
                            </td>
                            <td>
                                <div class="tc">
                              <a href="ShopMessageInfo.aspx?ID=<%# Eval("ID") %>"><%# GetTitle(Eval("remark").ToString())%></a></div>
                            </td>
                            <td>
                                <div class="tc">
                                    <%# Eval("IsRead").ToString()=="0"?"未读":"已读" %></div>
                            </td>
                            <td>
                                <div class="tc">
                                    <%# Eval("CreateDate","{0:yyyy-MM-dd}") %></div>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <!--信息列表 end-->
        <!--列表分页 start-->
        <div class="pagin">
            <webdiyer:AspNetPager ID="Pager" runat="server" EnableTheming="true" PageIndexBoxType="TextBox"
                NextPageText=">" PageSize="12" PrevPageText="<" AlwaysShow="True" UrlPaging="false"
                ShowPageIndexBox="Always" TextAfterPageIndexBox="<span class='pagiPage'>页</span>"
                TextBeforePageIndexBox="<span class='jump'>跳转到:</span>" CustomInfoSectionWidth="20%"
                CustomInfoStyle="padding:5px 0 0 20px;cursor: default;color: #737373;" CustomInfoClass="message"
                ShowCustomInfoSection="Left" CustomInfoHTML="共%PageCount%页，每页%PageSize%条，共%RecordCount%条"
                CssClass="paginList" CurrentPageButtonClass="paginItem" NumericButtonCount="5"
                OnPageChanged="Pager_PageChanged">
            </webdiyer:AspNetPager>
        </div>
        <!--列表分页 end-->
    </div>
    <input type="button" runat="server" id="btn_Search" style="display: none;" onserverclick="btnSearch_Click" />
    </form>
</body>
</html>
