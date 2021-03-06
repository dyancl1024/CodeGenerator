﻿<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!-- 代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:output method="text"/>
  <xsl:variable name="SqlPrefix" select="'sp_SJ_'" />
  <xsl:variable name="SqlMethod" select="'_Detail'" />

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
    <xsl:text> - 查看列表脚本&#xD;&#xA;</xsl:text>
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
    <xsl:text>   IN i_PageSize int,&#xD;&#xA;</xsl:text>
    <xsl:text>   IN i_PageIndex int,&#xD;&#xA;</xsl:text>
    <xsl:text>   OUT o_TotlaCount int</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">BEGIN&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text >  SELECT COUNT(1) INTO o_TotlaCount FROM </xsl:text>
    <xsl:value-of select="@Code"/>
    <xsl:text >;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text >  SELECT &#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" order="descending"/>
      <xsl:text >     </xsl:text>
      <xsl:value-of select="@Code"/>
      <xsl:choose>
        <xsl:when test="position()&lt;last()">
          <xsl:text disable-output-escaping="yes">,&#xD;&#xA;</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:text disable-output-escaping="yes">&#xD;&#xA;   FROM </xsl:text>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>
    <xsl:value-of select="@Code"/>
    <xsl:text>&#xD;&#xA;   WHERE 1=1 </xsl:text>
    <xsl:text>&#xD;&#xA;   LIMIT i_PageIndex,i_PageSize</xsl:text>
    <xsl:text disable-output-escaping="yes"> ;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;END;&#xD;&#xA;</xsl:text>

  </xsl:template>


</xsl:stylesheet>