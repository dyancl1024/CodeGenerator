using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_MngMenu ( RH_MngMenu ) Logic类
    ///</summary>
    public class MngMenuLogic
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

            MngMenuBiz mngMenuBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngMenuBiz = new MngMenuBiz();

                //执行Biz操作
                mngMenuBiz.AddMngMenu(curConnectionEntity, paramMngMenu);

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

            MngMenuBiz mngMenuBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngMenuBiz = new MngMenuBiz();

                //执行Biz操作
                mngMenuBiz.ModifyMngMenu(curConnectionEntity, paramMngMenu);

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

            MngMenuBiz mngMenuBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngMenuBiz = new MngMenuBiz();

                //执行Biz操作
                mngMenuBiz.RemoveMngMenu(curConnectionEntity, paramMngMenu);

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

            MngMenuBiz mngMenuBiz = null;

            MngMenuEntity mngMenuEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngMenuBiz = new MngMenuBiz();

                //执行Biz操作
                mngMenu = mngMenuBiz.FindMngMenuByPK(curConnectionEntity, paramMngMenu);

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

            MngMenuBiz mngMenuBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                mngMenuBiz = new MngMenuBiz();

                //执行Biz操作
                objDataTable = mngMenuBiz.FindAllMngMenuByForeignKeys(curConnectionEntity, paramMngMenu);

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