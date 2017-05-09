using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReaderPDM.PDM;
using System.Text;

namespace ReaderPDM
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            PdmReader curPdmReader = new PdmReader("C:\\Documents and Settings\\Administrator\\桌面\\房屋建筑物类.PDM");
            curPdmReader.InitData();

            lblTableCount.Text = "<span style=\"color:Blue\">表数量 :</span>&nbsp;&nbsp;" + curPdmReader.Tables.Count;

            StringBuilder curTableInfo = new StringBuilder();
            try
            {
                for (int i = 0; i < curPdmReader.Tables.Count; i++)
                {
                    curTableInfo.Append(" <br/>");
                    curTableInfo.Append("<span style=\"color:Blue\"> 表名称 :</span>&nbsp;&nbsp;" + curPdmReader.Tables[i].Name);
                    curTableInfo.Append("&nbsp;&nbsp;<span style=\"color:Blue\"> 表编码 :</span>&nbsp;&nbsp;" + curPdmReader.Tables[i].Code);
                    curTableInfo.Append("&nbsp;&nbsp;<span style=\"color:Blue\"> 表包含字段数量:</span>&nbsp;&nbsp;" + curPdmReader.Tables[i].Columns.Count);
                    //curTableInfo.Append("&nbsp;&nbsp;<span style=\"color:Blue\"> 主键:</span>&nbsp;&nbsp;" + curPdmReader.Tables[i].Keys.Count);

                    foreach (ColumnInfo col in curPdmReader.Tables[i].Columns)
                    {
                        curTableInfo.Append(" <br/>");
                        curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> 字段名 :</span>&nbsp;&nbsp;" + col.Name);
                        curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> 字段编码 :</span>&nbsp;&nbsp;" + col.Code);
                        curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> 字段类型 :</span>&nbsp;&nbsp;" + col.DataType);
                        curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> 字段类型长度 :</span>&nbsp;&nbsp;" + col.Length);
                        curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> 是否自增长 :</span>&nbsp;&nbsp;" + col.Identity);
                        curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> 是否可空 :</span>&nbsp;&nbsp;" + col.Mandatory);

                    }

                    try
                    {
                        foreach (PdmKey key in curPdmReader.Tables[i].Keys)
                        {
                            curTableInfo.Append(" <br/>");
                            curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> Key名 :</span>&nbsp;&nbsp;" + key.Name);
                            curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> Key编码 :</span>&nbsp;&nbsp;" + key.Code);
                            curTableInfo.Append(" &nbsp;&nbsp;&nbsp;&nbsp; <span style=\"color:Blue\"> Key Id :</span>&nbsp;&nbsp;" + key.KeyId);
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('i=" + i + ")</script>");
                    }
                }

                lblTableInfo.Text = curTableInfo.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
