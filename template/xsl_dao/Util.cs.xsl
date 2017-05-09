<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!--代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:variable name="pageTypeName" select="'实体映射'" />
  <xsl:variable name="pageTypeStrName" select="'MapUtil'" />
  <xsl:variable name="pageTypeEntity" select="'Entity'" />
  <xsl:variable name="note">
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> 的摘要说明</xsl:text>
  </xsl:variable>
  
  <xsl:output method="text"/>
  <xsl:variable name="properties" select="/tables/table/column"/>
  <xsl:template match="/">
    <xsl:apply-templates select="tables"/>
  </xsl:template>

  <!--匹配tables元素 -->
  <xsl:template match="tables">
    <xsl:apply-templates select="table"/>
  </xsl:template>

  <!--匹配javabean元素，实际代码生成在此完成-->
  <xsl:template match="table">
    <xsl:text disable-output-escaping="yes">using System;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>namespace </xsl:text>
    <!--输出包名-->
    <xsl:value-of select="@namespace"/>
    <xsl:text>.</xsl:text>
    <xsl:value-of select="$pageTypeStrName"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;{&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printNoteHead">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="$note"/>
    </xsl:call-template>
    <xsl:text>    public class </xsl:text>
    <!--输出JavaBean类名-->
    <xsl:value-of select="@ShowCode"/>
    <xsl:copy-of select="$pageTypeStrName"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;    {&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDataToEntity"/>
    <!--输出字段信息-->
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printMapForSingle"/>
    <!--输出构造函数-->
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printMapForAll"/>
    
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;}</xsl:text>
  </xsl:template>


  <!--输出映射方法-->
  <xsl:template name="printDataToEntity">
    <xsl:text disable-output-escaping="yes">        ///&lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        ///实体映射</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        ///&lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        ///&lt;param name="dataRow" type="DataRow"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        ///&lt;returns type="</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">"&gt;</xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public static </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> ParseDataRowToEntity(DataRow dataRow)</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;           </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> =new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;&#xD;&#xA;           </xsl:text>
    <xsl:for-each select="$properties">
      <xsl:text disable-output-escaping="yes">//</xsl:text>
      <xsl:value-of select="@Name"/>
      <xsl:text> </xsl:text>
      <xsl:value-of select="@DataType"/>
      <xsl:text disable-output-escaping="yes">&#xD;&#xA;           </xsl:text>
      <xsl:choose>
        <xsl:when test="contains(@DataType,'int') or contains(@DataType,'long') or contains(@DataType,'float') or contains(@DataType,'decimal') or contains(@DataType,'datetime') or contains(@DataType,'image')">
          <xsl:text>if(dataRow["</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">"].ToString() != "")</xsl:text>
          <xsl:text disable-output-escaping="yes">&#xD;&#xA;           {&#xD;&#xA;              </xsl:text>
          <xsl:call-template name="translateHeadLetterToLower">
            <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
          </xsl:call-template>
          <xsl:value-of select="$pageTypeEntity"/>
          <xsl:text>.</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:choose>
            <xsl:when test="contains(@DataType,'int')">
              <xsl:text> = int.Parse(dataRow["</xsl:text>
              <xsl:value-of select="@ShowCode"/>
              <xsl:text disable-output-escaping="yes">"].ToString());&#xD;&#xA;</xsl:text>
            </xsl:when>
            <xsl:when test="contains(@DataType,'long')">
              <xsl:text> = long.Parse(dataRow["</xsl:text>
              <xsl:value-of select="@ShowCode"/>
              <xsl:text disable-output-escaping="yes">"].ToString());&#xD;&#xA;</xsl:text>
            </xsl:when>
            <xsl:when test="contains(@DataType,'float')">
              <xsl:text> = float.Parse(dataRow["</xsl:text>
              <xsl:value-of select="@ShowCode"/>
              <xsl:text disable-output-escaping="yes">"].ToString());&#xD;&#xA;</xsl:text>
            </xsl:when>
            <xsl:when test="contains(@DataType,'decimal')">
              <xsl:text> = decimal.Parse(dataRow["</xsl:text>
              <xsl:value-of select="@ShowCode"/>
              <xsl:text disable-output-escaping="yes">"].ToString());&#xD;&#xA;</xsl:text>
            </xsl:when>
            <xsl:when test="contains(@DataType,'datetime')">
              <xsl:text> = DateTime.Parse(dataRow["</xsl:text>
              <xsl:value-of select="@ShowCode"/>
              <xsl:text disable-output-escaping="yes">"].ToString());&#xD;&#xA;</xsl:text>
            </xsl:when>
            <xsl:when test="contains(@DataType,'image')">
              <xsl:text> = (byte[])dataRow["</xsl:text>
              <xsl:value-of select="@ShowCode"/>
              <xsl:text disable-output-escaping="yes">"];&#xD;&#xA;</xsl:text>
            </xsl:when>
          </xsl:choose>
          <xsl:text disable-output-escaping="yes">           }&#xD;&#xA;           </xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:call-template name="translateHeadLetterToLower">
            <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
          </xsl:call-template>
          <xsl:value-of select="$pageTypeEntity"/>
          <xsl:text>.</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text> = dataRow["</xsl:text>
          <xsl:value-of select="@ShowCode"/>
          <xsl:text disable-output-escaping="yes">"].ToString();&#xD;&#xA;           </xsl:text>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;           return </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--映射单个实体-->
  <xsl:template name="printMapForSingle">
    <xsl:text disable-output-escaping="yes">        ///&lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        ///映射单个实体</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        ///&lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        ///&lt;param name="objDataTable"&lt;&gt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        ///&lt;returns type="</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">"&gt;</xsl:text>
    <xsl:text>obj</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public static </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> MapDataTableToSingleEntity(DataTable objDataTable)</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;           </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text> obj</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes"> = null;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">           if(objDataTable != null &amp;&amp; objDataTable.Rows.Count > 0)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">           {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">              System.Data.DataRow[] dataRows = objDataTable.Select();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">              if (dataRows != null)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">              {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                 obj</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes"> = ParseDataRowToEntity(dataRows[0]);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">              }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">           }&#xD;&#xA;</xsl:text>
    <xsl:text>           return obj</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--解析DataTable为对象数组-->
  <xsl:template name="printMapForAll">
    <xsl:text disable-output-escaping="yes">        ///&lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        ///解析DataTable为对象数组</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        ///&lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        ///&lt;param name="objDataTable"&lt;&gt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        ///&lt;returns type="</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">[]"&gt;</xsl:text>
    <xsl:text>arrayEntitys</xsl:text>
    <xsl:text disable-output-escaping="yes">&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public static </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text>[] MapDataTableToEntityArray(DataTable objDataTable)</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;           </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">[] arrayEntitys = null;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">           if(objDataTable != null &amp;&amp; objDataTable.Rows.Count > 0)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">           {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">              System.Data.DataRow[] dataRows = objDataTable.Select();&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">              if (dataRows != null)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">              {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                 arrayEntitys = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">[dataRows.Length];&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                 for (int i = 0; i &lt; dataRows.Length; i++)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                 {&#xD;&#xA;                    </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text> obj</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">= ParseDataRowToEntity(dataRows[i]);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                    arrayEntitys[i] = obj</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                 }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">              }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">           }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">           return arrayEntitys;&#xD;&#xA;</xsl:text>
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

  <xsl:template name="printNote">
    <xsl:param name="name"/>
    <xsl:text disable-output-escaping="yes">        ///&lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        ///</xsl:text>
    <xsl:value-of select="$name"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        ///&lt;/summary&gt;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template name="printNoteHead">
    <xsl:param name="name"/>
    <xsl:text disable-output-escaping="yes">    ///&lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>    ///</xsl:text>
    <xsl:value-of select="$name"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;    ///&lt;/summary&gt;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template match="exception">
    <xsl:value-of select="."/>
    <xsl:if test="position()&lt;last()">
      <xsl:text>,</xsl:text>
    </xsl:if>
  </xsl:template>

</xsl:stylesheet>