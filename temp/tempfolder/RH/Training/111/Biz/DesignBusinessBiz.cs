using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_DesignBusiness ( RH_DesignBusiness ) Biz类
    ///</summary>
    public class DesignBusinessBiz
    {

        /// <summary>
        /// 添加RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="void"></returns>
        public void AddDesignBusiness(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBusinessDao designBusinessDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designBusinessDao = new DesignBusinessDao();

                //执行DAO操作
                designBusinessDao.Insert(curConnectionEntity, paramDesignBusiness);

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
        /// 修改RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDesignBusiness(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBusinessDao designBusinessDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designBusinessDao = new DesignBusinessDao();

                //执行DAO操作
                designBusinessDao.Update(curConnectionEntity, paramDesignBusiness);

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
        /// 删除RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDesignBusiness(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBusinessDao designBusinessDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designBusinessDao = new DesignBusinessDao();

                //执行DAO操作
                designBusinessDao.Delete(curConnectionEntity, paramDesignBusiness);

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
        /// 查看RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="void"></returns>
        public void FindDesignBusinessByPK(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBusinessDao designBusinessDao = null;

            DesignBusinessEntity designBusinessEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designBusinessDao = new DesignBusinessDao();

                //执行DAO操作
                designBusiness = designBusinessDao.SelectByPK(curConnectionEntity, paramDesignBusiness);

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

            return DesignBusiness;
        }

        /// <summary>
        /// 根据外键查找RH_DesignBusiness
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignBusinessEntity" type="DesignBusinessEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDesignBusinessByForeignKeys(Object paramConnectionEntity, DesignBusinessEntity paramDesignBusinessEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBusinessDao designBusinessDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designBusinessDao = new DesignBusinessDao();

                //执行DAO操作
                objDataTable = designBusinessDao.SelectAllDesignBusinessByForeignKeys(curConnectionEntity, paramDesignBusiness);

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