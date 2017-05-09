using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Postion ( RH_Postion ) Logic类
    ///</summary>
    public class PostionLogic
    {

        /// <summary>
        /// 添加RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="void"></returns>
        public void AddPostion(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            PostionBiz postionBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                postionBiz = new PostionBiz();

                //执行Biz操作
                postionBiz.AddPostion(curConnectionEntity, paramPostion);

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
        /// 修改RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyPostion(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            PostionBiz postionBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                postionBiz = new PostionBiz();

                //执行Biz操作
                postionBiz.ModifyPostion(curConnectionEntity, paramPostion);

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
        /// 删除RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="void"></returns>
        public void RemovePostion(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            PostionBiz postionBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                postionBiz = new PostionBiz();

                //执行Biz操作
                postionBiz.RemovePostion(curConnectionEntity, paramPostion);

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
        /// 查看RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="void"></returns>
        public void FindPostionByPK(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            PostionBiz postionBiz = null;

            PostionEntity postionEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                postionBiz = new PostionBiz();

                //执行Biz操作
                postion = postionBiz.FindPostionByPK(curConnectionEntity, paramPostion);

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

            return Postion;
        }

        /// <summary>
        /// 根据外键查找RH_Postion
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramPostionEntity" type="PostionEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllPostionByForeignKeys(Object paramConnectionEntity, PostionEntity paramPostionEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            PostionBiz postionBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                postionBiz = new PostionBiz();

                //执行Biz操作
                objDataTable = postionBiz.FindAllPostionByForeignKeys(curConnectionEntity, paramPostion);

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