//选择支付方式
$(function () {
    $("#checkId .li a.check").on("click", function () {
        var PayDiv = $(this).parent("div");
        if (!PayDiv.is("[class*='center']")) {
            if (PayDiv.attr("id") != "a4" && $("#hida4").val() == "1") {
                $("#a4").removeClass("center");
                $("#hida4").val("0");
                $("#lblPrice4").html("0.00");
                $(".payBtn .btn").html("立即支付");
                $("#lblBalance").hide();
                $("#lblBalance2").hide();
                $("#lblFinancingMsg").show();
                $("#a4").children("ul").children("li").removeClass("border");
            }
            PayDiv.addClass("center");
            if (PayDiv.attr("id") == "a1") {
                $("#hida1").val("1");
                $(".payPas").show();
                $("#txtPrice").show();
                $("#txtPrice").blur();
            }
            else if (PayDiv.attr("id") == "a2") {
                $("#hida2").val("1");
                $("#hida3").val("0");
                $("#hida5").val("0");
                var falg = false;
                $("div#a3").removeClass("center");
                $("#checkId .li .bankCard2 li").removeClass("border2");

                $("div#a5").removeClass("center");
                $("#checkId .li .platformPay a").removeClass("hover");

                PayDiv.children("ul").children("li").each(function () {
                    if ($(this).find(".hidFastID").val() == $("#hidFastPay").val()) {
                        falg = true;
                        $(this).click();
                        return false;
                    }
                });
                if (!falg) {
                    PayDiv.children("ul").children("li:first-child").click();
                    //支付手续费 -start 
                    var txtPrice = 0;
                    if ($("#hida1").val() == "1")
                        txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额  
                    var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val(); //本次支付金额
                    var a2sxf = txtPayOrder - txtPrice;
                    var a3sxf = txtPayOrder - txtPrice;
                    Js_sxf(a2sxf, a3sxf);
                    //支付手续费 -end 
                }
            }
            else if (PayDiv.attr("id") == "a3") {
                $("#hida2").val("0");
                $("#hida3").val("1");
                $("#hida5").val("0");
                var falg = false;
                $("div#a2").removeClass("center");
                $("#checkId .li .bankCard li").removeClass("border");

                $("div#a5").removeClass("center");
                $("#checkId .li .platformPay a").removeClass("hover");

                PayDiv.children("div").children("ul").children("li").each(function () {
                    if ($(this).children("a").find(".hidBank").val() == $("#hidBank").val()) {

                        falg = true;
                        $(this).click();
                        return false;
                    }
                });
                if (!falg) {
                    PayDiv.children("div").children("ul").children("li:first-child").click();
                }
            } else if (PayDiv.attr("id") == "a5") {
                $("#hida2").val("0");
                $("#hida3").val("0");
                $("#hida5").val("1");
                var falg = false;
                $("div#a2").removeClass("center");
                $("#checkId .li .bankCard li").removeClass("border");

                $("div#a3").removeClass("center");
                $("#checkId .li .bankCard2 li").removeClass("border2");

                PayDiv.children("div").children("a:first-child").click();
                //支付手续费 -start 
                var txtPrice = 0;
                if ($("#hida1").val() == "1")
                    txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额  
                var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val(); //本次支付金额
                var a2sxf = txtPayOrder - txtPrice;
                var a3sxf = txtPayOrder - txtPrice;
                Js_sxf(a2sxf, a3sxf);
                //支付手续费 -end 
            }
            else if (PayDiv.attr("id") == "a4") {
                $("#hida4").val("1");
                if ($("#hida1").val() == "1") {
                    $("#a1").find("a.check").click();
                }
                if ($("#hida2").val() == "1") {
                    $("#a2").find("a.check").click();
                }
                if ($("#hida3").val() == "1") {
                    $("#a3").find("a.check").click();
                }
                $("#lblPrice4").html(parseFloat($("#txtPayOrder").val()).toFixed(2));
                $("#lblBalance").show();
                $("#lblBalance2").show();
                $("#lblFinancingMsg").hide();
                PayDiv.children("ul").children("li:first-child").click();
            }
        } else {
            if (PayDiv.attr("id") == "a1") {
                PayDiv.removeClass("center");
                $("#hida1").val("0");
                $(".payPas").hide();
                $("#txtPrice").hide();

                var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val();
                $("#lblPrice2").html(parseFloat(txtPayOrder).toFixed(2));
                $("#lblPrice3").html(parseFloat(txtPayOrder).toFixed(2));
                $("#lblPrice5").html(parseFloat(txtPayOrder).toFixed(2));
                //支付手续费 -start 
                Js_sxf(parseFloat(txtPayOrder).toFixed(2), parseFloat(txtPayOrder).toFixed(2));
                //支付手续费 -end 



                if ($("#hida3").val() == "1" && $("#hida4").val() != "1") {
                    $("#checkId div#a3 a.check").click();
                } else {
                    if ($("#hida2").val() == "0" && $("#hida4").val() != "1" && $("#hida5").val() != "1") {
                        $("#checkId div#a2 a.check").click();
                    }
                }
            } else if (PayDiv.attr("id") == "a2") {
                var txtPayOrder = $("#txtPayOrder").val();
                var txtPrice = $("#txtPrice").val();
                if (($("#hida1").val() == "1" && parseFloat(txtPayOrder) == parseFloat(txtPrice)) || $("#hida4").val() == "1") {
                    PayDiv.removeClass("center");
                    $("#hida2").val("0");
                    PayDiv.children("ul").children("li").removeClass("border");
                }
            } else if (PayDiv.attr("id") == "a3") {
                var txtPayOrder = $("#txtPayOrder").val();
                var txtPrice = $("#txtPrice").val();
                if ($("#hida1").val() == "1" && parseFloat(txtPayOrder) == parseFloat(txtPrice) || $("#hida4").val() == "1") {
                    PayDiv.removeClass("center");
                    $("#hida3").val("0");
                    PayDiv.children("ul").children("li").removeClass("border2");
                }
            } else if (PayDiv.attr("id") == "a4") {
                $("#lblPrice4").html("0.00");
                $("#lblBalance").hide();
                $("#lblBalance2").hide();
                $("#lblFinancingMsg").show();
                PayDiv.children("ul").children("li").removeClass("border2");
                $("#a1").find("a.check").click();
            }

            else if (PayDiv.attr("id") == "a5") {
                var txtPayOrder = $("#txtPayOrder").val();
                var txtPrice = $("#txtPrice").val();
                if ($("#hida1").val() == "1" && parseFloat(txtPayOrder) == parseFloat(txtPrice)) {
                    $("#hida5").val("0");
                    $("div#a5").removeClass("center");
                    $("#checkId .li .platformPay a").removeClass("hover");
                }
            }
        }
    })

});



//快捷支付银行卡绑定所有按钮操作
$(function () {
    //点击下一步按钮
    $(".addBank .btnId").click(function () {
        if (!$(".addBank li").is("[class*='border3']")) {
            alert("请选择银行！");
            return false;
        }
        $(".a5").removeClass("noOff")//隐藏选择快捷支付银行卡div  有nooff就显示，没有就隐藏
        $(".a6").addClass("noOff"); //显示快捷支付绑定div
        $("#imgBankImg").show(); //隐藏img按钮
        $(".addBank .bankCard2 li").removeClass("border3"); //删除所有选择银行卡
    });
    //点选择其他银行 按钮
    $(".addBank .return").click(function () {
        $(".a6").removeClass("noOff")//隐藏快捷支付绑定div
        $(".a7").removeClass("noOff")
        $(".a5").addClass("noOff"); //显示选择快捷支付银行卡div
        $(".addBank .bankCard2 li").removeClass("border3"); //删除所有选择的银行卡
    });

    //暂不用
    $(".addCardNr .cara").click(function () {
        $(".a7").removeClass("noOff")
        $(".a6").addClass("noOff");
    });
    //暂不用
    $(".addCardNr .carb").click(function () {
        $(".a6").removeClass("noOff")
        $(".a7").addClass("noOff");
    });
})

//重写F5
document.onkeydown = function () {
    if (window.event && window.event.keyCode == 116) {
        location.replace(location);
        return false;
    }
    /*
    if (window.event && window.event.keyCode == 123) {
    window.event.returnValue = false;
    }
    */
}

jQuery(document).ready(function ($) {
    //点击添加银行卡事件
    $('.cd-popup-trigger').on('click', function (event) {
        event.preventDefault(); //阻止冒泡
        $('.cd-popup').addClass('is-visible'); //显示快捷支付银行卡绑定弹出框
        //$("#addBank .addBank .bankCard2 li:first-child").click();
        $(".a5").removeClass("noOff")//隐藏银行卡列表页面
        $(".a6").addClass("noOff"); //显示绑定银行卡页面
        $("#imgBankImg").removeAttr("src"); //
        $("#imgBankImg").hide();
        $("#txtBankCode").val("");
        $("#txtUserName").val("");
        $("#txtIDCard").val("");
        $("#txtPhone").val("");
        $("#txtPhoneCode").val("");
        $("#hidden").val("");
        $(".fx").removeAttr("checked"); //合同条约
        $("#otherBank").parent().show(); //显示更多银行卡按钮
        $(".otherBank").hide(); //隐藏更多银行卡列表
    });

    //close popup  关闭快捷支付银行卡绑定弹出框
    $('.cd-popup').on('click', function (event) {
        if ($(event.target).is('.cd-popup-close') || $(event.target).is('.cd-popup')) {
            event.preventDefault();
            $(this).removeClass('is-visible');
            //location.replace(location);
        }
    });
    //close popup when clicking the esc keyboard button
    $(document).keyup(function (event) {
        if (event.which == '27') {
            $('.cd-popup').removeClass('is-visible');
            //location.replace(location);
        }
    });

    //网银支付是选择哪个银行卡---个人账户--借记卡
    $("#checkId .li #divbank1 .bankCard2 li").click(function (event) {
        event.stopPropagation();
        $("#checkId .li #divbank1 .bankCard2 li").removeClass("border2"); //清空所有选择        
        $(this).addClass("border2"); //添加当前选中的银行卡        
        if ($(this).parent().parent().parent().attr("id") == "a3") {
            $("#hidBank").val($(this).children("a").children("input[class*='hidBank']").val()); //给隐藏域赋值银行编号

            //支付手续费 -start 
            var txtPrice = 0.00;
            if ($("#hida1").val() == "1")
                txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额            

            var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val(); //本次支付金额

            var a2sxf = txtPayOrder - txtPrice;
            var a3sxf = txtPayOrder - txtPrice;

            Js_sxf(a2sxf, a3sxf);
            //支付手续费 -end 

        }
    });
    //网银支付是选择哪个银行卡---个人账户--贷记卡
    $("#checkId .li #divbank3 .bankCard2 li").click(function (event) {
        event.stopPropagation();
        $("#checkId .li #divbank3 .bankCard2 li").removeClass("border2"); //清空所有选择        
        $(this).addClass("border2"); //添加当前选中的银行卡        
        if ($(this).parent().parent().parent().attr("id") == "a3") {
            $("#hidBank").val($(this).children("a").children("input[class*='hidBank']").val()); //给隐藏域赋值银行编号

            //支付手续费 -start 
            var txtPrice = 0;
            if ($("#hida1").val() == "1")
                txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额            

            var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val(); //本次支付金额

            var a2sxf = txtPayOrder - txtPrice;
            var a3sxf = txtPayOrder - txtPrice;

            Js_sxf(a2sxf, a3sxf);
            //支付手续费 -end 

        }
    });
    //网银支付是选择哪个银行卡---企业账户
    $("#checkId .li #divbank2 .bankCard2 li").click(function (event) {
        event.stopPropagation();
        $("#checkId .li #divbank2 .bankCard2 li").removeClass("border2"); //清空所有选择        
        $(this).addClass("border2"); //添加当前选中的银行卡        
        if ($(this).parent().parent().parent().attr("id") == "a3") {
            $("#hidBank").val($(this).children("a").children("input[class*='hidBank']").val()); //给隐藏域赋值银行编号

            //支付手续费 -start 
            var txtPrice = 0;
            if ($("#hida1").val() == "1")
                txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额            

            var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val(); //本次支付金额

            var a2sxf = txtPayOrder - txtPrice;
            var a3sxf = txtPayOrder - txtPrice;

            Js_sxf(a2sxf, a3sxf);
            //支付手续费 -end 

        }
    });


    //快捷支付，选择哪一个快捷支付
    $("body").on("click", "#checkId .li .bankCard li", function (event) {
        event.stopPropagation();
        $("#checkId .li .bankCard li").removeClass("border"); //清空所有选择
        $(this).addClass("border"); //添加当前选择快捷支付银行
        $("#hidFastPay").val($(this).children("input[class*='hidFastID']").val()); //给隐藏域赋值快捷支付ID
        if ($("#a2").is("[class*='center']")) {
            //$("#a2").click();
            //$("#checkId div#a2 a.check").click();

            //支付手续费 -start 
            var txtPrice = 0;
            if ($("#hida1").val() == "1")
                txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额  
            var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val(); //本次支付金额
            var a2sxf = txtPayOrder - txtPrice;
            var a3sxf = txtPayOrder - txtPrice;
            Js_sxf(a2sxf, a3sxf);
            //支付手续费 -end 
        }


    });


    //其它支付---选择微信、支付宝支付
    $("#checkId .li .platformPay a").click(function (event) {
        event.stopPropagation();
        $("#checkId .li .platformPay a").removeClass("hover"); //清空所有选择        
        $(this).addClass("hover"); //添加当前选中的银行卡 

        if ($(this).parent().parent().attr("id") == "a5") {
            $("#hidWxorAplipay").val($(this).children("input[class*='abcd']").val()); //给隐藏域赋值银行编号            
        }

        //支付手续费 -start 
        var txtPrice = 0;
        if ($("#hida1").val() == "1")
            txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额  
        var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val(); //本次支付金额
        var a2sxf =0;
        var a3sxf = txtPayOrder - txtPrice;
        Js_sxf(a2sxf, a3sxf);
        //支付手续费 -end 
    });




    //快捷支付添加银行卡，银行卡选中事件
    $(".addBank .bankCard2 li").click(function () {
        $(".addBank .bankCard2 li").removeClass("border3");
        $(this).addClass("border3");
        $("#imgBankImg").attr("src", $(this).children("a").children("img").attr("src"));
        $("#hidBankid").val($(this).children("a").children("input[class*='hidBankCode']").val());
        $("#hidBankLogo").val($(this).children("a").children("img").attr("src"));
    });

    //之前版本，输入金额，防止冒泡事件
    $("#txtPrice").click(function () {
        return false;
    });
    $("#txtPrice1").click(function () {
        return false;
    });
    $("#txtPrice2").click(function () {
        return false;
    });

    //企业钱包文本框，键盘起来的事件
    $("#txtPrice").keyup(function () {
        var sumPrice = $("#hidSumPrice").val(); //企业钱包总金额   ；$(this).val()-》本次输入的企业钱包金额
        if (parseFloat($(this).val()) > parseFloat(sumPrice)) {
            $(this).val(parseFloat(sumPrice).toFixed(2));
        }
        var txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额
        var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val(); //本次支付金额

        //预付款金额调整为0时，企业钱包支付勾选去掉
        if (parseFloat(txtPrice) == 0) {
            $("#a1").find("a.check").click();
        }

        //如果支付金额大于企业钱包金额
        if (parseFloat(txtPayOrder) > parseFloat(txtPrice)) {
            $("#lblPrice1").html(parseFloat(txtPrice).toFixed(2));
            $("#lblPrice2").html((parseFloat(txtPayOrder) - parseFloat(txtPrice)).toFixed(2));
            $("#lblPrice3").html((parseFloat(txtPayOrder) - parseFloat(txtPrice)).toFixed(2));
            $("#lblPrice5").html((parseFloat(txtPayOrder) - parseFloat(txtPrice)).toFixed(2));

            if ($("#hida3").val() == "1") {
                $("#checkId div#a3 a.check").click();
            } else {
                if ($("#hida2").val() == "0" && $("#hida5").val() == "0")
                    $("#checkId div#a2 a.check").click();
            }

        } //如果支付金额小于企业钱包金额
        else if (parseFloat(txtPayOrder) < parseFloat(txtPrice)) {
            $(this).val(parseFloat(txtPayOrder).toFixed(2));
            $("#lblPrice1").html(parseFloat(txtPayOrder).toFixed(2));
            $("#lblPrice2").html("0.00");
            $("#lblPrice3").html("0.00");
            $("#lblPrice5").html("0.00");
        } else {
            $("#lblPrice1").html(parseFloat(txtPayOrder).toFixed(2));
            $("#lblPrice2").html("0.00");
            $("#lblPrice3").html("0.00");
            $("#lblPrice5").html("0.00");
        }
    });
    //企业钱包文本框失去焦点事件
    $("#txtPrice").blur(function () {
        var sumPrice = $("#hidSumPrice").val();
        if (parseFloat($(this).val()) > parseFloat(sumPrice)) {
            $(this).val(parseFloat(sumPrice).toFixed(2));
        }
        var txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //本次输入的企业钱包金额
        var txtPayOrder = $("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val();



        if (parseFloat(txtPayOrder) > parseFloat(txtPrice)) {
            $("#lblPrice1").html(parseFloat(txtPrice).toFixed(2));
            $("#lblPrice2").html((parseFloat(txtPayOrder) - parseFloat(txtPrice)).toFixed(2));
            $("#lblPrice3").html((parseFloat(txtPayOrder) - parseFloat(txtPrice)).toFixed(2));
            $("#lblPrice5").html((parseFloat(txtPayOrder) - parseFloat(txtPrice)).toFixed(2));

            //支付手续费 -start 
            Js_sxf((parseFloat(txtPayOrder) - parseFloat(txtPrice)).toFixed(2), (parseFloat(txtPayOrder) - parseFloat(txtPrice)).toFixed(2));
            //支付手续费 -end 

            if ($("#hida3").val() == "1") {
                $("#checkId div#a3 a.check").click();
            } else {
                if ($("#hida2").val() == "0" && $("#hida5").val() == "0") {
                    if ($("#hida1").val() == "1")
                        $("#txtPrice").val(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? txtPayOrder : hidSumPrice);
                    if (parseFloat(txtPayOrder) - parseFloat($("#txtPrice").val()) > 0)
                        $("#checkId div#a2 a.check").click();
                }
            }
        } else {
            $(this).val(parseFloat(txtPayOrder).toFixed(2));
            $("#lblPrice1").html(parseFloat(txtPayOrder).toFixed(2));
            $("#lblPrice2").html("0.00");
            $("#lblPrice3").html("0.00");
            $("#lblPrice5").html("0.00");
            //支付手续费 -start 
            Js_sxf(parseFloat("0.00"), parseFloat("0.00"));
            //支付手续费 -end 
        }
        var price1 = $(this).val() == "" ? "0.00" : $(this).val();
        $(this).val(parseFloat(price1).toFixed(2));
    });

    //本次支付金额文本框键盘起来事件
    $("#txtPayOrder").keyup(function () {
        var hidPricePay = $("#hidPricePay").val(); //未支付金额
        var txtPayOrder = $(this).val() == "" ? "0.00" : $(this).val(); //本次支付金额
        //本次支付金额大于未支付金额时，本次支付金额=未支付金额
        if (parseFloat(txtPayOrder) > parseFloat(hidPricePay)) {
            $(this).val(parseFloat(hidPricePay).toFixed(2));
        }
        $("#lblPrice4").html(parseFloat($("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val()).toFixed(2));
    }).blur(function () {//失去焦点事件
        if (parseFloat($(this).val()) == 0) {
            $(this).val($("#hidPricePay").val());
        }
        var hidPricePay = $("#hidPricePay").val(); //未支付金额
        var txtPayOrder = $(this).val() == "" ? "0.00" : $(this).val();
        var txtPrice = $("#txtPrice").val() == "" ? "0.00" : $("#txtPrice").val(); //企业钱包金额
        var hidSumPrice = $("#hidSumPrice").val(); //企业钱包总金额
        //本次支付金额大于未支付金额时，本次支付金额=未支付金额
        if (parseFloat(txtPayOrder) > parseFloat(hidPricePay)) {
            $(this).val(parseFloat(hidPricePay).toFixed(2));
        }
        var price1 = $(this).val() == "" ? "0.00" : $(this).val();
        $(this).val(parseFloat(price1).toFixed(2));
        if ($("#hida1").val() == "1") {
            if (parseFloat(txtPayOrder) > parseFloat(txtPrice)) {

                //本次支付金额大于预付款总金额时
                if (parseFloat(txtPayOrder) > parseFloat(hidSumPrice)) {

                    if ($("#hida3").val() == "1") {
                        $("#checkId div#a3 a.check").click();
                    } else {
                        if ($("#hida2").val() == "0" && $("#hida5").val() == "0")
                            $("#checkId div#a2 a.check").click();
                    }

                } else {
                    //是否优先使用企业钱包金额
                    //                    $("#hida2").val("0");
                    //                    $("#checkId div#a2.li a.check").parent("div").removeClass("center");
                    //                    $("#checkId div#a2.li").children("ul").children("li").removeClass("border");                   
                    //                    $("#txtPrice").val($(this).val());

                }


            } else {
                $("#checkId div#a2.li a.check").parent("div").removeClass("center");
                $("#checkId div#a2.li").children("ul").children("li").removeClass("border");
                $("#hida2").val("0");

            }
            $("#txtPrice").blur();
        } else {
            $("#lblPrice2").html(parseFloat(txtPayOrder).toFixed(2));
            $("#lblPrice3").html(parseFloat(txtPayOrder).toFixed(2));
            $("#lblPrice5").html(parseFloat(txtPayOrder).toFixed(2));
            //支付手续费 -start 
            Js_sxf(parseFloat(txtPayOrder).toFixed(2), parseFloat(txtPayOrder).toFixed(2));
            //支付手续费 -end 
        }
        $("#lblPrice4").html(parseFloat($("#txtPayOrder").val() == "" ? "0.00" : $("#txtPayOrder").val()).toFixed(2));
    });


    //js默认方法，给本次支付金额赋值
    $("#txtPayOrder").blur();


    //重新js的toFixed方法
    Number.prototype.toFixed = function (s) {
        changenum = (parseInt(this * Math.pow(10, s) + 0.5) / Math.pow(10, s)).toString();
        index = changenum.indexOf(".");
        if (index < 0 && s > 0) {
            changenum = changenum + ".";
            for (i = 0; i < s; i++) {
                changenum = changenum + "0";
            }

        } else {
            index = changenum.length - index;
            for (i = 0; i < (s - index) + 1; i++) {
                changenum = changenum + "0";
            }

        }
        return changenum;
    }



    var hidSumPrice = $("#hidSumPrice").val();
    var txtPayOrder = $("#txtPayOrder").val();
    if ($("#hida1").val() == "1") {
        if (parseFloat(hidSumPrice) > 0)
            $("#checkId #a1 a.check").click();

        $("#txtPrice").val(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? txtPayOrder : hidSumPrice);
        $("#lblPrice1").html(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? txtPayOrder : hidSumPrice);
        $("#lblPrice2").html(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? "0.00" : parseFloat(parseFloat(txtPayOrder) - parseFloat(hidSumPrice)).toFixed(2));
        $("#lblPrice3").html(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? "0.00" : parseFloat(parseFloat(txtPayOrder) - parseFloat(hidSumPrice)).toFixed(2));
        $("#lblPrice5").html(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? "0.00" : parseFloat(parseFloat(txtPayOrder) - parseFloat(hidSumPrice)).toFixed(2));


    }
    if ($("#hida2").val() == "1") {
        $("#checkId #a2 a.check").click();
    }
    if ($("#hida3").val() == "1") {
        $("#checkId #a3 a.check").click();
    }

    if ($("#hida2").val() == "") {
        $("#hida2").val("0");
        if (parseFloat(txtPayOrder) - parseFloat(hidSumPrice) > 0)
            $("#checkId #a2 a.check").click();
    }
    if ($("#hida3").val() == "") {
        $("#hida3").val("0");
    }
    if ($("#hida5").val() == "") {
        $("#hida5").val("0");
    }

    if ($("#hida1").val() == "") {
        $("#hida1").val("0");
        if (parseFloat(hidSumPrice) > 0)
            $("#checkId #a1 a.check").click();

        $("#txtPrice").val(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? txtPayOrder : hidSumPrice);
        $("#lblPrice1").html(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? txtPayOrder : hidSumPrice);
        $("#lblPrice2").html(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? "0.00" : parseFloat(parseFloat(txtPayOrder) - parseFloat(hidSumPrice)).toFixed(2));
        $("#lblPrice3").html(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? "0.00" : parseFloat(parseFloat(txtPayOrder) - parseFloat(hidSumPrice)).toFixed(2));
        $("#lblPrice5").html(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? "0.00" : parseFloat(parseFloat(txtPayOrder) - parseFloat(hidSumPrice)).toFixed(2));


        //支付手续费 -start 
        Js_sxf(parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? "0.00" : parseFloat(txtPayOrder) - parseFloat(hidSumPrice), parseFloat(hidSumPrice) > parseFloat(txtPayOrder) ? "0.00" : parseFloat(txtPayOrder) - parseFloat(hidSumPrice));
        //支付手续费 -end 




    }

});


//手续费计算公用方法
function Js_sxf(kjzf_price, wyzf_price) {

    var bankCode = $("#hidBank").val() == "" ? "0" : $("#hidBank").val();

    //快捷支付金额
    var a2zfje = kjzf_price;
    //网银支付金额
    var a3zfje = wyzf_price;
    //支付宝微信支付金额
    var a5zfje=wyzf_price;

    //账户类型
    var hid_PayType = $("#hid_PayType").val();

    //快捷支付--判断手续费 
    var a2_price = 0.00;
    if ($("#hida2").val() == "1") {
        if (a2zfje > 0) {
            var a2_sxf = a2zfje * parseFloat($("#pay_kjzfbl").val()).toFixed(3); //比例
            
            //var kjzfstart = parseFloat($("#pay_kjzfstart").val()).toFixed(2); //封底
           // var kjzfend = parseFloat($("#pay_kjzfend").val()).toFixed(2); //封顶

           // if (a2_sxf <= kjzfstart)
            //    a2_price = kjzfstart;
           // else if (a2_sxf >= kjzfend)
            //    a2_price = kjzfend;
           // else
                a2_price = a2_sxf;
        } else {
            $("#lblPrice2_sxf").html("0.00"); //快捷支付手续费赋值
        }
    }

    //网银支付
    var a3_price = 0.00;
    if ($("#hida3").val() == "1") {
        if (a3zfje > 0) {        
            var pay_b2cwyzfstart = parseFloat($("#pay_b2cwyzfstart").val());
            if (hid_PayType == "12") //企业账户
                a3_price = parseFloat(parseFloat($("#pay_b2bwyzf").val()).toFixed(2));        
                //个人账户贷记卡
            else if (hid_PayType == "13"){
                a3_price = parseFloat((a3zfje * parseFloat($("#pay_b2cwyzfbl").val())).toFixed(3));
                if (a3_price < pay_b2cwyzfstart)
                    a3_price = pay_b2cwyzfstart;
            }
            else { //个人账户           
                //网银支付
                a3_price = parseFloat((a3zfje * parseFloat($("#pay_b2cwyzfbl").val())).toFixed(3));
                if (a3_price < pay_b2cwyzfstart)
                    a3_price = pay_b2cwyzfstart;
            }
        }
        else
            $("#lblPrice3_sxf").html("0.00");
    }

    //微信、支付宝手续费计算
    a5_price = 0.00;
    if ($("#hida5").val() == "1") {
        a5_price = parseFloat((a5zfje * parseFloat($("#pay_b2cwyzfbl").val())).toFixed(3));
        if (a5_price < pay_b2cwyzfstart)
            a5_price = pay_b2cwyzfstart;    
    }

    $("#lblPrice2_sxf").html(parseFloat(a2_price).toFixed(2)); //快捷支付手续费赋值
    $("#lblPrice3_sxf").html(parseFloat(a3_price).toFixed(2)); //网银支付手续费赋值
    $("#lblPrice5_sxf").html(parseFloat(a5_price).toFixed(2)); //微信支付宝手续费赋值
    

    //计算总金额
    if ($("#hida2").val() == "1") {
        $("#sumje").html((parseFloat(kjzf_price) + parseFloat(a2_price)).toFixed(2));

        if ((parseFloat(kjzf_price)) == 0)
            $("#sum_payprice").hide();
        else
            $("#sum_payprice").show();
    }
    else if ($("#hida3").val() == "1") {
        $("#sumje").html(parseFloat(a3_price + parseFloat(wyzf_price)).toFixed(2));
        if ((parseFloat(wyzf_price)) == 0)
            $("#sum_payprice").hide();
        else
            $("#sum_payprice").show();
    }//微信、支付宝
    else if ($("#hida5").val() == "1") {
        $("#sumje").html((parseFloat(a5zfje)+parseFloat(a5_price)).toFixed(2));
        if ((parseFloat(a5zfje)) == 0)
            $("#sum_payprice").hide();
        else
            $("#sum_payprice").show();

    }
    else {
        $("#sumje").html("0.00");
        $("#sum_payprice").hide();
    }
}

//身份证校验方法
function validateIdCard(idCard) {
    //15位和18位身份证号码的正则表达式
    var regIdCard = /^(^[1-9]\d{7}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}$)|(^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])((\d{4})|\d{3}[Xx])$)$/;
    //如果通过该验证，说明身份证格式正确，但准确性还需计算
    if (regIdCard.test(idCard)) {
        if (idCard.length == 18) {
            var idCardWi = new Array(7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2); //将前17位加权因子保存在数组里
            var idCardY = new Array(1, 0, 10, 9, 8, 7, 6, 5, 4, 3, 2); //这是除以11后，可能产生的11位余数、验证码，也保存成数组
            var idCardWiSum = 0; //用来保存前17位各自乖以加权因子后的总和
            for (var i = 0; i < 17; i++) {
                idCardWiSum += idCard.substring(i, i + 1) * idCardWi[i];
            }
            var idCardMod = idCardWiSum % 11; //计算出校验码所在数组的位置
            var idCardLast = idCard.substring(17); //得到最后一位身份证号码
            //如果等于2，则说明校验码是10，身份证号码最后一位应该是X
            if (idCardMod == 2) {
                if (idCardLast == "X" || idCardLast == "x") {
                    //alert("恭喜通过验证啦！");
                    return true;
                } else {
                    //alert("身份证号码错误！");
                    return false;
                }
            } else {
                //用计算出的验证码与最后一位身份证号码匹配，如果一致，说明通过，否则是无效的身份证号码
                if (idCardLast == idCardY[idCardMod]) {
                    //alert("恭喜通过验证啦！");
                    return true;
                } else {
                    //alert("身份证号码错误！");
                    return false;
                }
            }
        }
    } else {
        //alert("身份证格式不正确!");
        return false;
    }
}

//屏蔽右键
document.oncontextmenu = new Function("event.returnValue=false;");

//document.onselectstart = new Function("event.returnValue=false;");

//alert("111111");
//alert(window.history);
//alert(window.history.pushState);
/*
if (window.history && window.history.pushState) {
// alert("22222");
$(window).on('popstate', function () {
var hashLocation = location.hash;
var hashSplit = hashLocation.split("#!/");
var hashName = hashSplit[1];
if (hashName !== '') {
var hash = window.location.hash;
if (hash === '') {
window.history.pushState('forward', null, window.location.href);
}
}
});
window.history.pushState('forward', null, window.location.href);
}
*/