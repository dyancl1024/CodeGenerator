using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_DesignSuggest ( RH_DesignSuggest ) Logic类
    ///</summary>
    public class DesignSuggestLogic
    {

        /// <summary>
        /// 添加RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void AddDesignSuggest(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestBiz designSuggestBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designSuggestBiz = new DesignSuggestBiz();

                //执行Biz操作
                designSuggestBiz.AddDesignSuggest(curConnectionEntity, paramDesignSuggest);

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
        /// 修改RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDesignSuggest(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestBiz designSuggestBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designSuggestBiz = new DesignSuggestBiz();

                //执行Biz操作
                designSuggestBiz.ModifyDesignSuggest(curConnectionEntity, paramDesignSuggest);

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
        /// 删除RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDesignSuggest(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestBiz designSuggestBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designSuggestBiz = new DesignSuggestBiz();

                //执行Biz操作
                designSuggestBiz.RemoveDesignSuggest(curConnectionEntity, paramDesignSuggest);

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
        /// 查看RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public void FindDesignSuggestByPK(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestBiz designSuggestBiz = null;

            DesignSuggestEntity designSuggestEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designSuggestBiz = new DesignSuggestBiz();

                //执行Biz操作
                designSuggest = designSuggestBiz.FindDesignSuggestByPK(curConnectionEntity, paramDesignSuggest);

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

            return DesignSuggest;
        }

        /// <summary>
        /// 根据外键查找RH_DesignSuggest
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignSuggestEntity" type="DesignSuggestEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDesignSuggestByForeignKeys(Object paramConnectionEntity, DesignSuggestEntity paramDesignSuggestEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DesignSuggestBiz designSuggestBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                designSuggestBiz = new DesignSuggestBiz();

                //执行Biz操作
                objDataTable = designSuggestBiz.FindAllDesignSuggestByForeignKeys(curConnectionEntity, paramDesignSuggest);

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