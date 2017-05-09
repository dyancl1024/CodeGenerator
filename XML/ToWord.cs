using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using ReaderPDM.PDM;
using System.Collections;

namespace ReaderPDM.XML
{
    public class ToWord
    {
        /// <summary>
        /// 基于TableInfo实体类数组的导出
        /// </summary>
        /// <param name="paramTableInfoList">TableInfo[] 实体数组</param>
        /// <param name="paramFileName">导出的文件名（不包含后缀）</param>
        public void ExportWord(TableInfo[] paramTableInfoList, string paramFileName)
        {
            ///paramFileName缺省值为 Table清单
            if (paramFileName.Equals(""))
            {
                paramFileName = "Table清单";
            }

            StringBuilder curBuilder = new StringBuilder();
            if (paramTableInfoList != null && paramTableInfoList.Length > 0)
            {

                InitHeader(ref curBuilder, paramFileName);

                for (int i = 0; i < paramTableInfoList.Length; i++)
                {
                    InitDaily(paramTableInfoList[i], ref curBuilder);
                }

                EndExport(ref curBuilder, paramFileName);
            }

        }

        /// <summary>
        /// 基于Hashtable实体类键值对的导出Table到Excel
        /// </summary>
        /// <param name="curHt">Hashtable</param>
        /// <param name="paramFileName">导出的文件名（不包含后缀）</param>
        public void ExportWord(Hashtable curHt, string paramFileName)
        {
            ///paramFileName缺省值为 Table清单
            if (paramFileName.Equals(""))
            {
                paramFileName = "Table清单";
            }

            StringBuilder curBuilder = new StringBuilder();
            if (curHt != null && curHt.Count > 0)
            {

                InitHeader(ref curBuilder, paramFileName);

                foreach (System.Collections.DictionaryEntry item in curHt)
                {
                    //       item.Key.ToString();//键
                    //item.Value.ToString();//值
                    InitDaily((TableInfo)item.Value, ref curBuilder);
                }

                EndExport(ref curBuilder, paramFileName);
            }
        }

        private void EndExport(ref StringBuilder sb, string flieName)
        {
            sb.Append("</body>\n");
            sb.Append("</html>");
            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.Buffer = true;
            System.Web.HttpContext.Current.Response.ContentType = "application/ms-excel";
            System.Web.HttpContext.Current.Response.Charset = "GB2312";
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            flieName = System.Web.HttpUtility.UrlEncode(flieName, System.Text.Encoding.UTF8);
            System.Web.HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + flieName + ".xls");
            System.Web.HttpContext.Current.Response.Write(sb.ToString());
            System.Web.HttpContext.Current.Response.End();
        }

        private StringBuilder InitHeader(ref StringBuilder sb, string flieName)
        {
            sb.Append("<html xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:x='urn:schemas-microsoft-com:office:excel' xmlns='http://www.w3.org/TR/REC-html40'>\n");
            sb.Append("<head >\n");
            sb.Append("<meta http-equiv='Content-Type', content='text/html; charset=gb2312' /> \n");
            sb.Append("<style>");
            sb.Append("* { font:9pt Verdana; }");
            sb.Append("table,form,div,td {font-size: 10pt; font-family:Verdana;border:0;margin:0 auto; padding:0 auto;border-collapse:collapse;border:0px;} ");
            sb.Append(".print_table { BORDER-RIGHT: #000000 2px solid; BORDER-TOP: #000000 2px solid; BORDER-LEFT: #000000 2px solid; BORDER-BOTTOM: #000000 2px solid; BORDER-COLLAPSE: collapse}");
            sb.Append(".print_table_top { BORDER-RIGHT: #000000 2px solid; BORDER-TOP: #000000 2px solid; BORDER-LEFT: #000000 2px solid; BORDER-COLLAPSE: collapse}");
            sb.Append(".print_table_middle { BORDER-RIGHT: #000000 2px solid; BORDER-LEFT: #000000 2px solid; BORDER-COLLAPSE: collapse}");
            sb.Append(".print_table_bottom { BORDER-RIGHT: #000000 2px solid; BORDER-LEFT: #000000 2px solid; BORDER-BOTTOM: #000000 2px solid; BORDER-COLLAPSE: collapse}");
            sb.Append(".print_cell_topbottom {  BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle;  BORDER-BOTTOM: #000000 1px solid; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cell { BORDER-RIGHT: #000000 1px solid; BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle; BORDER-LEFT: #000000 1px solid; BORDER-BOTTOM: #000000 1px solid; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cells {  BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle;  BORDER-BOTTOM: #000000 1px solid; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cell_left { BORDER-RIGHT: #000000 1px solid; BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle; BORDER-BOTTOM: #000000 1px solid; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cell_right { BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle; BORDER-LEFT: #000000 1px solid; BORDER-BOTTOM: #000000 1px solid; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cell_top { BORDER-RIGHT: #000000 1px solid; VERTICAL-ALIGN: middle; BORDER-LEFT: #000000 1px solid; BORDER-BOTTOM: #000000 1px solid; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cell_bottom { BORDER-RIGHT: #000000 1px solid; BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle; BORDER-LEFT: #000000 1px solid; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cell_leftbottom { BORDER-RIGHT: #000000 1px solid; BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cell_rightbottom { BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle; BORDER-LEFT: #000000 1px solid; BORDER-COLLAPSE: collapse;}");
            sb.Append(".print_cell_righttop { BORDER-TOP: #000000 1px solid; VERTICAL-ALIGN: middle; BORDER-LEFT: #000000 1px solid; BORDER-BOTTOM: #000000 1px solid; BORDER-RIGHT: #000000 1px solid; BORDER-COLLAPSE: collapse;}");

            sb.Append(".print_title { FONT-WEIGHT: normal; FONT-SIZE:20pt; FONT-FAMILY:宋体; TEXT-ALIGN: center;font:bold;}");
            sb.Append("</style>");
            sb.Append("<!--[if gte mso 9]>");
            sb.Append("<xml>");
            sb.Append(" <x:ExcelWorkbook>");
            sb.Append("  <x:ExcelWorksheets>");
            sb.Append("   <x:ExcelWorksheet>");
            sb.Append("    <x:Name>" + flieName + "</x:Name>");
            sb.Append("    <x:WorksheetOptions>");
            sb.Append("      <x:Print>");
            sb.Append("       <x:ValidPrinterInfo />");
            sb.Append("      </x:Print>");
            sb.Append("    </x:WorksheetOptions>");
            sb.Append("   </x:ExcelWorksheet>");
            sb.Append("  </x:ExcelWorksheets>");
            sb.Append("</x:ExcelWorkbook>");
            sb.Append("</xml>");
            sb.Append("<![endif]-->");
            sb.Append("</head>\n");
            sb.Append("<body>\n");

            return sb;

        }

        private StringBuilder InitDaily(TableInfo curTableInfo, ref StringBuilder sb)
        {
            sb.Append("<table width=\"100%\" class=\"print_table\" cellpadding=\"0\" cellspacing=\"0\">");
            sb.Append("<tr align=\"center\"  style=\"height: 35px;\">");
            sb.Append("<td colspan=\"6\" width=\"100%\" class=\"print_title\" Style=\"font-size: 18pt\">" + curTableInfo.Name + "(" + curTableInfo.Code + ")" + "</td>");
            sb.Append("</tr>");
            sb.Append("<tr align=\"center\"  style=\"height: 35px;background:#B7B4B4 \"> ");
            sb.Append("<td width=\"7%\" class=\"print_cell\">字段中文名称</td>");
            sb.Append("<td width=\"7%\" class=\"print_cell\">字段标识</td>");
            sb.Append("<td width=\"30%\" class=\"print_cell\">字段类型</td>");
            sb.Append("<td width=\"15%\" class=\"print_cell\">是否主键</td>");
            sb.Append("<td width=\"7%\" class=\"print_cell\">是否必填</td>");
            sb.Append("<td width=\"18%\" class=\"print_cell\">备注</td>");
            sb.Append("</tr>");

            if (curTableInfo != null && curTableInfo.Columns.Count > 0)
            {
                for (int i = 0; i < curTableInfo.Columns.Count; i++)
                {
                    sb.Append("<tr  style=\"height: 35px;\">");
                    sb.Append("<td class='print_cell' align='left' style='font-size: 9pt'>" + curTableInfo.Columns[i].Name + "</td>");
                    sb.Append("<td class='print_cell' align='center' style='font-size: 9pt'>" + curTableInfo.Columns[i].Code + "</td>");
                    sb.Append("<td class='print_cell' align='center' style='font-size: 9pt'>" + curTableInfo.Columns[i].DataType + "</td>");
                    sb.Append("<td class='print_cell' align='center' style='font-size: 9pt'>" + "" + "</td>");
                    sb.Append("<td class='print_cell' align='center' style='font-size: 9pt'>" + curTableInfo.Columns[i].Mandatory + "</td>");
                    sb.Append("<td class='print_cell' align='center' style='font-size: 9pt'>" + curTableInfo.Columns[i].Comment + "</td>");
                    sb.Append("</tr>");
                }

            }
            sb.Append("</table><br/>");

            return sb;
        }
    }
}
