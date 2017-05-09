using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_MngUser ( RH_MngUser ) Logic类
    ///</summary>
    public class MngUserLogic
    {

        /// <summary>
        /// 添加RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void AddMngUser(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserBiz mngUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngUserBiz = new MngUserBiz();

                //执行Biz操作
                mngUserBiz.AddMngUser(curConnectionEntity, paramMngUser);

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
        /// 修改RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyMngUser(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserBiz mngUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngUserBiz = new MngUserBiz();

                //执行Biz操作
                mngUserBiz.ModifyMngUser(curConnectionEntity, paramMngUser);

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
        /// 删除RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveMngUser(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserBiz mngUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngUserBiz = new MngUserBiz();

                //执行Biz操作
                mngUserBiz.RemoveMngUser(curConnectionEntity, paramMngUser);

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
        /// 查看RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public void FindMngUserByPK(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserBiz mngUserBiz = null;

            MngUserEntity mngUserEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngUserBiz = new MngUserBiz();

                //执行Biz操作
                mngUser = mngUserBiz.FindMngUserByPK(curConnectionEntity, paramMngUser);

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

            return MngUser;
        }

        /// <summary>
        /// 根据外键查找RH_MngUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramMngUserEntity" type="MngUserEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllMngUserByForeignKeys(Object paramConnectionEntity, MngUserEntity paramMngUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            MngUserBiz mngUserBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngUserBiz = new MngUserBiz();

                //执行Biz操作
                objDataTable = mngUserBiz.FindAllMngUserByForeignKeys(curConnectionEntity, paramMngUser);

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