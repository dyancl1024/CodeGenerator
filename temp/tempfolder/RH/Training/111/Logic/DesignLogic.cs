using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Design ( RH_Design ) Logic类
    ///</summary>
    public class DesignLogic
    {

        /// <summary>
        /// 添加RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="void"></returns>
        public void AddDesign(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBiz designBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designBiz = new DesignBiz();

                //执行Biz操作
                designBiz.AddDesign(curConnectionEntity, paramDesign);

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
        /// 修改RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDesign(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBiz designBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designBiz = new DesignBiz();

                //执行Biz操作
                designBiz.ModifyDesign(curConnectionEntity, paramDesign);

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
        /// 删除RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDesign(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBiz designBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designBiz = new DesignBiz();

                //执行Biz操作
                designBiz.RemoveDesign(curConnectionEntity, paramDesign);

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
        /// 查看RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="void"></returns>
        public void FindDesignByPK(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBiz designBiz = null;

            DesignEntity designEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designBiz = new DesignBiz();

                //执行Biz操作
                design = designBiz.FindDesignByPK(curConnectionEntity, paramDesign);

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

            return Design;
        }

        /// <summary>
        /// 根据外键查找RH_Design
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignEntity" type="DesignEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDesignByForeignKeys(Object paramConnectionEntity, DesignEntity paramDesignEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignBiz designBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designBiz = new DesignBiz();

                //执行Biz操作
                objDataTable = designBiz.FindAllDesignByForeignKeys(curConnectionEntity, paramDesign);

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