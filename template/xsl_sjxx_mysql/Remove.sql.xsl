<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!-- 代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:output method="text"/>
  <xsl:variable name="SqlPrefix" select="'sp_SJ_'" />
  <xsl:variable name="SqlMethod" select="'_Remove'" />

  <!--字段对象-->
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
    <xsl:text>/*&#xD;&#xA;  </xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text> - 删除信息脚本&#xD;&#xA;</xsl:text>
    <xsl:text>*/&#xD;&#xA;</xsl:text>
    <xsl:text>DROP PROCEDURE IF EXISTS </xsl:text>
    <xsl:value-of select="$SqlPrefix"/>
    <xsl:value-of select="@Code"/>
    <xsl:value-of select="$SqlMethod"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;CREATE  PROCEDURE </xsl:text>
    <xsl:value-of select="$SqlPrefix"/>
    <xsl:value-of select="@Code"/>
    <xsl:value-of select="$SqlMethod"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;(&#xD;&#xA;</xsl:text>
    <xsl:text>   IN i_</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" order="descending" />
      <xsl:if test="position()=1">
      <xsl:value-of select="@ShowCode"/>
      <xsl:text> </xsl:text>
      <xsl:value-of select="@DataType"/>
      </xsl:if>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">,&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">   OUT o_Result int&#xD;&#xA;)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">BEGIN&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text >  DELETE FROM </xsl:text>
    <xsl:value-of select="@Code"/>
    <xsl:text> WHERE </xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" order="descending"/>
      <xsl:if test="position()=1">
        <xsl:value-of select="@Code"/>
        <xsl:text> = i_</xsl:text>
        <xsl:value-of select="@ShowCode"/>
      </xsl:if>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes"> ;&#xD;&#xA;&#xD;&#xA;  SELECT ROW_COUNT() INTO o_Result;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;END;&#xD;&#xA;</xsl:text>

  </xsl:template>


</xsl:stylesheet>