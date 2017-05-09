using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingClassRule ( RH_TrainingClassRule ) Logic类
    ///</summary>
    public class TrainingClassRuleLogic
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

            TrainingClassRuleBiz trainingClassRuleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassRuleBiz = new TrainingClassRuleBiz();

                //执行Biz操作
                trainingClassRuleBiz.AddTrainingClassRule(curConnectionEntity, paramTrainingClassRule);

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

            TrainingClassRuleBiz trainingClassRuleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassRuleBiz = new TrainingClassRuleBiz();

                //执行Biz操作
                trainingClassRuleBiz.ModifyTrainingClassRule(curConnectionEntity, paramTrainingClassRule);

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

            TrainingClassRuleBiz trainingClassRuleBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassRuleBiz = new TrainingClassRuleBiz();

                //执行Biz操作
                trainingClassRuleBiz.RemoveTrainingClassRule(curConnectionEntity, paramTrainingClassRule);

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

            TrainingClassRuleBiz trainingClassRuleBiz = null;

            TrainingClassRuleEntity trainingClassRuleEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassRuleBiz = new TrainingClassRuleBiz();

                //执行Biz操作
                trainingClassRule = trainingClassRuleBiz.FindTrainingClassRuleByPK(curConnectionEntity, paramTrainingClassRule);

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

            TrainingClassRuleBiz trainingClassRuleBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassRuleBiz = new TrainingClassRuleBiz();

                //执行Biz操作
                objDataTable = trainingClassRuleBiz.FindAllTrainingClassRuleByForeignKeys(curConnectionEntity, paramTrainingClassRule);

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