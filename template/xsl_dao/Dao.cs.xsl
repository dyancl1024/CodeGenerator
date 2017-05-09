<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:variable name="pageTypeName" select="'数据访问层'" />
  <xsl:variable name="pageTypeStrName" select="'Dao'" />
  <xsl:variable name="pageTypeEntityName" select="'Entity'" />
  <xsl:variable name="pageTypeMapUtil" select="'MapUtil'" />

  <!--操作方法-->
  <xsl:variable name="type_add" select="'添加'"></xsl:variable>
  <xsl:variable name="type_modify" select="'修改'"></xsl:variable>
  <xsl:variable name="type_removed" select="'删除'"></xsl:variable>
  <xsl:variable name="type_select" select="'查看'"></xsl:variable>
  <xsl:variable name="type_select_pk" select="'根据外键查找'"></xsl:variable>
  <xsl:variable name="type_select_all" select="'查看全部'"></xsl:variable>

  <!-- 代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:output method="text"/>
  <xsl:variable name="properties" select="/tables/table/column"/>
  <xsl:variable name="properties_fk" select="/tables/table/column[@FK!='']"/>
  <xsl:variable name="properties_pk" select="/tables/table/column[@PK!='']"/>
  <xsl:variable name="hasFK" select="/tables/table/@hasFK"/>
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
    <xsl:text disable-output-escaping="yes">using System.Text;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Data.SqlClient;&#xD;&#xA;using </xsl:text>
    <xsl:value-of select="@namespace"/>.<xsl:value-of select="$pageTypeEntityName"/><xsl:text disable-output-escaping="yes">;&#xD;&#xA;using </xsl:text>
    <xsl:value-of select="@namespace"/>.<xsl:value-of select="$pageTypeMapUtil"/><xsl:text disable-output-escaping="yes">;&#xD;&#xA;&#xD;&#xA;</xsl:text>

    <xsl:text>namespace </xsl:text>
    <!--输出包名-->
    <xsl:value-of select="@namespace"/>
    <xsl:text>.</xsl:text>
    <xsl:value-of select="$pageTypeStrName"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;{&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printNoteHead">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
      <xsl:with-param name="code" select="@Code"/>
    </xsl:call-template>
    <xsl:text>    public class </xsl:text>
    <!--输出JavaBean类名-->
    <xsl:value-of select="@ShowCode"/>
    <xsl:copy-of select="$pageTypeStrName"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;    {&#xD;&#xA;</xsl:text>

    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Insert"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Update"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Delete"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_View"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Query"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Map"/>
    <!--输出基本方法-->

    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;}</xsl:text>
  </xsl:template>

  <!--输出新增方法-->
  <xsl:template name="printDefaultMethods_Insert">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
      <xsl:with-param name="code" select="@Code"/>
      <xsl:with-param name="type" select="$type_add"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="void"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public void Insert(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>

    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            SqlCommand m_sqlCmd = null;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            StringBuilder strBuilder = new StringBuilder("");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            //SQL变量&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            String strSQL = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //以下生成SQL语句&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("  insert into </xsl:text>
    <xsl:value-of select="/tables/table/@Code"/>
    <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("  (");&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:text disable-output-escaping="yes">                strBuilder.Append("    </xsl:text>
      <xsl:value-of select="@Code"/>
      <xsl:choose>
        <xsl:when test="position()&lt;last()">
          <xsl:text disable-output-escaping="yes">,");&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>

    <xsl:text disable-output-escaping="yes">                strBuilder.Append("  )");&#xD;&#xA;                strBuilder.Append("     values ");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("  (");&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:text disable-output-escaping="yes">                strBuilder.Append("    @</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:choose>
        <xsl:when test="position()&lt;last()">
          <xsl:text disable-output-escaping="yes">,");&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("  )");&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printExecuteSql"></xsl:call-template>
    <xsl:text disable-output-escaping="yes">                /////参数赋值&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printAddParamValue"/>
    <xsl:text disable-output-escaping="yes">                //执行数据库操作&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                m_sqlCmd.ExecuteNonQuery();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放SqlCommand&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>

  </xsl:template>

  <!--输出修改方法-->
  <xsl:template name="printDefaultMethods_Update">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
      <xsl:with-param name="code" select="@Code"/>
      <xsl:with-param name="type" select="$type_modify"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="void"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public void Update(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            SqlCommand m_sqlCmd = null;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            StringBuilder strBuilder = new StringBuilder("");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            //SQL变量&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            String strSQL = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //以下生成SQL语句&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("  update </xsl:text>
    <xsl:value-of select="/tables/table/@Code"/>
    <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("  set ");&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK"/>
      <xsl:if test="position()&lt;last()">
        <xsl:text disable-output-escaping="yes">                strBuilder.Append("    </xsl:text>
        <xsl:value-of select="@Code"/>
        <xsl:text>=@</xsl:text>
        <xsl:value-of select="@ShowCode"/>
        <xsl:choose>
          <xsl:when test="position()&lt;last()-1">
            <xsl:text disable-output-escaping="yes">,");&#xD;&#xA;</xsl:text>
          </xsl:when>
          <xsl:otherwise>
            <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
          </xsl:otherwise>
        </xsl:choose>
      </xsl:if>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("  where ");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("    </xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK"/>
      <xsl:if test="position()=last()">
        <xsl:value-of select="@Code"/>
        <xsl:text>=@</xsl:text>
        <xsl:value-of select="@ShowCode"/>
        <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
      </xsl:if>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printExecuteSql"></xsl:call-template>
    <xsl:text disable-output-escaping="yes">                /////参数赋值&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printAddParamValue"/>
    <xsl:text disable-output-escaping="yes">                //执行数据库操作&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                m_sqlCmd.ExecuteNonQuery();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放SqlCommand&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>

  </xsl:template>

  <!--输出删除方法-->
  <xsl:template name="printDefaultMethods_Delete">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
      <xsl:with-param name="code" select="@Code"/>
      <xsl:with-param name="type" select="$type_removed"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="void"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public void Delete(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>

    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            SqlCommand m_sqlCmd = null;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            StringBuilder strBuilder = new StringBuilder("");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            //SQL变量&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            String strSQL = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //以下生成SQL语句&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append(" delete from </xsl:text>
    <xsl:value-of select="/tables/table/@Code"/>
    <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append(" where ");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("    </xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK"/>
      <xsl:if test="position()=last()">
        <xsl:value-of select="@Code"/>
        <xsl:text>=@</xsl:text>
        <xsl:value-of select="@ShowCode"/>
        <xsl:text disable-output-escaping="yes">");&#xD;&#xA;&#xD;&#xA;</xsl:text>
        <xsl:call-template name="printExecuteSql"></xsl:call-template>
        <xsl:text disable-output-escaping="yes">                /////参数赋值&#xD;&#xA;&#xD;&#xA;</xsl:text>
        <xsl:call-template name="printAddParamValue">
          <xsl:with-param name="code" select="@Code"></xsl:with-param>
        </xsl:call-template>
      </xsl:if>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">                //执行数据库操作&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                m_sqlCmd.ExecuteNonQuery();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放SqlCommand&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>

  </xsl:template>

  <!--输出查看详情方法-->
  <xsl:template name="printDefaultMethods_View">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
      <xsl:with-param name="code" select="@Code"/>
      <xsl:with-param name="type" select="$type_select"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes">"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text> SelectByPK(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            SqlCommand m_sqlCmd = null;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            StringBuilder strBuilder = new StringBuilder("");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            //SQL变量&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            String strSQL = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DataTable objDataTable = new DataTable();&#xD;&#xA;&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text> </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes"> = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //以下生成SQL语句&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append(" select ");&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:text>                strBuilder.Append("   </xsl:text>
      <xsl:if test="$hasFK='True'">
        <xsl:value-of select="/tables/table/@ShowCode"/>
        <xsl:text>.</xsl:text>
      </xsl:if>
      <xsl:value-of select="@Code"/>
      <xsl:text> AS </xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:choose>
        <xsl:when test="position()&lt;last()">
          <xsl:text disable-output-escaping="yes">,");&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>
    <xsl:text>                strBuilder.Append(" from </xsl:text>
    <xsl:value-of select="/tables/table/@Code"/>
    <xsl:if test="$hasFK='True'">
      <xsl:text> </xsl:text>
      <xsl:value-of select="/tables/table/@ShowCode"/>
    </xsl:if>
    <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties_fk">
      <xsl:text disable-output-escaping="yes">                strBuilder.Append(" left join </xsl:text>
      <xsl:value-of select="@FK_T_Code"/>
      <xsl:text> AS </xsl:text>
      <xsl:value-of select="@FK_T_ShowCode"/>
      <xsl:text> ON </xsl:text>
      <xsl:value-of select="/tables/table/@ShowCode"/>
      <xsl:text>.</xsl:text>
      <xsl:value-of select="@Code"/>
      <xsl:text> = </xsl:text>
      <xsl:value-of select="@FK_T_ShowCode"/>
      <xsl:text>.</xsl:text>
      <xsl:value-of select="@FK_Col_Code"/>
      <xsl:text disable-output-escaping="yes"> ");&#xD;&#xA;</xsl:text>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append("   where 1=1 ");&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties_pk[1]">
      <xsl:text>                strBuilder.Append("   AND </xsl:text>
      <xsl:if test="$hasFK='True'">
        <xsl:value-of select="/tables/table/@ShowCode"/>
        <xsl:text>.</xsl:text>
      </xsl:if>
      <xsl:value-of select="@Code"/>
      <xsl:text>=@</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text disable-output-escaping="yes"> ");&#xD;&#xA;&#xD;&#xA;</xsl:text>
      <xsl:call-template name="printExecuteSql"></xsl:call-template>
      <xsl:text disable-output-escaping="yes">                /////参数赋值&#xD;&#xA;&#xD;&#xA;</xsl:text>
      <xsl:call-template name="printAddParamValue">
        <xsl:with-param name="code" select="@Code"></xsl:with-param>
      </xsl:call-template>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">                //执行数据库操作&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                dat.Fill(objDataTable);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                if (objDataTable != null &amp;&amp;  objDataTable.Rows.Count > 0)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                    System.Data.DataRow[] dataRows=objDataTable.Select();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                    if (dataRows != null)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                    {&#xD;&#xA;                        </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes"> = ParseDataRowToEntity(dataRows[0]);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                    }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放SqlCommand&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            return </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出查询方法-->
  <xsl:template name="printDefaultMethods_Query">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
      <xsl:with-param name="code" select="@Code"/>
      <xsl:with-param name="type" select="$type_select_pk"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="DataTable"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public DataTable SelectAll</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>ByForeignKeys(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            SqlCommand m_sqlCmd = null;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            StringBuilder strBuilder = new StringBuilder("");&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            //SQL变量&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            String strSQL = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DataTable objDataTable = new DataTable();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DataTable </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes">List = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //以下生成SQL语句&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append(" select ");&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:text>                strBuilder.Append("   </xsl:text>
      <xsl:if test="$hasFK='True'">
        <xsl:value-of select="/tables/table/@ShowCode"/>
        <xsl:text>.</xsl:text>
      </xsl:if>
      <xsl:value-of select="@Code"/>
      <xsl:text> AS </xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:choose>
        <xsl:when test="position()&lt;last()">
          <xsl:text disable-output-escaping="yes">,");&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>
    <xsl:text>                strBuilder.Append(" from </xsl:text>
    <xsl:value-of select="/tables/table/@Code"/>
    <xsl:if test="$hasFK='True'">
      <xsl:text> </xsl:text>
      <xsl:value-of select="/tables/table/@ShowCode"/>
    </xsl:if>
    <xsl:text disable-output-escaping="yes">");&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties_fk">
      <xsl:text disable-output-escaping="yes">                strBuilder.Append(" left join </xsl:text>
      <xsl:value-of select="@FK_T_Code"/>
      <xsl:text> AS </xsl:text>
      <xsl:value-of select="@FK_T_ShowCode"/>
      <xsl:text> ON </xsl:text>
      <xsl:value-of select="/tables/table/@ShowCode"/>
      <xsl:text>.</xsl:text>
      <xsl:value-of select="@Code"/>
      <xsl:text> = </xsl:text>
      <xsl:value-of select="@FK_T_ShowCode"/>
      <xsl:text>.</xsl:text>
      <xsl:value-of select="@FK_Col_Code"/>
      <xsl:text disable-output-escaping="yes"> ");&#xD;&#xA;</xsl:text>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">                strBuilder.Append(" where 1=1 ");&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //---设置查询条件&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printExecuteSql"></xsl:call-template>
    <xsl:text disable-output-escaping="yes">                //执行数据库操作&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                SqlDataAdapter dat = new SqlDataAdapter(m_sqlCmd);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                dat.Fill(objDataTable);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放SqlCommand&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            return objDataTable</xsl:text>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--实体映射-->
  <xsl:template name="printDefaultMethods_Map">
    <xsl:text disable-output-escaping="yes">        /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        /// 实体映射</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;param name="dataRow" type="DataRow"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes">"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        private </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text> ParseDataRowToEntity(DataRow dataRow)</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            return </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeMapUtil"/>
    <xsl:text disable-output-escaping="yes">.ParseDataRowToEntity(dataRow);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>

  </xsl:template>

  <!--首字母转换成小写-->
  <xsl:template name="translateHeadLetterToLower">
    <xsl:param name="propertyName"/>
    <xsl:variable name="length" select="string-length($propertyName)"/>
    <xsl:variable name="headLetter" select="substring($propertyName,1,1)"/>
    <xsl:variable name="remainLetters" select="substring($propertyName,2,$length)"/>
    <xsl:value-of select="translate($headLetter,'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')"/>
    <xsl:value-of select="$remainLetters"/>
  </xsl:template>

  <!--首字母转换成大写-->
  <xsl:template name="translateHeadLetterToUpper">
    <xsl:param name="propertyName"/>
    <xsl:variable name="length" select="string-length($propertyName)"/>
    <xsl:variable name="headLetter" select="substring($propertyName,1,1)"/>
    <xsl:variable name="remainLetters" select="substring($propertyName,2,$length)"/>
    <xsl:value-of select="translate($headLetter,'abcdefghijklmnopqrstuvwxyz','ABCDEFGHIJKLMNOPQRSTUVWXYZ')"/>
    <xsl:value-of select="$remainLetters"/>
  </xsl:template>


  <xsl:template name="printDefaultValue">

    <xsl:param name="type"/>

    <xsl:choose>

      <xsl:when test="contains($type,'int')">

        <xsl:text> = 0</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'datetime')">

        <xsl:text> </xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'boolean')">

        <xsl:text> = false</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'long')">

        <xsl:text> = 0</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'float')">

        <xsl:text> = 0</xsl:text>

      </xsl:when>


      <xsl:when test="contains($type,'image')">

        <xsl:text> </xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'varchar')">

        <xsl:text> = string.Empty</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'decimal')">

        <xsl:text> = 0</xsl:text>

      </xsl:when>
      <xsl:when test="contains($type,'char')">

        <xsl:text> </xsl:text>

      </xsl:when>

      <xsl:otherwise>

        <xsl:text> = null</xsl:text>

      </xsl:otherwise>

    </xsl:choose>

  </xsl:template>

  <xsl:template name="printValueType">

    <xsl:param name="type"/>

    <xsl:choose>

      <xsl:when test="contains($type,'int')">

        <xsl:text>int</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'datetime')">

        <xsl:text>DateTime</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'boolean')">

        <xsl:text>bool</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'long')">

        <xsl:text>long</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'float')">

        <xsl:text>float</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'image')">

        <xsl:text>byte[]</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'varchar')">

        <xsl:text>string</xsl:text>

      </xsl:when>

      <xsl:when test="contains($type,'decimal')">

        <xsl:text>decimal</xsl:text>

      </xsl:when>
      <xsl:when test="contains($type,'char')">

        <xsl:text>char</xsl:text>

      </xsl:when>
      <xsl:otherwise>

        <xsl:text>null</xsl:text>

      </xsl:otherwise>

    </xsl:choose>

  </xsl:template>

  <xsl:template name="printNote">
    <xsl:param name="name"/>
    <xsl:param name="code"/>
    <xsl:param name="type"/>
    <xsl:text disable-output-escaping="yes">        /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        /// </xsl:text>
    <xsl:value-of select="$type"/>
    <xsl:if test="$name!=''">
      <xsl:text disable-output-escaping="yes">&#xD;&#xA;        /// </xsl:text>
      <xsl:value-of select="$name"/>
      <xsl:text> : </xsl:text>
      <xsl:value-of select="$code"/>
    </xsl:if>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;param name="paramConnectionEntity" type="Object"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;param name="param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text>" type="</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntityName"/>
    <xsl:text disable-output-escaping="yes">"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template name="printNoteHead">
    <xsl:param name="name"/>
    <xsl:param name="code"/>

    <xsl:text disable-output-escaping="yes">    ///&lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>    ///</xsl:text>
    <xsl:value-of select="$name"/>
    <xsl:text> ( </xsl:text>
    <xsl:value-of select="$code"/>
    <xsl:text> ) </xsl:text>
    <xsl:copy-of select="$pageTypeStrName"/>
    <xsl:text>类</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;    ///&lt;/summary&gt;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--参数赋值 Insert Update-->
  <xsl:template name="printAddParamValue">
    <xsl:param name="code"></xsl:param>
    <xsl:for-each select="$properties">
      <xsl:if test="$code=@Code or $code=''">
        <xsl:text disable-output-escaping="yes">                ///</xsl:text>
        <xsl:value-of select="@Name"/>
        <xsl:text> : </xsl:text>
        <xsl:value-of select="@DataType"/>
        <xsl:text> </xsl:text>
        <xsl:value-of select="@Code"/>
        <xsl:if test="@FK">
          <xsl:text> -- 外键 ：来自表 </xsl:text>
          <xsl:value-of select="@FK_T_Code"/>
        </xsl:if>
        <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
        <xsl:choose>
          <xsl:when test="contains(@DataType,'int') or contains(@DataType,'long') or contains(@DataType,'float') or contains(@DataType,'decimal')">
            <xsl:text disable-output-escaping="yes">                m_sqlCmd.Parameters.AddWithValue("@</xsl:text>
            <xsl:value-of select="@Code"/>
            <xsl:text>",param</xsl:text>
            <xsl:value-of select="/tables/table/@ShowCode"/>
            <xsl:value-of select="$pageTypeEntityName"/>
            <xsl:text>.</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text disable-output-escaping="yes">);&#xD;&#xA;&#xD;&#xA;</xsl:text>
          </xsl:when>
          <xsl:when test="contains(@DataType,'datetime')">
            <xsl:text disable-output-escaping="yes">                if (param</xsl:text>
            <xsl:value-of select="/tables/table/@ShowCode"/>
            <xsl:value-of select="$pageTypeEntityName"/>
            <xsl:text>.</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text disable-output-escaping="yes"> &gt; DateTime.MinValue</xsl:text>
            <xsl:text disable-output-escaping="yes">)&#xD;&#xA;                {&#xD;&#xA;</xsl:text>
            <xsl:text disable-output-escaping="yes">                    m_sqlCmd.Parameters.AddWithValue("@</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text>", param</xsl:text>
            <xsl:value-of select="/tables/table/@ShowCode"/>
            <xsl:value-of select="$pageTypeEntityName"/>
            <xsl:text>.</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text disable-output-escaping="yes">);&#xD;&#xA;</xsl:text>
            <xsl:text disable-output-escaping="yes">                }&#xD;&#xA;                else&#xD;&#xA;                {&#xD;&#xA;</xsl:text>
            <xsl:text disable-output-escaping="yes">                    m_sqlCmd.Parameters.AddWithValue("@</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text disable-output-escaping="yes">", DBNull.Value);&#xD;&#xA;                }&#xD;&#xA;&#xD;&#xA;</xsl:text>
          </xsl:when>
          <xsl:otherwise>
            <xsl:text disable-output-escaping="yes">                if (param</xsl:text>
            <xsl:value-of select="/tables/table/@ShowCode"/>
            <xsl:value-of select="$pageTypeEntityName"/>
            <xsl:text>.</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text disable-output-escaping="yes"> != null &amp;&amp; "".Equals(param</xsl:text>
            <xsl:value-of select="/tables/table/@ShowCode"/>
            <xsl:value-of select="$pageTypeEntityName"/>
            <xsl:text>.</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text disable-output-escaping="yes">.Trim()))&#xD;&#xA;                {&#xD;&#xA;</xsl:text>
            <xsl:text disable-output-escaping="yes">                    m_sqlCmd.Parameters.AddWithValue("@</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text>", param</xsl:text>
            <xsl:value-of select="/tables/table/@ShowCode"/>
            <xsl:value-of select="$pageTypeEntityName"/>
            <xsl:text>.</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text disable-output-escaping="yes">);&#xD;&#xA;</xsl:text>
            <xsl:text disable-output-escaping="yes">                }&#xD;&#xA;                else&#xD;&#xA;                {&#xD;&#xA;</xsl:text>
            <xsl:text disable-output-escaping="yes">                    m_sqlCmd.Parameters.AddWithValue("@</xsl:text>
            <xsl:value-of select="@ShowCode"/>
            <xsl:text disable-output-escaping="yes">", DBNull.Value);&#xD;&#xA;                }&#xD;&#xA;&#xD;&#xA;</xsl:text>
          </xsl:otherwise>
        </xsl:choose>
      </xsl:if>
    </xsl:for-each>

  </xsl:template>

  <!--getSql 获得数据库连接-->
  <xsl:template name="printExecuteSql">
    <xsl:text disable-output-escaping="yes">                //向SQL字符串变量赋值&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                strSQL = strBuilder.ToString();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //获得数据库连接 &#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                m_sqlCmd = new SqlCommand(strSQL, sqlConn);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                m_sqlCmd.Transaction = sqlTrans;&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template match="exception">

    <xsl:value-of select="."/>

    <xsl:if test="position()&lt;last()">

      <xsl:text>,</xsl:text>

    </xsl:if>

  </xsl:template>

</xsl:stylesheet>