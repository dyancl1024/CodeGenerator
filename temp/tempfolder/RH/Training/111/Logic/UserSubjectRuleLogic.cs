using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_UserSubjectRule ( RH_UserSubjectRule ) Logic类
    ///</summary>
    public class UserSubjectRuleLogic
    {

        /// <summary>
        /// 添加RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="void"></returns>
        public void AddUserSubjectRule(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserSubjectRuleBiz userSubjectRuleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userSubjectRuleBiz = new UserSubjectRuleBiz();

                //执行Biz操作
                userSubjectRuleBiz.AddUserSubjectRule(curConnectionEntity, paramUserSubjectRule);

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
        /// 修改RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyUserSubjectRule(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserSubjectRuleBiz userSubjectRuleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userSubjectRuleBiz = new UserSubjectRuleBiz();

                //执行Biz操作
                userSubjectRuleBiz.ModifyUserSubjectRule(curConnectionEntity, paramUserSubjectRule);

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
        /// 删除RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveUserSubjectRule(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserSubjectRuleBiz userSubjectRuleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userSubjectRuleBiz = new UserSubjectRuleBiz();

                //执行Biz操作
                userSubjectRuleBiz.RemoveUserSubjectRule(curConnectionEntity, paramUserSubjectRule);

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
        /// 查看RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="void"></returns>
        public void FindUserSubjectRuleByPK(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserSubjectRuleBiz userSubjectRuleBiz = null;

            UserSubjectRuleEntity userSubjectRuleEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userSubjectRuleBiz = new UserSubjectRuleBiz();

                //执行Biz操作
                userSubjectRule = userSubjectRuleBiz.FindUserSubjectRuleByPK(curConnectionEntity, paramUserSubjectRule);

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

            return UserSubjectRule;
        }

        /// <summary>
        /// 根据外键查找RH_UserSubjectRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramUserSubjectRuleEntity" type="UserSubjectRuleEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllUserSubjectRuleByForeignKeys(Object paramConnectionEntity, UserSubjectRuleEntity paramUserSubjectRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            UserSubjectRuleBiz userSubjectRuleBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                userSubjectRuleBiz = new UserSubjectRuleBiz();

                //执行Biz操作
                objDataTable = userSubjectRuleBiz.FindAllUserSubjectRuleByForeignKeys(curConnectionEntity, paramUserSubjectRule);

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