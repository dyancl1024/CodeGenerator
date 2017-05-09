<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="html" encoding="utf-8"/>
  <xsl:variable name="pageTypeName" select="'编辑'" />
  <xsl:variable name="pageTypeStrName" select="'Edit'" />
  <xsl:variable name="properties" select="/tables/table/column"/>

  <xsl:preserve-space elements="*"/>
  <xsl:template match="/">
    <xsl:apply-templates select="tables"/>
  </xsl:template>

  <!--匹配tables元素 -->
  <xsl:template match="tables">
    <xsl:apply-templates select="table"/>
  </xsl:template>

  <!--匹配bean元素，实际代码生成在此完成-->
  <xsl:template match="table">
    <xsl:call-template name="printTop"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <html xmlns="http://www.w3.org/1999/xhtml">
      <head id="Head1" runat="server">
        　　　　<title>
          <xsl:value-of select="$pageTypeName"/>
          <xsl:value-of select="/tables/table/@Name"/>
        </title>
      </head>
      <body class="bodycolor" style="margin: 0">
        <form id="Form1" runat="server">
          &#160;<table width="100%" height="100%"  border="0" cellpadding="0" cellspacing="0">
            &#160;&#160;<tr>
              &#160;&#160;&#160;<td valign="top" height="20">
                <xsl:text disable-output-escaping="yes">&lt;uc:header id="header1" runat="server" path="../" moduleName="</xsl:text>
                <xsl:value-of select="$pageTypeName"/>
                <xsl:value-of select="/tables/table/@Name"/>
                <xsl:text disable-output-escaping="yes">"&gt;&lt;/uc:header&gt;</xsl:text>
                &#160;&#160;&#160;
              </td>
              &#160;&#160;
            </tr>
            &#160;&#160;<tr>
              &#160;&#160;&#160;<td valign="top" bgcolor="F4F3EF">
                &#160;&#160;&#160;&#160;<table width="100%" border="0" cellpadding="0" cellspacing="0">
                  &#160;&#160;&#160;&#160;&#160;<tr>
                    &#160;&#160;&#160;&#160;&#160;&#160;<td>
                      &#160;&#160;&#160;&#160;&#160;&#160;&#160;<table cellpadding="0" cellspacing="1" border="0" width="100%" class="Table0">
                        <xsl:for-each select="$properties">
                          &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;<tr>
                            &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;<td class="Table0TD1" style="width:90px;">
                              <xsl:text disable-output-escaping="yes">&#xD;&#xA;                                        </xsl:text>
                              <xsl:value-of select="@Name"/>
                              <xsl:text disable-output-escaping="yes">&#xD;&#xA;                                        </xsl:text>
                            </td>
                            &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;<td class="Table0TD2" colspan="1">
                              <xsl:text disable-output-escaping="yes">&#xD;&#xA;                                        &lt;asp:TextBox id="txt</xsl:text>
                              <xsl:value-of select="@ShowCode"/>
                              <xsl:text disable-output-escaping="yes">" CssClass="textbox" runat="server"  Width="100" MaxLength="100"&gt;&lt;/asp:TextBox&gt;&#xD;&#xA;                                        </xsl:text>
                            </td>
                            <xsl:text disable-output-escaping="yes">&#xD;&#xA;                                   </xsl:text>
                          </tr>
                        </xsl:for-each>
                        &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;
                      </table>
                      &#160;&#160;&#160;&#160;&#160;&#160;&#160;
                    </td>
                    &#160;&#160;&#160;&#160;&#160;&#160;
                  </tr>
                  &#160;&#160;&#160;&#160;&#160;
                </table>
                &#160;&#160;&#160;&#160;
              </td>
              &#160;&#160;&#160;
            </tr>
            &#160;&#160;&#160;<tr>
              &#160;&#160;&#160;&#160;<td>
                <xsl:text disable-output-escaping="yes">&amp;nbsp;</xsl:text>
              </td>
              &#160;&#160;&#160;
            </tr>
            &#160;&#160;&#160;<tr>
              &#160;&#160;&#160;&#160;<td align="center" height="35" valign="top">
                <xsl:text disable-output-escaping="yes">&lt;asp:Button ID="btnSave" runat="server" CssClass="button" Text="保 存" OnClick="btnSave_Click" /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;input type="button" value="关 闭" class="button" onclick="javascript:window.close();" /&gt;</xsl:text>
                &#160;&#160;&#160;&#160;
              </td>
              &#160;&#160;&#160;
            </tr>
            &#160;
          </table>
        </form>
      </body>
    </html>
  </xsl:template>
  <xsl:template name="printTop">
    <xsl:text disable-output-escaping="yes">&lt;%@ Page Language="C#" AutoEventWireup="true" CodeFile="</xsl:text>
    <xsl:value-of select="$pageTypeStrName"/>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>.aspx.cs" Inherits="</xsl:text>
    <xsl:value-of select="$pageTypeStrName"/>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text disable-output-escaping="yes">" %&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&lt;!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"&gt;&#xD;&#xA;</xsl:text>
  </xsl:template>
</xsl:stylesheet>
