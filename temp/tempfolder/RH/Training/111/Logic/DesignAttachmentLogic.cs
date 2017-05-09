using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_DesignAttachment ( RH_DesignAttachment ) Logic类
    ///</summary>
    public class DesignAttachmentLogic
    {

        /// <summary>
        /// 添加RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void AddDesignAttachment(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignAttachmentBiz designAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designAttachmentBiz = new DesignAttachmentBiz();

                //执行Biz操作
                designAttachmentBiz.AddDesignAttachment(curConnectionEntity, paramDesignAttachment);

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
        /// 修改RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDesignAttachment(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignAttachmentBiz designAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designAttachmentBiz = new DesignAttachmentBiz();

                //执行Biz操作
                designAttachmentBiz.ModifyDesignAttachment(curConnectionEntity, paramDesignAttachment);

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
        /// 删除RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDesignAttachment(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignAttachmentBiz designAttachmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designAttachmentBiz = new DesignAttachmentBiz();

                //执行Biz操作
                designAttachmentBiz.RemoveDesignAttachment(curConnectionEntity, paramDesignAttachment);

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
        /// 查看RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void FindDesignAttachmentByPK(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignAttachmentBiz designAttachmentBiz = null;

            DesignAttachmentEntity designAttachmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designAttachmentBiz = new DesignAttachmentBiz();

                //执行Biz操作
                designAttachment = designAttachmentBiz.FindDesignAttachmentByPK(curConnectionEntity, paramDesignAttachment);

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

            return DesignAttachment;
        }

        /// <summary>
        /// 根据外键查找RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDesignAttachmentByForeignKeys(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignAttachmentBiz designAttachmentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designAttachmentBiz = new DesignAttachmentBiz();

                //执行Biz操作
                objDataTable = designAttachmentBiz.FindAllDesignAttachmentByForeignKeys(curConnectionEntity, paramDesignAttachment);

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