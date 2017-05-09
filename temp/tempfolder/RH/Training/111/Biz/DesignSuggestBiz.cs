using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_DesignSuggest ( RH_DesignSuggest ) Biz类
    ///</summary>
    public class DesignSuggestBiz
    {

        /// <summary>
        /// 添加RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void AddDesignSuggest(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestDao designSuggestDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSuggestDao = new DesignSuggestDao();

                //执行DAO操作
                designSuggestDao.Insert(curConnectionEntity, paramDesignSuggest);

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
        /// 修改RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDesignSuggest(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestDao designSuggestDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSuggestDao = new DesignSuggestDao();

                //执行DAO操作
                designSuggestDao.Update(curConnectionEntity, paramDesignSuggest);

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
        /// 删除RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDesignSuggest(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestDao designSuggestDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSuggestDao = new DesignSuggestDao();

                //执行DAO操作
                designSuggestDao.Delete(curConnectionEntity, paramDesignSuggest);

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
        /// 查看RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void FindDesignSuggestByPK(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestDao designSuggestDao = null;

            DesignSuggestEntity designSuggestEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSuggestDao = new DesignSuggestDao();

                //执行DAO操作
                designSuggest = designSuggestDao.SelectByPK(curConnectionEntity, paramDesignSuggest);

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

            return DesignSuggest;
        }

        /// <summary>
        /// 根据外键查找RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDesignSuggestByForeignKeys(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestDao designSuggestDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSuggestDao = new DesignSuggestDao();

                //执行DAO操作
                objDataTable = designSuggestDao.SelectAllDesignSuggestByForeignKeys(curConnectionEntity, paramDesignSuggest);

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