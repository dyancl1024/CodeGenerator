using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_MngRole ( RH_MngRole ) Biz类
    ///</summary>
    public class MngRoleBiz
    {

        /// <summary>
        /// 添加RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="void"></returns>
        public void AddMngRole(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleDao mngRoleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleDao = new MngRoleDao();

                //执行DAO操作
                mngRoleDao.Insert(curConnectionEntity, paramMngRole);

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
        /// 修改RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyMngRole(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleDao mngRoleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleDao = new MngRoleDao();

                //执行DAO操作
                mngRoleDao.Update(curConnectionEntity, paramMngRole);

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
        /// 删除RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveMngRole(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleDao mngRoleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleDao = new MngRoleDao();

                //执行DAO操作
                mngRoleDao.Delete(curConnectionEntity, paramMngRole);

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
        /// 查看RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="void"></returns>
        public void FindMngRoleByPK(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleDao mngRoleDao = null;

            MngRoleEntity mngRoleEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleDao = new MngRoleDao();

                //执行DAO操作
                mngRole = mngRoleDao.SelectByPK(curConnectionEntity, paramMngRole);

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

            return MngRole;
        }

        /// <summary>
        /// 根据外键查找RH_MngRole
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleEntity" type="MngRoleEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllMngRoleByForeignKeys(Object paramConnectionEntity, MngRoleEntity paramMngRoleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleDao mngRoleDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngRoleDao = new MngRoleDao();

                //执行DAO操作
                objDataTable = mngRoleDao.SelectAllMngRoleByForeignKeys(curConnectionEntity, paramMngRole);

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