<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!-- 代码是文本格式的，所以需要设定输出方法为test-->
  <xsl:variable name="pageTypeStrName" select="'Biz'" />
  <xsl:variable name="pageTypeEntity" select="'Entity'" />
  <xsl:variable name="pageTypeDao" select="'Dao'" />

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
  <xsl:variable name="type_select_pk">
    <xsl:text>根据外键查找</xsl:text>
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

  <!--匹配tables元素 -->
  <xsl:template match="tables">
    <xsl:apply-templates select="table"/>
  </xsl:template>

  <!--匹配bean元素，实际代码生成在此完成-->
  <xsl:template match="table">
    <xsl:text disable-output-escaping="yes">using System;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Text;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">using System.Data.SqlClient;&#xD;&#xA;using </xsl:text>
    <xsl:value-of select="@namespace"/>.<xsl:value-of select="$pageTypeDao"/><xsl:text disable-output-escaping="yes">;&#xD;&#xA;&#xD;&#xA;</xsl:text>

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
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;</xsl:text>
    <xsl:call-template name="printDefaultMethods_Query"/>
    <!--输出基本方法-->
    <xsl:text disable-output-escaping="yes">    }&#xD;&#xA;}</xsl:text>
  </xsl:template>

  <!--输出新增方法-->
  <xsl:template name="printDefaultMethods_Insert">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_add"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="void"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public void Add</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DbConnectionEntity curConnectionEntity = null;&#xD;&#xA;&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes"> = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------开始业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //检查并初始化数据库连接&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //初始化DAO类&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //执行DAO操作&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text>.Insert</xsl:text>
    <xsl:text>(curConnectionEntity, param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务提交&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------结束业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务回滚&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放数据库连接参数&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出修改方法-->
  <xsl:template name="printDefaultMethods_Update">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_modify"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="void"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public void Modify</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DbConnectionEntity curConnectionEntity = null;&#xD;&#xA;&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes"> = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------开始业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //检查并初始化数据库连接&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //初始化DAO类&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //执行DAO操作&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text>.Update</xsl:text>
    <xsl:text>(curConnectionEntity, param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务提交&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------结束业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务回滚&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放数据库连接参数&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出删除方法-->
  <xsl:template name="printDefaultMethods_Delete">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_removed"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="void"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public void Remove</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DbConnectionEntity curConnectionEntity = null;&#xD;&#xA;&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes"> = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------开始业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //检查并初始化数据库连接&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //初始化DAO类&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //执行DAO操作&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text>.Delete</xsl:text>
    <xsl:text>(curConnectionEntity, param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务提交&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------结束业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务回滚&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放数据库连接参数&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出查看详情方法-->
  <xsl:template name="printDefaultMethods_View">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_select"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="void"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public void Find</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>ByPK</xsl:text>
    <xsl:text>(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DbConnectionEntity curConnectionEntity = null;&#xD;&#xA;&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes"> = null;&#xD;&#xA;&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes"> = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------开始业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //检查并初始化数据库连接&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //初始化DAO类&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //执行DAO操作&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="pageTypeEntity"/>
    <xsl:text> = </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text>.SelectByPK</xsl:text>
    <xsl:text>(curConnectionEntity, param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务提交&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------结束业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务回滚&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放数据库连接参数&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            return </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">;&#xD;&#xA;        }&#xD;&#xA;</xsl:text>
  </xsl:template>

  <!--输出查询方法-->
  <xsl:template name="printDefaultMethods_Query">
    <xsl:call-template name="printNote">
      <!--输出字段缺省值-->
      <xsl:with-param name="type" select="$type_select_pk"/>
    </xsl:call-template>
    <xsl:text disable-output-escaping="yes">        /// &lt;returns type="void"&gt;&lt;/returns&gt;&#xD;&#xA;</xsl:text>
    <xsl:text>        public DataTable FindAll</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>ByForeignKeys</xsl:text>
    <xsl:text>(Object paramConnectionEntity, </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text> param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">)&#xD;&#xA;        {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DbConnectionEntity curConnectionEntity = null;&#xD;&#xA;&#xD;&#xA;            </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes"> = null;&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            DataTable objDataTable = new DataTable();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            try&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------开始业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //检查并初始化数据库连接&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //初始化DAO类&#xD;&#xA;                </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text> = new </xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text disable-output-escaping="yes">();&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //执行DAO操作&#xD;&#xA;</xsl:text>
    <xsl:text>                objDataTable = </xsl:text>
    <xsl:call-template name="translateHeadLetterToLower">
      <xsl:with-param name="propertyName" select="/tables/table/@ShowCode"></xsl:with-param>
    </xsl:call-template>
    <xsl:value-of select="$pageTypeDao"/>
    <xsl:text>.SelectAll</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:text>ByForeignKeys</xsl:text>
    <xsl:text>(curConnectionEntity, param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">);&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务提交&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //-----------结束业务逻辑-------------&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">&#xD;&#xA;            }&#xD;&#xA;            catch (Exception e)&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //事务回滚&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                throw e;&#xD;&#xA;            }&#xD;&#xA;            finally&#xD;&#xA;            {&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                //释放数据库连接参数&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            }&#xD;&#xA;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">            return objDataTable;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        }&#xD;&#xA;</xsl:text>
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
    <xsl:text disable-output-escaping="yes">        /// &lt;param name="paramConnectionEntity" type="Object"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
    <xsl:text disable-output-escaping="yes">        /// &lt;param name="param</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text>" type="</xsl:text>
    <xsl:value-of select="/tables/table/@ShowCode"/>
    <xsl:value-of select="$pageTypeEntity"/>
    <xsl:text disable-output-escaping="yes">"&gt;&lt;/param&gt;&#xD;&#xA;</xsl:text>
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