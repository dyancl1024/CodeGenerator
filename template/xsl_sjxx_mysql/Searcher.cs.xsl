<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output method="text"/>
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
    <xsl:text>Searcher(</xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text disable-output-escaping="yes">)查询&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">   public class </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes">Searcher&#xD;&#xA;   {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">      public int PageSize { get; set; }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">      public int PageIndex { get; set; }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">    &#xD;&#xA;   }&#xD;&#xA;   #endregion</xsl:text>

  </xsl:template>

</xsl:stylesheet>