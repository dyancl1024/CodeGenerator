using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Expert ( RH_Expert ) Logic类
    ///</summary>
    public class ExpertLogic
    {

        /// <summary>
        /// 添加RH_Expert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramExpertEntity" type="ExpertEntity"></param>
        /// <returns type="void"></returns>
        public void AddExpert(Object paramConnectionEntity, ExpertEntity paramExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ExpertBiz expertBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                expertBiz = new ExpertBiz();

                //执行Biz操作
                expertBiz.AddExpert(curConnectionEntity, paramExpert);

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
        /// 修改RH_Expert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramExpertEntity" type="ExpertEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyExpert(Object paramConnectionEntity, ExpertEntity paramExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ExpertBiz expertBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                expertBiz = new ExpertBiz();

                //执行Biz操作
                expertBiz.ModifyExpert(curConnectionEntity, paramExpert);

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
        /// 删除RH_Expert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramExpertEntity" type="ExpertEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveExpert(Object paramConnectionEntity, ExpertEntity paramExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ExpertBiz expertBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                expertBiz = new ExpertBiz();

                //执行Biz操作
                expertBiz.RemoveExpert(curConnectionEntity, paramExpert);

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
        /// 查看RH_Expert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramExpertEntity" type="ExpertEntity"></param>
        /// <returns type="void"></returns>
        public void FindExpertByPK(Object paramConnectionEntity, ExpertEntity paramExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ExpertBiz expertBiz = null;

            ExpertEntity expertEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                expertBiz = new ExpertBiz();

                //执行Biz操作
                expert = expertBiz.FindExpertByPK(curConnectionEntity, paramExpert);

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

            return Expert;
        }

        /// <summary>
        /// 根据外键查找RH_Expert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramExpertEntity" type="ExpertEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllExpertByForeignKeys(Object paramConnectionEntity, ExpertEntity paramExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ExpertBiz expertBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                expertBiz = new ExpertBiz();

                //执行Biz操作
                objDataTable = expertBiz.FindAllExpertByForeignKeys(curConnectionEntity, paramExpert);

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