<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output method="text"/>
  <xsl:variable name="properties" select="/tables/table"/>
  <xsl:template match="/">
    <xsl:apply-templates select="tables"/>
  </xsl:template>

  <!--匹配tables元素 -->
  <xsl:template match="tables">
    <xsl:apply-templates select="table"/>
  </xsl:template>

  <!--匹配javabean元素，实际代码生成在此完成-->
  <xsl:template match="table">

    <xsl:text disable-output-escaping="yes">&#xD;&#xA;&#xD;&#xA;   #region </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>EntityListResult(</xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text disable-output-escaping="yes">)查询列表&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">   public class </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>EntityListResult</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;   {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">      public List&lt;</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes">Info&gt; </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes">List { get; set; } &#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">      public int TotalCount { get; set; }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    &#xD;&#xA;   }&#xD;&#xA;&#xD;&#xA;</xsl:text>

    <xsl:text disable-output-escaping="yes">   public class </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>Info : </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes">Entity&#xD;&#xA;   {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    &#xD;&#xA;   }&#xD;&#xA;   #endregion</xsl:text>

  </xsl:template>

</xsl:stylesheet>