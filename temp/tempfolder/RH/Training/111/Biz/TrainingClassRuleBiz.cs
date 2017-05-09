using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_TrainingClassRule ( RH_TrainingClassRule ) Biz类
    ///</summary>
    public class TrainingClassRuleBiz
    {

        /// <summary>
        /// 添加RH_TrainingClassRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassRuleEntity" type="TrainingClassRuleEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingClassRule(Object paramConnectionEntity, TrainingClassRuleEntity paramTrainingClassRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassRuleDao trainingClassRuleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassRuleDao = new TrainingClassRuleDao();

                //执行DAO操作
                trainingClassRuleDao.Insert(curConnectionEntity, paramTrainingClassRule);

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
        /// 修改RH_TrainingClassRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassRuleEntity" type="TrainingClassRuleEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingClassRule(Object paramConnectionEntity, TrainingClassRuleEntity paramTrainingClassRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassRuleDao trainingClassRuleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassRuleDao = new TrainingClassRuleDao();

                //执行DAO操作
                trainingClassRuleDao.Update(curConnectionEntity, paramTrainingClassRule);

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
        /// 删除RH_TrainingClassRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassRuleEntity" type="TrainingClassRuleEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingClassRule(Object paramConnectionEntity, TrainingClassRuleEntity paramTrainingClassRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassRuleDao trainingClassRuleDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassRuleDao = new TrainingClassRuleDao();

                //执行DAO操作
                trainingClassRuleDao.Delete(curConnectionEntity, paramTrainingClassRule);

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
        /// 查看RH_TrainingClassRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassRuleEntity" type="TrainingClassRuleEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingClassRuleByPK(Object paramConnectionEntity, TrainingClassRuleEntity paramTrainingClassRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassRuleDao trainingClassRuleDao = null;

            TrainingClassRuleEntity trainingClassRuleEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassRuleDao = new TrainingClassRuleDao();

                //执行DAO操作
                trainingClassRule = trainingClassRuleDao.SelectByPK(curConnectionEntity, paramTrainingClassRule);

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

            return TrainingClassRule;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingClassRule
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassRuleEntity" type="TrainingClassRuleEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingClassRuleByForeignKeys(Object paramConnectionEntity, TrainingClassRuleEntity paramTrainingClassRuleEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassRuleDao trainingClassRuleDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                trainingClassRuleDao = new TrainingClassRuleDao();

                //执行DAO操作
                objDataTable = trainingClassRuleDao.SelectAllTrainingClassRuleByForeignKeys(curConnectionEntity, paramTrainingClassRule);

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