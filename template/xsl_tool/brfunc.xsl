<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template name="br">
    <xsl:param name="string"/>
    <xsl:choose>
      <xsl:when test="contains($string,' ')">
        <xsl:value-of select="substring-before($string,' ')"/>
        <xsl:call-template name="br">
          <xsl:with-param name="string" select="substring-after($string,' ')"/>
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$string"/>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
</xsl:stylesheet>