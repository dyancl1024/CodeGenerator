using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_DesignContent ( RH_DesignContent ) Biz类
    ///</summary>
    public class DesignContentBiz
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

            DesignContentDao designContentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentDao = new DesignContentDao();

                //执行DAO操作
                designContentDao.Insert(curConnectionEntity, paramDesignContent);

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

            DesignContentDao designContentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentDao = new DesignContentDao();

                //执行DAO操作
                designContentDao.Update(curConnectionEntity, paramDesignContent);

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

            DesignContentDao designContentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentDao = new DesignContentDao();

                //执行DAO操作
                designContentDao.Delete(curConnectionEntity, paramDesignContent);

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

            DesignContentDao designContentDao = null;

            DesignContentEntity designContentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentDao = new DesignContentDao();

                //执行DAO操作
                designContent = designContentDao.SelectByPK(curConnectionEntity, paramDesignContent);

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

            DesignContentDao designContentDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentDao = new DesignContentDao();

                //执行DAO操作
                objDataTable = designContentDao.SelectAllDesignContentByForeignKeys(curConnectionEntity, paramDesignContent);

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