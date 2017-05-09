<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="text" encoding="utf-8"/>

  <xsl:variable name="pageTypeName" select="'编辑'" />
  <xsl:variable name="pageTypeStrName" select="'Edit'" />
  <xsl:variable name="pageTypeEntity" select="'Entity'" />
  <xsl:variable name="pageTypeLogic" select="'Logic'" />
  <xsl:variable name="properties" select="/tables/table/column"/>
  <xsl:variable name="pk" select="/tables/table/column[@PK!=''][1]/@ShowCode"/>
  <xsl:variable name="properties_no_null" select="/tables/table/column[@Mandatory='True']"/>

  <xsl:preserve-space elements="*"/>
  <xsl:template match="/">
    <xsl:apply-templates select="tables"/>
  </xsl:template>

  <!--匹配tables元素 -->
  <xsl:template match="tables">
    <xsl:apply-templates select="table"/>
  </xsl:template>

  <!--匹配bean元素，实际代码生成在此完成-->
  <xsl:template match="table">
    <xsl:text disable-output-escaping="yes">using System;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Web.UI;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Web.UI.WebControls;&#xD;&#xA;</xsl:text>
    <xsl:text>using </xsl:text>
    <xsl:value-of select="@namespace"/>
    <xsl:text>.</xsl:text>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;using </xsl:text>
    <xsl:value-of select="@namespace"/>
    <xsl:text>.</xsl:text>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>public partial class </xsl:text>
    <xsl:value-of select="$pageTypeStrName"/>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes"> : AdminBasePage&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">{&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    //private static ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    protected void Page_Load(object sender, EventArgs e)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        if (!this.Page.IsPostBack)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            this.menu_id = PageUtils.filterSQL(base.Request.QueryString["menu_id"]);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            this.sid = PageUtils.filterSQL(base.Request.QueryString["sid"]);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            InitBasicOption();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            InitPageData();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            this.btnSave.Attributes.Add("onclick", "javascript:if(!funCheckForm()) return false;");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// 初始化页面基本信息&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    private void InitBasicOption()&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    {&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// 绑定记录信息&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    private void InitPageData()&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        //查找当前记录&#xD;&#xA;        </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text> cur</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;        </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> cur</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;        cur</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text>.</xsl:text>
    <xsl:value-of select="$pk"/>
    <xsl:text disable-output-escaping="yes"> = this.sid;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        try&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            //查找信息&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            cur</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> = cur</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text>.Find</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>ByPK(null, cur</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            if(cur</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes"> != null)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">               //设置页面数据&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">               this.PutDataToPage(cur</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            else&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">               lblErrMsg.Text = "</xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text disable-output-escaping="yes">不存在";&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">               return;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        catch(Exception ex)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            lblErrMsg.Text="查找信息时出现错误:" + ex.Message.ToString();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;&#xD;&#xA;</xsl:text>

    <xsl:call-template name="printPutDataToPage"/>
    <xsl:call-template name="printValidateForm"/>
    <xsl:call-template name="printReceiveDataFormPage"/>
    <xsl:call-template name="printModifyMethod"/>

    <xsl:call-template name="printViewState">
      <xsl:with-param name="code">menu_id</xsl:with-param>
      <xsl:with-param name="describe">菜单信息ID</xsl:with-param>
    </xsl:call-template>
    <xsl:call-template name="printViewState">
      <xsl:with-param name="code">sid</xsl:with-param>
      <xsl:with-param name="describe">主键信息</xsl:with-param>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">}&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template name="printPutDataToPage">
    <xsl:text disable-output-escaping="yes">    /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// 设置页面数据&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;param name="param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">"&gt;</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">&lt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    private void PutDataToPage(</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        if(param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes"> != null)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        {&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:text disable-output-escaping="yes">           txt</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text>.Text = param</xsl:text>
      <xsl:value-of select="/tables/table/@ShowCode"/>
      <xsl:value-of select="$pageTypeEntity"/>
      <xsl:text>.</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text disable-output-escaping="yes">.ToString();&#xD;&#xA;</xsl:text>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template name="printValidateForm">
    <xsl:text disable-output-escaping="yes">    /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// 校验数据&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    private bool ValidateForm()&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       bool bIsValid = true;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties_no_null">
      <xsl:text>       if(txt</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text>.Text == null || "".Equals(txt</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text disable-output-escaping="yes">.Text.Trim()))&#xD;&#xA;</xsl:text>
      <xsl:text disable-output-escaping="yes">       {&#xD;&#xA;</xsl:text>
      <xsl:text disable-output-escaping="yes">          bIsValid = false;&#xD;&#xA;</xsl:text>
      <xsl:text disable-output-escaping="yes">          lblErrMsg.Text = "</xsl:text>
      <xsl:value-of select="@Name"/>
      <xsl:text disable-output-escaping="yes">不能为空";&#xD;&#xA;</xsl:text>
      <xsl:text disable-output-escaping="yes">       }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">       return bIsValid;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template name="printReceiveDataFormPage">
    <xsl:text disable-output-escaping="yes">    /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// 从页面Form中获取实体信息&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;returns type="</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">"&gt;cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    private </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> ReceiveDataFormPage(</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    {&#xD;&#xA;          </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> = param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;          if(param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes"> == null)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">             cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          }&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:text>          cur</xsl:text>
      <xsl:value-of select="/tables/table/@ShowCode"/>
      <xsl:value-of select="$pageTypeEntity"/>
      <xsl:text>.</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:choose>
        <xsl:when test="contains(@DataType,'int')">
          <xsl:text> = int.Parse(PageUtils.filterSQL(txt</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">.Text.Trim()));&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:when test="contains(@DataType,'long')">
          <xsl:text> = long.Parse(PageUtils.filterSQL(txt</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">.Text.Trim()));&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:when test="contains(@DataType,'float')">
          <xsl:text> = float.Parse(PageUtils.filterSQL(txt</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">.Text.Trim()));&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:when test="contains(@DataType,'decimal')">
          <xsl:text> = decimal.Parse(PageUtils.filterSQL(txt</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">.Text.Trim()));&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:when test="contains(@DataType,'datetime')">
          <xsl:text> = DateTime.Parse(PageUtils.filterSQL(txt</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">.Text.Trim()));&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:when test="contains(@DataType,'image')">
          <xsl:text> = (byte[])PageUtils.filterSQL(txt</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">.Text.Trim()));&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:text> = PageUtils.filterSQL(txt</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">.Text.Trim());&#xD;&#xA;</xsl:text>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>
    <xsl:text>          return cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;    }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template name="printModifyMethod">
    <xsl:text disable-output-escaping="yes">    /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// 编辑按钮处理事件&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;param name="sender"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;param name="e"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    protected void btnModify_Click(object sender, EventArgs e)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    {&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       //数据校验&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       if(!ValidateForm())&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          return;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       try&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       {&#xD;&#xA;          </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text> cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;          </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> old</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;          old</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text>.</xsl:text>
    <xsl:value-of select="$pk"/>
    <xsl:text disable-output-escaping="yes"> = PageUtils.filterSQL(this.sid);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          //查找原来的信息&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          old</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> = cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text>.Find</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text disable-output-escaping="yes">ByPK(null, old</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          if(old</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes"> != null)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">             //从页面获取数据&#xD;&#xA;             </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> = ReceiveDataFormPage(old</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">             //修改信息&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">             cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeLogic"/>
    <xsl:text>.Modify</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>(null, cur</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">             lblErrMsg.Text = "编辑成功";</xsl:text>
    <xsl:text disable-output-escaping="yes">          }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          else&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">             //正在修改的信息不存在&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">             lblErrMsg.Text="修改的信息不存在，可能已经被删除。";&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       catch (Exception ex)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          lblErrMsg.Text="编辑信息失败:" + ex.Message.ToString();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template name="printViewState">
    <xsl:param name="code"></xsl:param>
    <xsl:param name="describe"></xsl:param>
    <xsl:text disable-output-escaping="yes">    /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// </xsl:text>
    <xsl:value-of select="$describe"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    protected string </xsl:text>
    <xsl:value-of select="$code"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;    {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       get&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          if(this.ViewState["</xsl:text>
    <xsl:value-of select="$code"/>
    <xsl:text disable-output-escaping="yes">"] == null)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">             return "";&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">          return this.ViewState["</xsl:text>
    <xsl:value-of select="$code"/>
    <xsl:text disable-output-escaping="yes">"].ToString();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       set&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">           this.ViewState["</xsl:text>
    <xsl:value-of select="$code"/>
    <xsl:text disable-output-escaping="yes">"] = value;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">       }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>
</xsl:stylesheet>
