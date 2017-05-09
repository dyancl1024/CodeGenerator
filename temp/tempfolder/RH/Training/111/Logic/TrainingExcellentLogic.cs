using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingExcellent ( RH_TrainingExcellent ) Logic类
    ///</summary>
    public class TrainingExcellentLogic
    {

        /// <summary>
        /// 添加RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingExcellent(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentBiz trainingExcellentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExcellentBiz = new TrainingExcellentBiz();

                //执行Biz操作
                trainingExcellentBiz.AddTrainingExcellent(curConnectionEntity, paramTrainingExcellent);

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
        /// 修改RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingExcellent(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentBiz trainingExcellentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExcellentBiz = new TrainingExcellentBiz();

                //执行Biz操作
                trainingExcellentBiz.ModifyTrainingExcellent(curConnectionEntity, paramTrainingExcellent);

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
        /// 删除RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingExcellent(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentBiz trainingExcellentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExcellentBiz = new TrainingExcellentBiz();

                //执行Biz操作
                trainingExcellentBiz.RemoveTrainingExcellent(curConnectionEntity, paramTrainingExcellent);

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
        /// 查看RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingExcellentByPK(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentBiz trainingExcellentBiz = null;

            TrainingExcellentEntity trainingExcellentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExcellentBiz = new TrainingExcellentBiz();

                //执行Biz操作
                trainingExcellent = trainingExcellentBiz.FindTrainingExcellentByPK(curConnectionEntity, paramTrainingExcellent);

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

            return TrainingExcellent;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingExcellent
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExcellentEntity" type="TrainingExcellentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingExcellentByForeignKeys(Object paramConnectionEntity, TrainingExcellentEntity paramTrainingExcellentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExcellentBiz trainingExcellentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExcellentBiz = new TrainingExcellentBiz();

                //执行Biz操作
                objDataTable = trainingExcellentBiz.FindAllTrainingExcellentByForeignKeys(curConnectionEntity, paramTrainingExcellent);

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