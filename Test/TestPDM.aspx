<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPDM.aspx.cs" Inherits="ReaderPDM.Test.TestPDM" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../js/jquery-1.7.2.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        function fuDoExport() {
            document.getElementById("btnExport").click();
            setCheckNull();
        }

        function setCheckNull() {

            //            $("#btn").attr('disabled',true);//导出Excel按钮置为不可用
            //            var objs = $("#tvXML").find(":checkbox:checked").removeAttr("checked"); //checkbox设置为为选择状态

            //            $.each(objs, function() {
            //            });

        }

        //        $(document).ready(function() {

        //            $('#chb').click(function() {
        //                alert("ooook");
        //                if ($("#chb").attr("checked") == true) {
        //                    $("#tvXML").find(":checkbox:checked").attr("checked") = true;
        //                }
        //                else {
        //                    $("#tvXML").find(":checkbox:checked").removeAttr("checked");
        //                }
        //            });

        //        });

        //            function fuCheck() {
        //                var ii = $("#chb").attr("checked");
        //                if ($("#chb").attr("checked") == true) {
        //                    $("#tvXML").find(":checkbox").attr("checked") = true;
        //                }
        //                else {
        //                    $("#tvXML").find(":checkbox:checked").removeAttr("checked");
        //                }

        //            }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblPDM" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblTable" runat="server"></asp:Label>
        <span style="color: Red"></span>
    </div>
    =======================================================================================
    <br />
    &nbsp;正/反选&nbsp;
    <input type="checkbox" id="chb1" title="正/反选" onclick="fuCheck()" />
    <asp:TreeView ID="tvXML" runat="server" ShowCheckBoxes="Root" ShowLines="true">
    </asp:TreeView>
    <br />
    =======================================================================================
    <br />
    命名空间：<asp:TextBox ID="txtNameSpace" runat="server" Text="RH.Training"></asp:TextBox><br />
    文件前缀：<asp:TextBox ID="txtPrefix" runat="server"></asp:TextBox>多种情况逗号分割。如: RH_,TR_
    处理前缀为RH_XXX和RH_TR_XXX的情况，顺序很重要
    <br />
    <asp:Button ID="btnFormatXML" runat="server" Text="生成XML" OnClick="btnFormatXML_Click" />
    &nbsp;
    <asp:Button ID="btnCreateXML" runat="server" Text="批量生成XML模版" OnClick="btnCreatetXML_Click" />&nbsp;
    <asp:Button ID="btnCreateCode" runat="server" Text="生成代码" OnClick="btnCreateCode_Click" />&nbsp;
    <input type="button" runat="server" value="导出Excel" onclick="fuDoExport()" id="btn" />
    <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" />&nbsp;
    <asp:Button ID="btnRefresh" runat="server" Text="刷新" OnClick="btnRefresh_Click" />
    <asp:Button ID="btnTest" runat="server" Text="测试" OnClick="btnTest_Click" />
    <br />
    =======================================================================================
    </form>
</body>
</html>
<script type="text/javascript">
    $(document).ready(function () {
        $("#btnExport").hide();
    });
    function fuCheck() {
        var ii = $("#chb1").attr("checked");
        if ($("#chb1").attr("checked")) {
            $("#tvXML").find(":checkbox").attr("checked", true);
        }
        else {
            $("#tvXML").find(":checkbox:checked").removeAttr("checked");
        }

    }
</script>
