<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="text" indent="yes"/>
<xsl:template match="tables/table">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Model
{
    [Serializable]
    public class <xsl:value-of select="@ShowCode"/>
    { <xsl:for-each select="/tables/table/column">
         private  <xsl:call-template name="printValueType">
              <xsl:with-param name="type" select="@DataType"/>
            </xsl:call-template> m_<xsl:value-of select="@ShowCode"/>
            <xsl:call-template name="printDefaultValue">
              <xsl:with-param name="type" select="@DataType"/>
            </xsl:call-template>;//--<xsl:value-of select="@Name"/>
          </xsl:for-each><xsl:text>
         </xsl:text>
        <xsl:for-each select="/tables/table/column">
         ///<summary>
         /// <xsl:value-of select="@Name"/>
         ///</summary>
         public <xsl:call-template name="printValueType"><xsl:with-param name="type" select="@DataType"/></xsl:call-template><xsl:text> </xsl:text><xsl:value-of select="@ShowCode"/>
         {
              set { m_<xsl:value-of select="@ShowCode"/>=value; }
              get { return m_<xsl:value-of select="@ShowCode"/>;}
         }
          </xsl:for-each>
    }
}
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
        <xsl:text>string</xsl:text>
      </xsl:otherwise>
    </xsl:choose>
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
</xsl:stylesheet>
