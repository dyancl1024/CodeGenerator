<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!--代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:variable name="pageTypeName" select="'实体类'" />
  <xsl:variable name="pageTypeStrName" select="'Entity'" />

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
    <xsl:text disable-output-escaping="yes">using System;&#xD;&#xA;</xsl:text>
    <xsl:text>namespace </xsl:text>
    <!--输出包名-->
    <xsl:value-of select="@namespace"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;{&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printNoteHead">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
      <xsl:with-param name="code" select="@Code"/>
    </xsl:call-template>
    <!--<xsl:text disable-output-escaping="yes">   [Serializable]&#xD;&#xA;</xsl:text>-->
    <xsl:text>    public class </xsl:text>
    <!--输出JavaBean类名-->
    <xsl:value-of select="@ShowCode"/>
    <xsl:copy-of select="$pageTypeStrName"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;    {&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printField"/>
    <!--输出字段信息-->
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printConstructor"/>
    <!--输出构造函数-->
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:apply-templates select="column"/>
    <!--输出所有属性的get和set方法-->
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;}</xsl:text>
  </xsl:template>

  <!--匹配column元素，输出适当的方法-->
  <xsl:template match="column">
    <xsl:call-template name="printSetAndGetMethod">
      <xsl:with-param name="column" select="."/>
    </xsl:call-template>
  </xsl:template>

  <xsl:template name="printField">
    <xsl:for-each select="$properties">
      <xsl:text>        private </xsl:text>
      <xsl:call-template name="printValueType">
        <!--输出字段缺省值-->
        <xsl:with-param name="type" select="@DataType"/>
      </xsl:call-template>
      <xsl:text> m_</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:call-template name="printDefaultValue">
        <!--输出字段缺省值-->
        <xsl:with-param name="type" select="@DataType"/>
      </xsl:call-template>
      <xsl:text>; //-- </xsl:text>
      <xsl:value-of select="@Name"/>
      <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    </xsl:for-each>
  </xsl:template>

  <xsl:template name="printConstructor">
    <xsl:text>        public </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeStrName"/>
    <xsl:text>(){ }</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:text>        public </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:copy-of select="$pageTypeStrName"/>
    <xsl:text>(</xsl:text>
    <xsl:for-each select="$properties">
      <!--输出构造函数参数列-->
      <xsl:call-template name="printValueType">
        <!--输出字段缺省值-->
        <xsl:with-param name="type" select="@DataType"/>
      </xsl:call-template>
      <xsl:text> </xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:if test="position()&lt;last()">
        <xsl:text>,</xsl:text>
      </xsl:if>
    </xsl:for-each>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <!--输出构造函数主体-->
      <xsl:text>            this.</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text>=</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text>;</xsl:text>
      <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    </xsl:for-each>
    <xsl:text>        }</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--命名模板，打印get,set方法-->
  <xsl:template name="printSetAndGetMethod">
    <xsl:param name="column"/>
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
    </xsl:call-template>
    <xsl:text>        public </xsl:text>
    <xsl:call-template name="printValueType">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="@DataType"/>
    </xsl:call-template>
    <xsl:text> </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text>            set { m_</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes"> = value;}&#xD;&#xA;</xsl:text>
    <xsl:text >            get { return m_</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes">;}&#xD;&#xA;        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <xsl:template name="translateHeadLetter">
    <xsl:param name="propertyName"/>
    <xsl:variable name="length" select="string-length($propertyName)"/>
    <xsl:variable name="headLetter" select="substring($propertyName,1,1)"/>
    <xsl:variable name="remainLetters" select="substring($propertyName,2,$length)"/>
    <xsl:value-of
    select="translate($headLetter,'abcdefghijklmnopqrstuvwxyz','ABCDEFGHIJKLMNOPQRSTUVWXYZ')"/>
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
    <xsl:text disable-output-escaping="yes">        ///&lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        ///</xsl:text>
    <xsl:value-of select="$name"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        ///&lt;/summary&gt;&#xD;&#xA;</xsl:text>
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

  <xsl:template match="exception">
    <xsl:value-of select="."/>
    <xsl:if test="position()&lt;last()">
      <xsl:text>,</xsl:text>
    </xsl:if>
  </xsl:template>

</xsl:stylesheet>