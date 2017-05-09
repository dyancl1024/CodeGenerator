using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_DesignContent ( RH_DesignContent ) Logic类
    ///</summary>
    public class DesignContentLogic
    {

        /// <summary>
        /// 添加RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="void"></returns>
        public void AddDesignContent(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentBiz designContentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designContentBiz = new DesignContentBiz();

                //执行Biz操作
                designContentBiz.AddDesignContent(curConnectionEntity, paramDesignContent);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }
        }

        /// <summary>
        /// 修改RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDesignContent(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentBiz designContentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designContentBiz = new DesignContentBiz();

                //执行Biz操作
                designContentBiz.ModifyDesignContent(curConnectionEntity, paramDesignContent);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }
        }

        /// <summary>
        /// 删除RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDesignContent(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentBiz designContentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designContentBiz = new DesignContentBiz();

                //执行Biz操作
                designContentBiz.RemoveDesignContent(curConnectionEntity, paramDesignContent);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }
        }

        /// <summary>
        /// 查看RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="void"></returns>
        public void FindDesignContentByPK(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentBiz designContentBiz = null;

            DesignContentEntity designContentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designContentBiz = new DesignContentBiz();

                //执行Biz操作
                designContent = designContentBiz.FindDesignContentByPK(curConnectionEntity, paramDesignContent);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }

            return DesignContent;
        }

        /// <summary>
        /// 根据外键查找RH_DesignContent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentEntity" type="DesignContentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDesignContentByForeignKeys(Object paramConnectionEntity, DesignContentEntity paramDesignContentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentBiz designContentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designContentBiz = new DesignContentBiz();

                //执行Biz操作
                objDataTable = designContentBiz.FindAllDesignContentByForeignKeys(curConnectionEntity, paramDesignContent);

                //事务提交
                ConnectionManager.CheckAndCommit(paramConnectionEntity, curConnectionEntity);
                //-----------结束业务逻辑-------------

            }
            catch (Exception e)
            {
                //事务回滚
                ConnectionManager.CheckAndRollback(paramConnectionEntity, curConnectionEntity);
                throw e;
            }
            finally
            {
                //释放数据库连接参数
                ConnectionManager.CheckAndReleaseConnection(paramConnectionEntity, curConnectionEntity);
            }

            return objDataTable;
        }
    }
}