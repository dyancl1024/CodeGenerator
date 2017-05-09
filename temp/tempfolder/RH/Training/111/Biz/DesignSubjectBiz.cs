using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_DesignSubject ( RH_DesignSubject ) Biz类
    ///</summary>
    public class DesignSubjectBiz
    {

        /// <summary>
        /// 添加RH_DesignSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSubjectEntity" type="DesignSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void AddDesignSubject(Object paramConnectionEntity, DesignSubjectEntity paramDesignSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSubjectDao designSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSubjectDao = new DesignSubjectDao();

                //执行DAO操作
                designSubjectDao.Insert(curConnectionEntity, paramDesignSubject);

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
        /// 修改RH_DesignSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSubjectEntity" type="DesignSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDesignSubject(Object paramConnectionEntity, DesignSubjectEntity paramDesignSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSubjectDao designSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSubjectDao = new DesignSubjectDao();

                //执行DAO操作
                designSubjectDao.Update(curConnectionEntity, paramDesignSubject);

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
        /// 删除RH_DesignSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSubjectEntity" type="DesignSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDesignSubject(Object paramConnectionEntity, DesignSubjectEntity paramDesignSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSubjectDao designSubjectDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSubjectDao = new DesignSubjectDao();

                //执行DAO操作
                designSubjectDao.Delete(curConnectionEntity, paramDesignSubject);

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
        /// 查看RH_DesignSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSubjectEntity" type="DesignSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void FindDesignSubjectByPK(Object paramConnectionEntity, DesignSubjectEntity paramDesignSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSubjectDao designSubjectDao = null;

            DesignSubjectEntity designSubjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSubjectDao = new DesignSubjectDao();

                //执行DAO操作
                designSubject = designSubjectDao.SelectByPK(curConnectionEntity, paramDesignSubject);

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

            return DesignSubject;
        }

        /// <summary>
        /// 根据外键查找RH_DesignSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSubjectEntity" type="DesignSubjectEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDesignSubjectByForeignKeys(Object paramConnectionEntity, DesignSubjectEntity paramDesignSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSubjectDao designSubjectDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designSubjectDao = new DesignSubjectDao();

                //执行DAO操作
                objDataTable = designSubjectDao.SelectAllDesignSubjectByForeignKeys(curConnectionEntity, paramDesignSubject);

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