using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingDynamic ( RH_TrainingDynamic ) Logic类
    ///</summary>
    public class TrainingDynamicLogic
    {

        /// <summary>
        /// 添加RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingDynamic(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicBiz trainingDynamicBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingDynamicBiz = new TrainingDynamicBiz();

                //执行Biz操作
                trainingDynamicBiz.AddTrainingDynamic(curConnectionEntity, paramTrainingDynamic);

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
        /// 修改RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingDynamic(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicBiz trainingDynamicBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingDynamicBiz = new TrainingDynamicBiz();

                //执行Biz操作
                trainingDynamicBiz.ModifyTrainingDynamic(curConnectionEntity, paramTrainingDynamic);

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
        /// 删除RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingDynamic(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicBiz trainingDynamicBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingDynamicBiz = new TrainingDynamicBiz();

                //执行Biz操作
                trainingDynamicBiz.RemoveTrainingDynamic(curConnectionEntity, paramTrainingDynamic);

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
        /// 查看RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingDynamicByPK(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicBiz trainingDynamicBiz = null;

            TrainingDynamicEntity trainingDynamicEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingDynamicBiz = new TrainingDynamicBiz();

                //执行Biz操作
                trainingDynamic = trainingDynamicBiz.FindTrainingDynamicByPK(curConnectionEntity, paramTrainingDynamic);

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

            return TrainingDynamic;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingDynamicByForeignKeys(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingDynamicBiz trainingDynamicBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingDynamicBiz = new TrainingDynamicBiz();

                //执行Biz操作
                objDataTable = trainingDynamicBiz.FindAllTrainingDynamicByForeignKeys(curConnectionEntity, paramTrainingDynamic);

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