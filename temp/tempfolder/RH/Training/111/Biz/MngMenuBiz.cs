using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_MngMenu ( RH_MngMenu ) Biz类
    ///</summary>
    public class MngMenuBiz
    {

        /// <summary>
        /// 添加RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="void"></returns>
        public void AddMngMenu(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngMenuDao mngMenuDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngMenuDao = new MngMenuDao();

                //执行DAO操作
                mngMenuDao.Insert(curConnectionEntity, paramMngMenu);

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
        /// 修改RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyMngMenu(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngMenuDao mngMenuDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngMenuDao = new MngMenuDao();

                //执行DAO操作
                mngMenuDao.Update(curConnectionEntity, paramMngMenu);

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
        /// 删除RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveMngMenu(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngMenuDao mngMenuDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngMenuDao = new MngMenuDao();

                //执行DAO操作
                mngMenuDao.Delete(curConnectionEntity, paramMngMenu);

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
        /// 查看RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="void"></returns>
        public void FindMngMenuByPK(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngMenuDao mngMenuDao = null;

            MngMenuEntity mngMenuEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngMenuDao = new MngMenuDao();

                //执行DAO操作
                mngMenu = mngMenuDao.SelectByPK(curConnectionEntity, paramMngMenu);

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

            return MngMenu;
        }

        /// <summary>
        /// 根据外键查找RH_MngMenu
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngMenuEntity" type="MngMenuEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllMngMenuByForeignKeys(Object paramConnectionEntity, MngMenuEntity paramMngMenuEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngMenuDao mngMenuDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                mngMenuDao = new MngMenuDao();

                //执行DAO操作
                objDataTable = mngMenuDao.SelectAllMngMenuByForeignKeys(curConnectionEntity, paramMngMenu);

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