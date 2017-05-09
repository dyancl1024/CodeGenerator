using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingLevel ( RH_TrainingLevel ) Logic类
    ///</summary>
    public class TrainingLevelLogic
    {

        /// <summary>
        /// 添加RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingLevel(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelBiz trainingLevelBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingLevelBiz = new TrainingLevelBiz();

                //执行Biz操作
                trainingLevelBiz.AddTrainingLevel(curConnectionEntity, paramTrainingLevel);

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
        /// 修改RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingLevel(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelBiz trainingLevelBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingLevelBiz = new TrainingLevelBiz();

                //执行Biz操作
                trainingLevelBiz.ModifyTrainingLevel(curConnectionEntity, paramTrainingLevel);

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
        /// 删除RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingLevel(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelBiz trainingLevelBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingLevelBiz = new TrainingLevelBiz();

                //执行Biz操作
                trainingLevelBiz.RemoveTrainingLevel(curConnectionEntity, paramTrainingLevel);

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
        /// 查看RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingLevelByPK(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelBiz trainingLevelBiz = null;

            TrainingLevelEntity trainingLevelEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingLevelBiz = new TrainingLevelBiz();

                //执行Biz操作
                trainingLevel = trainingLevelBiz.FindTrainingLevelByPK(curConnectionEntity, paramTrainingLevel);

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

            return TrainingLevel;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingLevel
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingLevelEntity" type="TrainingLevelEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingLevelByForeignKeys(Object paramConnectionEntity, TrainingLevelEntity paramTrainingLevelEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingLevelBiz trainingLevelBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingLevelBiz = new TrainingLevelBiz();

                //执行Biz操作
                objDataTable = trainingLevelBiz.FindAllTrainingLevelByForeignKeys(curConnectionEntity, paramTrainingLevel);

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