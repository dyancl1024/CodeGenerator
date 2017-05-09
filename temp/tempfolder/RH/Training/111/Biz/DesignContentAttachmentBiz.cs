using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_DesignContentAttachment ( RH_DesignContentAttachment ) Biz类
    ///</summary>
    public class DesignContentAttachmentBiz
    {

        /// <summary>
        /// 添加RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void AddDesignContentAttachment(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentAttachmentDao designContentAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentAttachmentDao = new DesignContentAttachmentDao();

                //执行DAO操作
                designContentAttachmentDao.Insert(curConnectionEntity, paramDesignContentAttachment);

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
        /// 修改RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDesignContentAttachment(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentAttachmentDao designContentAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentAttachmentDao = new DesignContentAttachmentDao();

                //执行DAO操作
                designContentAttachmentDao.Update(curConnectionEntity, paramDesignContentAttachment);

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
        /// 删除RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDesignContentAttachment(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentAttachmentDao designContentAttachmentDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentAttachmentDao = new DesignContentAttachmentDao();

                //执行DAO操作
                designContentAttachmentDao.Delete(curConnectionEntity, paramDesignContentAttachment);

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
        /// 查看RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void FindDesignContentAttachmentByPK(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentAttachmentDao designContentAttachmentDao = null;

            DesignContentAttachmentEntity designContentAttachmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentAttachmentDao = new DesignContentAttachmentDao();

                //执行DAO操作
                designContentAttachment = designContentAttachmentDao.SelectByPK(curConnectionEntity, paramDesignContentAttachment);

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

            return DesignContentAttachment;
        }

        /// <summary>
        /// 根据外键查找RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDesignContentAttachmentByForeignKeys(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignContentAttachmentDao designContentAttachmentDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                designContentAttachmentDao = new DesignContentAttachmentDao();

                //执行DAO操作
                objDataTable = designContentAttachmentDao.SelectAllDesignContentAttachmentByForeignKeys(curConnectionEntity, paramDesignContentAttachment);

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