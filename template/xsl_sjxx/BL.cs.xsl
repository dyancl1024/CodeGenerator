<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!-- 代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:variable name="pageTypeStrName" select="'BL'" />
  <xsl:variable name="pageTypeEntity" select="'Entity'" />
  <xsl:variable name="pageTypeDB" select="'DB'" />

  <!--操作方法-->
  <xsl:variable name="type_add">
    <xsl:text>添加</xsl:text>
    <xsl:value-of select="/tables/table/@Name"/>
  </xsl:variable>
  <xsl:variable name="type_modify">
    <xsl:text>修改</xsl:text>
    <xsl:value-of select="/tables/table/@Name"/>
  </xsl:variable>
  <xsl:variable name="type_removed">
    <xsl:text>删除</xsl:text>
    <xsl:value-of select="/tables/table/@Name"/>
  </xsl:variable>
  <xsl:variable name="type_select">
    <xsl:text>查看</xsl:text>
    <xsl:value-of select="/tables/table/@Name"/>
  </xsl:variable>

  <xsl:output method="text"/>
  <xsl:template match="/">
    <xsl:apply-templates select="tables"/>
  </xsl:template>

  <!--匹配tables元素 -->
  <xsl:template match="tables">
    <xsl:apply-templates select="table"/>
  </xsl:template>

  <!--匹配bean元素，实际代码生成在此完成-->
  <xsl:template match="table">
    <xsl:text disable-output-escaping="yes">using System.Collections.Generic;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using </xsl:text>
    <xsl:value-of select="@namespace"/>.<xsl:value-of select="$pageTypeDB"/><xsl:text disable-output-escaping="yes">;&#xD;&#xA;using </xsl:text>
    <xsl:value-of select="@namespace"/>.<xsl:value-of select="$pageTypeEntity"/><xsl:text disable-output-escaping="yes">;&#xD;&#xA;&#xD;&#xA;</xsl:text>
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
    <!--输出基本方法-->
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;}</xsl:text>
  </xsl:template>

  <!--输出新增方法-->
  <xsl:template name="printDefaultMethods_Insert">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_add"/>
    </xsl:call-template>
    <xsl:text>        public static int Add</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>(</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> info</xsl:text>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            return </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDB"/>
    <xsl:text>.Add</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text disable-output-escaping="yes">(info);&#xD;&#xA;        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出修改方法-->
  <xsl:template name="printDefaultMethods_Update">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_modify"/>
    </xsl:call-template>
    <xsl:text>        public static int Modify</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>(</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> info</xsl:text>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            return </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDB"/>
    <xsl:text>.Modify</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text disable-output-escaping="yes">(info);&#xD;&#xA;        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出删除方法-->
  <xsl:template name="printDefaultMethods_Delete">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_removed"/>
    </xsl:call-template>
    <xsl:text>        public static int Remove</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>(int ID)</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;            return </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDB"/>
    <xsl:text>.Remove</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>(ID);</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出查看详情方法-->
  <xsl:template name="printDefaultMethods_View">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_select"/>
    </xsl:call-template>
    <xsl:text>        public static </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> Get</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>Detail(int ID)</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text>            return </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDB"/>
    <xsl:text>.Get</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>Detail(ID);</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        }&#xD;&#xA;</xsl:text>
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
    <xsl:param name="type"/>
    <xsl:text disable-output-escaping="yes">        /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        /// </xsl:text>
    <xsl:value-of select="$type"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:choose>
      <xsl:when test="contains($type,'添加')">
        <xsl:text disable-output-escaping="yes">        /// &lt;param name="info</xsl:text>
        <xsl:text disable-output-escaping="yes">"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
        <xsl:text disable-output-escaping="yes">        /// &lt;returns&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
      </xsl:when>
      <xsl:when test="contains($type,'修改')">
        <xsl:text disable-output-escaping="yes">        /// &lt;param name="info</xsl:text>
        <xsl:text disable-output-escaping="yes">"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
        <xsl:text disable-output-escaping="yes">        /// &lt;returns&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
      </xsl:when>
      <xsl:when test="contains($type,'删除')">
        <xsl:text disable-output-escaping="yes">        /// &lt;param name="ID</xsl:text>
        <xsl:text disable-output-escaping="yes">"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
        <xsl:text disable-output-escaping="yes">        /// &lt;returns&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
      </xsl:when>
      <xsl:when test="contains($type,'查看')">
        <xsl:text disable-output-escaping="yes">        /// &lt;param name="ID</xsl:text>
        <xsl:text disable-output-escaping="yes">"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
        <xsl:text disable-output-escaping="yes">        /// &lt;returns&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
      </xsl:when>
    </xsl:choose>


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

</xsl:stylesheet>