using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_MngRole ( RH_MngRole ) Logic类
    ///</summary>
    public class MngRoleLogic
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

            MngRoleBiz mngRoleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleBiz = new MngRoleBiz();

                //执行Biz操作
                mngRoleBiz.AddMngRole(curConnectionEntity, paramMngRole);

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

            MngRoleBiz mngRoleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleBiz = new MngRoleBiz();

                //执行Biz操作
                mngRoleBiz.ModifyMngRole(curConnectionEntity, paramMngRole);

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

            MngRoleBiz mngRoleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleBiz = new MngRoleBiz();

                //执行Biz操作
                mngRoleBiz.RemoveMngRole(curConnectionEntity, paramMngRole);

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

            MngRoleBiz mngRoleBiz = null;

            MngRoleEntity mngRoleEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleBiz = new MngRoleBiz();

                //执行Biz操作
                mngRole = mngRoleBiz.FindMngRoleByPK(curConnectionEntity, paramMngRole);

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

            MngRoleBiz mngRoleBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngRoleBiz = new MngRoleBiz();

                //执行Biz操作
                objDataTable = mngRoleBiz.FindAllMngRoleByForeignKeys(curConnectionEntity, paramMngRole);

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