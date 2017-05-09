using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingPhase ( RH_TrainingPhase ) Logic类
    ///</summary>
    public class TrainingPhaseLogic
    {

        /// <summary>
        /// 添加RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingPhase(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseBiz trainingPhaseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingPhaseBiz = new TrainingPhaseBiz();

                //执行Biz操作
                trainingPhaseBiz.AddTrainingPhase(curConnectionEntity, paramTrainingPhase);

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
        /// 修改RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingPhase(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseBiz trainingPhaseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingPhaseBiz = new TrainingPhaseBiz();

                //执行Biz操作
                trainingPhaseBiz.ModifyTrainingPhase(curConnectionEntity, paramTrainingPhase);

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
        /// 删除RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingPhase(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseBiz trainingPhaseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingPhaseBiz = new TrainingPhaseBiz();

                //执行Biz操作
                trainingPhaseBiz.RemoveTrainingPhase(curConnectionEntity, paramTrainingPhase);

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
        /// 查看RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingPhaseByPK(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseBiz trainingPhaseBiz = null;

            TrainingPhaseEntity trainingPhaseEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingPhaseBiz = new TrainingPhaseBiz();

                //执行Biz操作
                trainingPhase = trainingPhaseBiz.FindTrainingPhaseByPK(curConnectionEntity, paramTrainingPhase);

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

            return TrainingPhase;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingPhase
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingPhaseEntity" type="TrainingPhaseEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingPhaseByForeignKeys(Object paramConnectionEntity, TrainingPhaseEntity paramTrainingPhaseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingPhaseBiz trainingPhaseBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingPhaseBiz = new TrainingPhaseBiz();

                //执行Biz操作
                objDataTable = trainingPhaseBiz.FindAllTrainingPhaseByForeignKeys(curConnectionEntity, paramTrainingPhase);

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