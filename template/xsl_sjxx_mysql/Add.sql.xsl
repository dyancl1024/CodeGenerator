<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!-- 代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:output method="text"/>
  <xsl:variable name="SqlPrefix" select="'sp_SJ_'" />
  <xsl:variable name="SqlMethod" select="'_Add'" />

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
    <xsl:text> - 新增脚本&#xD;&#xA;</xsl:text>
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
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" />
      <xsl:if test="position()&lt;last()">
        <xsl:text>   IN i_</xsl:text>
        <xsl:value-of select="@ShowCode"/>
        <xsl:text> </xsl:text>
        <xsl:value-of select="@DataType"/>
        <xsl:text disable-output-escaping="yes">,&#xD;&#xA;</xsl:text>
      </xsl:if>
    </xsl:for-each>

    <xsl:text disable-output-escaping="yes">   OUT o_Result int&#xD;&#xA;)&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">BEGIN&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text >  INSERT INTO </xsl:text>
    <xsl:value-of select="@Code"/>
    <xsl:text>&#xD;&#xA;  (&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" />
      <xsl:if test="position()&lt;last()">
        <xsl:text>      </xsl:text>
        <xsl:value-of select="@Code"/>
        <xsl:choose>
          <xsl:when test="position()&lt;last()-1">
            <xsl:text disable-output-escaping="yes">,&#xD;&#xA;</xsl:text>
          </xsl:when>
          <xsl:otherwise>
            <xsl:text disable-output-escaping="yes">&#xD;&#xA;  )&#xD;&#xA;  VALUES&#xD;&#xA;  (&#xD;&#xA;</xsl:text>
          </xsl:otherwise>
        </xsl:choose>
      </xsl:if>
    </xsl:for-each>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" />
      <xsl:if test="position()&lt;last()">
        <xsl:text>      i_</xsl:text>
        <xsl:value-of select="@ShowCode"/>
        <xsl:choose>
          <xsl:when test="position()&lt;last()-1">
            <xsl:text disable-output-escaping="yes">,  --  </xsl:text>
            <xsl:value-of select="@DataType"/>
            <xsl:text> (</xsl:text>
            <xsl:value-of select="@Name"/>
            <xsl:text>)&#xD;&#xA;</xsl:text>
          </xsl:when>
          <xsl:otherwise>
            <xsl:text disable-output-escaping="yes">  --  </xsl:text>
            <xsl:value-of select="@DataType"/>
            <xsl:text> (</xsl:text>
            <xsl:value-of select="@Name"/>
            <xsl:text disable-output-escaping="yes">)&#xD;&#xA;   );&#xD;&#xA;</xsl:text>
          </xsl:otherwise>
        </xsl:choose>
      </xsl:if>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;   SELECT @@IDENTITY INTO o_Result;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;END;&#xD;&#xA;</xsl:text>

  </xsl:template>


</xsl:stylesheet>