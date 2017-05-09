using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_UserSubjectRule ( RH_UserSubjectRule ) Biz类
    ///</summary>
    public class UserSubjectRuleBiz
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

            UserSubjectRuleDao userSubjectRuleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userSubjectRuleDao = new UserSubjectRuleDao();

                //执行DAO操作
                userSubjectRuleDao.Insert(curConnectionEntity, paramUserSubjectRule);

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

            UserSubjectRuleDao userSubjectRuleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userSubjectRuleDao = new UserSubjectRuleDao();

                //执行DAO操作
                userSubjectRuleDao.Update(curConnectionEntity, paramUserSubjectRule);

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

            UserSubjectRuleDao userSubjectRuleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userSubjectRuleDao = new UserSubjectRuleDao();

                //执行DAO操作
                userSubjectRuleDao.Delete(curConnectionEntity, paramUserSubjectRule);

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

            UserSubjectRuleDao userSubjectRuleDao = null;

            UserSubjectRuleEntity userSubjectRuleEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userSubjectRuleDao = new UserSubjectRuleDao();

                //执行DAO操作
                userSubjectRule = userSubjectRuleDao.SelectByPK(curConnectionEntity, paramUserSubjectRule);

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

            UserSubjectRuleDao userSubjectRuleDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                userSubjectRuleDao = new UserSubjectRuleDao();

                //执行DAO操作
                objDataTable = userSubjectRuleDao.SelectAllUserSubjectRuleByForeignKeys(curConnectionEntity, paramUserSubjectRule);

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