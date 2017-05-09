using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_MngRoleRight ( RH_MngRoleRight ) Logic类
    ///</summary>
    public class MngRoleRightLogic
    {

        /// <summary>
        /// 添加RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void AddMngRoleRight(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightBiz mngRoleRightBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleRightBiz = new MngRoleRightBiz();

                //执行Biz操作
                mngRoleRightBiz.AddMngRoleRight(curConnectionEntity, paramMngRoleRight);

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
        /// 修改RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyMngRoleRight(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightBiz mngRoleRightBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleRightBiz = new MngRoleRightBiz();

                //执行Biz操作
                mngRoleRightBiz.ModifyMngRoleRight(curConnectionEntity, paramMngRoleRight);

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
        /// 删除RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveMngRoleRight(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightBiz mngRoleRightBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleRightBiz = new MngRoleRightBiz();

                //执行Biz操作
                mngRoleRightBiz.RemoveMngRoleRight(curConnectionEntity, paramMngRoleRight);

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
        /// 查看RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public void FindMngRoleRightByPK(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightBiz mngRoleRightBiz = null;

            MngRoleRightEntity mngRoleRightEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleRightBiz = new MngRoleRightBiz();

                //执行Biz操作
                mngRoleRight = mngRoleRightBiz.FindMngRoleRightByPK(curConnectionEntity, paramMngRoleRight);

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

            return MngRoleRight;
        }

        /// <summary>
        /// 根据外键查找RH_MngRoleRight
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngRoleRightEntity" type="MngRoleRightEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllMngRoleRightByForeignKeys(Object paramConnectionEntity, MngRoleRightEntity paramMngRoleRightEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngRoleRightBiz mngRoleRightBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleRightBiz = new MngRoleRightBiz();

                //执行Biz操作
                objDataTable = mngRoleRightBiz.FindAllMngRoleRightByForeignKeys(curConnectionEntity, paramMngRoleRight);

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