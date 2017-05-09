<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!-- 代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:variable name="pageTypeStrName" select="'Controller'" />
  <xsl:variable name="pageTypeEntity" select="'Entity'" />
  <xsl:variable name="pageTypeBL" select="'BL'" />

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
  <xsl:variable name="type_select_all">
    <xsl:text>查看全部</xsl:text>
    <xsl:value-of select="/tables/table/@Name"/>
  </xsl:variable>
  <xsl:output method="text"/>
  <xsl:template match="/">
    <xsl:apply-templates select="tables"/>
  </xsl:template>

  <!--字段对象-->
  <xsl:variable name="properties" select="/tables/table/column"/>

  <xsl:template match="/">
    <xsl:apply-templates select="tables"/>
  </xsl:template>

  <!--匹配tables元素 -->
  <xsl:template match="tables">
    <xsl:apply-templates select="table"/>
  </xsl:template>

  <!--匹配bean元素，实际代码生成在此完成-->
  <xsl:template match="table">
    <xsl:text disable-output-escaping="yes">using System;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Collections.Generic;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Linq;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Web;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Web.Mvc;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using </xsl:text>
    <xsl:value-of select="@namespace"/>.<xsl:value-of select="$pageTypeBL"/><xsl:text disable-output-escaping="yes">;&#xD;&#xA;using </xsl:text>
    <xsl:value-of select="@namespace"/>.<xsl:value-of select="$pageTypeEntity"/><xsl:text disable-output-escaping="yes">;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using RH.Utility.StringLib;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using Webdiyer.WebControls.Mvc;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>namespace </xsl:text>
    <!--输出包名-->
    <xsl:value-of select="@namespace"/>
    <xsl:text>.Web.</xsl:text>
    <xsl:value-of select="$pageTypeStrName"/>
    <xsl:text disable-output-escaping="yes">s&#xD;&#xA;{&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printNoteHead">
      <!--输出字段缺省值-->
      <xsl:with-param name="name" select="@Name"/>
      <xsl:with-param name="code" select="@Code"/>
    </xsl:call-template>
    <xsl:text>    public class </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:copy-of select="$pageTypeStrName"/>
    <xsl:text disable-output-escaping="yes"> : Controller&#xD;&#xA;    {&#xD;&#xA;</xsl:text>
    <!--输出基本方法-->
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Insert"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Modify"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_View"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Remove"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_List"/>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultParam"/>
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;}</xsl:text>
  </xsl:template>

  <!--输出新增方法-->
  <xsl:template name="printDefaultMethods_Insert">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_add"/>
    </xsl:call-template>
    <xsl:text>        public int </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>Add()</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK"/>
      <xsl:if test="position()&lt;last()">
        <xsl:call-template name="printDefaultValue">
          <!--输出字段缺省值-->
          <xsl:with-param name="type" select="@DataType"/>
          <xsl:with-param name="code" select="@ShowCode"/>
        </xsl:call-template>
      </xsl:if>
    </xsl:for-each>
    <xsl:text>&#xD;&#xA;            ////构建实体对象</xsl:text>
    <xsl:text>&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> entity = new </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text>();&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK"/>
      <xsl:if test="position()&lt;last()">
        <xsl:text>            entity.</xsl:text>
        <xsl:value-of select="@ShowCode"/>
        <xsl:text> = </xsl:text>
        <xsl:value-of select="@ShowCode"/>
        <xsl:text>;&#xD;&#xA;</xsl:text>
      </xsl:if>
    </xsl:for-each>
    <xsl:text>            int result = 0;&#xD;&#xA;</xsl:text>
    <xsl:text>            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text>               result = </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeBL"/>
    <xsl:text>.Add</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>(entity);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;            catch (Exception ex)&#xD;&#xA;</xsl:text>
    <xsl:text>            {&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog("*********************添加</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>(</xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text>)出错</xsl:text>
    <xsl:text>" + DateTime.Now + "**************************");&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog(ex.Message);&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            return result ;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出修改方法-->
  <xsl:template name="printDefaultMethods_Modify">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_modify"/>
    </xsl:call-template>
    <xsl:text>        public int </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>Modify()</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" order="descending"/>
      <xsl:call-template name="printDefaultValue">
        <!--输出字段缺省值-->
        <xsl:with-param name="type" select="@DataType"/>
        <xsl:with-param name="code" select="@ShowCode"/>
      </xsl:call-template>
    </xsl:for-each>
    <xsl:text>&#xD;&#xA;            ////构建实体对象</xsl:text>
    <xsl:text>&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> entity = new </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text>();&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK"/>
      <xsl:text>            entity.</xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text> = </xsl:text>
      <xsl:value-of select="@ShowCode"/>
      <xsl:text>;&#xD;&#xA;</xsl:text>
    </xsl:for-each>
    <xsl:text>            int result = 0;&#xD;&#xA;</xsl:text>
    <xsl:text>            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text>               result = </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeBL"/>
    <xsl:text>.Modify</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>(entity);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;            catch (Exception ex)&#xD;&#xA;</xsl:text>
    <xsl:text>            {&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog("*********************修改</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>(</xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text>)出错</xsl:text>
    <xsl:text>" + DateTime.Now + "**************************");&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog(ex.Message);&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            return result ;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出详情方法-->
  <xsl:template name="printDefaultMethods_View">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_select"/>
    </xsl:call-template>
    <xsl:text>        public ActionResult </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>View()</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" order="descending"/>
      <xsl:if test="position()=1">
        <xsl:call-template name="printDefaultValue">
          <!--输出字段缺省值-->
          <xsl:with-param name="type" select="@DataType"/>
          <xsl:with-param name="code" select="@ShowCode"/>
        </xsl:call-template>
      </xsl:if>
    </xsl:for-each>
    <xsl:text>&#xD;&#xA;            ////构建实体对象</xsl:text>
    <xsl:text>&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> entity = new </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text>();&#xD;&#xA;</xsl:text>

    <xsl:text>            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text>               entity = </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeBL"/>
    <xsl:text>.Get</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>Detail(</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" order="descending"/>
      <xsl:if test="position()=1">
        <xsl:value-of select="@ShowCode"/>
      </xsl:if>
    </xsl:for-each>
    <xsl:text>);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;            catch (Exception ex)&#xD;&#xA;</xsl:text>
    <xsl:text>            {&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog("*********************查看详情</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>(</xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text>)出错</xsl:text>
    <xsl:text>" + DateTime.Now + "**************************");&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog(ex.Message);&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            return View(entity) ;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出删除方法-->
  <xsl:template name="printDefaultMethods_Remove">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_removed"/>
    </xsl:call-template>
    <xsl:text>        public int </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>Remove()</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" order="descending"/>
      <xsl:if test="position()=1">
        <xsl:call-template name="printDefaultValue">
          <!--输出字段缺省值-->
          <xsl:with-param name="type" select="@DataType"/>
          <xsl:with-param name="code" select="@ShowCode"/>
        </xsl:call-template>
      </xsl:if>
    </xsl:for-each>
    <xsl:text>            int result = 0;&#xD;&#xA;</xsl:text>
    <xsl:text>&#xD;&#xA;            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text>               result = </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeBL"/>
    <xsl:text>.Remove</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>(</xsl:text>
    <xsl:for-each select="$properties">
      <xsl:sort select="@PK" order="descending"/>
      <xsl:if test="position()=1">
        <xsl:value-of select="@ShowCode"/>
      </xsl:if>
    </xsl:for-each>
    <xsl:text>);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;            catch (Exception ex)&#xD;&#xA;</xsl:text>
    <xsl:text>            {&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog("*********************删除</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>(</xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text>)出错</xsl:text>
    <xsl:text>" + DateTime.Now + "**************************");&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog(ex.Message);&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            return result ;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出列表查询方法-->
  <xsl:template name="printDefaultMethods_List">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_select_all"/>
    </xsl:call-template>
    <xsl:text>        public ActionResult </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>List()</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text>            //</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="@Name"/>
    <xsl:text>&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>EntityListResult listResult = new </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>EntityListResult();&#xD;&#xA;</xsl:text>
    <xsl:text>&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>Searcher Searcher = new </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>Searcher();&#xD;&#xA;</xsl:text>
    <xsl:text>&#xD;&#xA;            //查询条件设置</xsl:text>
    <xsl:text>&#xD;&#xA;            Searcher.PageSize = PageSize;</xsl:text>
    <xsl:text>&#xD;&#xA;            Searcher.PageIndex = PageIndex - 1;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            PagedList&lt;</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text disable-output-escaping="yes">Info&gt; mPage = null;</xsl:text>
    <xsl:text>&#xD;&#xA;            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text>               listResult = </xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:value-of select="$pageTypeBL"/>
    <xsl:text>.Get</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>EntityList(Searcher);</xsl:text>
    <xsl:text>&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">               if(listResult.TotalCount &gt; 0)&#xD;&#xA;</xsl:text>
    <xsl:text>               {&#xD;&#xA;</xsl:text>
    <xsl:text>                  mPage = listResult.</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>List.AsQueryable().ToPagedList(1, PageSize);&#xD;&#xA;</xsl:text>
    <xsl:text>                  mPage.TotalItemCount = listResult.TotalCount;&#xD;&#xA;</xsl:text>
    <xsl:text>                  mPage.CurrentPageIndex = PageIndex;&#xD;&#xA;</xsl:text>
    <xsl:text>               }&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;            catch (Exception ex)&#xD;&#xA;</xsl:text>
    <xsl:text>            {&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog("*********************删除</xsl:text>
    <xsl:value-of select="@ShowCode"/>
    <xsl:text>(</xsl:text>
    <xsl:value-of select="@Name"/>
    <xsl:text>)出错</xsl:text>
    <xsl:text>" + DateTime.Now + "**************************");&#xD;&#xA;</xsl:text>
    <xsl:text>               FileLib.SaveInfoToLog(ex.Message);&#xD;&#xA;</xsl:text>
    <xsl:text>            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>            return View(mPage) ;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;       }&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--参数属性-->
  <xsl:template name="printDefaultParam">

    <xsl:text>        #region 属性&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// 当前页码&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public int PageIndex &#xD;&#xA;</xsl:text>
    <xsl:text>        { &#xD;&#xA;</xsl:text>
    <xsl:text>           get &#xD;&#xA;</xsl:text>
    <xsl:text>           { &#xD;&#xA;</xsl:text>
    <xsl:text>              if (string.IsNullOrEmpty(Request["page"])) &#xD;&#xA;</xsl:text>
    <xsl:text>              {&#xD;&#xA;</xsl:text>
    <xsl:text>                 return 1;&#xD;&#xA;</xsl:text>
    <xsl:text>              }&#xD;&#xA;</xsl:text>
    <xsl:text>              else&#xD;&#xA;</xsl:text>
    <xsl:text>              {&#xD;&#xA;</xsl:text>
    <xsl:text>                 int i;&#xD;&#xA;</xsl:text>
    <xsl:text>                 return int.TryParse(Request["page"], out i) ? int.Parse(Request["page"]) : 1;&#xD;&#xA;</xsl:text>
    <xsl:text>              }&#xD;&#xA;</xsl:text>
    <xsl:text>           }&#xD;&#xA;</xsl:text>
    <xsl:text>        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// 每页数量&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;/summary&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public int PageSize &#xD;&#xA;</xsl:text>
    <xsl:text>        { &#xD;&#xA;</xsl:text>
    <xsl:text>           get &#xD;&#xA;</xsl:text>
    <xsl:text>           { &#xD;&#xA;</xsl:text>
    <xsl:text>              if (string.IsNullOrEmpty(Request["PageSize"])) &#xD;&#xA;</xsl:text>
    <xsl:text>              {&#xD;&#xA;</xsl:text>
    <xsl:text>                 return 10;&#xD;&#xA;</xsl:text>
    <xsl:text>              }&#xD;&#xA;</xsl:text>
    <xsl:text>              else&#xD;&#xA;</xsl:text>
    <xsl:text>              {&#xD;&#xA;</xsl:text>
    <xsl:text>                 int i;&#xD;&#xA;</xsl:text>
    <xsl:text>                 return int.TryParse(Request["PageSize"], out i) ? int.Parse(Request["PageSize"]) : 10;&#xD;&#xA;</xsl:text>
    <xsl:text>              }&#xD;&#xA;</xsl:text>
    <xsl:text>           }&#xD;&#xA;</xsl:text>
    <xsl:text>        }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text>        #endregion&#xD;&#xA;&#xD;&#xA;</xsl:text>

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

  <xsl:template name="printDefaultValue">
    <xsl:param name="type"/>
    <xsl:param name="code"/>
    <xsl:choose>
      <xsl:when test="contains($type,'int')">
        <xsl:text>            int </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? 0 : int.Parse(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"]);&#xD;&#xA;</xsl:text>
      </xsl:when>

      <xsl:when test="contains($type,'datetime')">
        <xsl:text>            DateTime </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? DateTime.Now : DateTime.Parse(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"]);&#xD;&#xA;</xsl:text>
      </xsl:when>

      <xsl:when test="contains($type,'boolean')">
        <xsl:text>            bool </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? false : bool.Parse(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"]);&#xD;&#xA;</xsl:text>
      </xsl:when>

      <xsl:when test="contains($type,'long')">
        <xsl:text>            long </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? 0 : long.Parse(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"]);&#xD;&#xA;</xsl:text>
      </xsl:when>

      <xsl:when test="contains($type,'float')">
        <xsl:text>            float </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? 0 : float.Parse(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"]);&#xD;&#xA;</xsl:text>
      </xsl:when>

      <xsl:when test="contains($type,'image')">
        <xsl:text>            byte[] </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? null : (byte[])(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"]);&#xD;&#xA;</xsl:text>
      </xsl:when>

      <xsl:when test="contains($type,'varchar')">
        <xsl:text>            string </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? "" : Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"].ToString();&#xD;&#xA;</xsl:text>
      </xsl:when>

      <xsl:when test="contains($type,'decimal')">
        <xsl:text>            decimal </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? 0 : decimal.Parse(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"]);&#xD;&#xA;</xsl:text>
      </xsl:when>
      <xsl:otherwise>
        <xsl:text>            string </xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text> = string.IsNullOrEmpty(Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"])? "" : Request["</xsl:text>
        <xsl:value-of select="$code"/>
        <xsl:text>"].ToString();&#xD;&#xA;</xsl:text>
      </xsl:otherwise>

    </xsl:choose>
  </xsl:template>

</xsl:stylesheet>