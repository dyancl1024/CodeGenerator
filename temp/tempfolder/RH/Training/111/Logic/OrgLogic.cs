using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Org ( RH_Org ) Logic类
    ///</summary>
    public class OrgLogic
    {

        /// <summary>
        /// 添加RH_Org
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramOrgEntity" type="OrgEntity"></param>
        /// <returns type="void"></returns>
        public void AddOrg(Object paramConnectionEntity, OrgEntity paramOrgEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            OrgBiz orgBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                orgBiz = new OrgBiz();

                //执行Biz操作
                orgBiz.AddOrg(curConnectionEntity, paramOrg);

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
        /// 修改RH_Org
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramOrgEntity" type="OrgEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyOrg(Object paramConnectionEntity, OrgEntity paramOrgEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            OrgBiz orgBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                orgBiz = new OrgBiz();

                //执行Biz操作
                orgBiz.ModifyOrg(curConnectionEntity, paramOrg);

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
        /// 删除RH_Org
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramOrgEntity" type="OrgEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveOrg(Object paramConnectionEntity, OrgEntity paramOrgEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            OrgBiz orgBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                orgBiz = new OrgBiz();

                //执行Biz操作
                orgBiz.RemoveOrg(curConnectionEntity, paramOrg);

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
        /// 查看RH_Org
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramOrgEntity" type="OrgEntity"></param>
        /// <returns type="void"></returns>
        public void FindOrgByPK(Object paramConnectionEntity, OrgEntity paramOrgEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            OrgBiz orgBiz = null;

            OrgEntity orgEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                orgBiz = new OrgBiz();

                //执行Biz操作
                org = orgBiz.FindOrgByPK(curConnectionEntity, paramOrg);

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

            return Org;
        }

        /// <summary>
        /// 根据外键查找RH_Org
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramOrgEntity" type="OrgEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllOrgByForeignKeys(Object paramConnectionEntity, OrgEntity paramOrgEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            OrgBiz orgBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                orgBiz = new OrgBiz();

                //执行Biz操作
                objDataTable = orgBiz.FindAllOrgByForeignKeys(curConnectionEntity, paramOrg);

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