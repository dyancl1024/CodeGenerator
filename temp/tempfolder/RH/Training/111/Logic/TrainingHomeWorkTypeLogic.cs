using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingHomeWorkType ( RH_TrainingHomeWorkType ) Logic类
    ///</summary>
    public class TrainingHomeWorkTypeLogic
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingHomeWorkType(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeBiz trainingHomeWorkTypeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkTypeBiz = new TrainingHomeWorkTypeBiz();

                //执行Biz操作
                trainingHomeWorkTypeBiz.AddTrainingHomeWorkType(curConnectionEntity, paramTrainingHomeWorkType);

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
        /// 修改RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingHomeWorkType(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeBiz trainingHomeWorkTypeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkTypeBiz = new TrainingHomeWorkTypeBiz();

                //执行Biz操作
                trainingHomeWorkTypeBiz.ModifyTrainingHomeWorkType(curConnectionEntity, paramTrainingHomeWorkType);

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
        /// 删除RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingHomeWorkType(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeBiz trainingHomeWorkTypeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkTypeBiz = new TrainingHomeWorkTypeBiz();

                //执行Biz操作
                trainingHomeWorkTypeBiz.RemoveTrainingHomeWorkType(curConnectionEntity, paramTrainingHomeWorkType);

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
        /// 查看RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingHomeWorkTypeByPK(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeBiz trainingHomeWorkTypeBiz = null;

            TrainingHomeWorkTypeEntity trainingHomeWorkTypeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkTypeBiz = new TrainingHomeWorkTypeBiz();

                //执行Biz操作
                trainingHomeWorkType = trainingHomeWorkTypeBiz.FindTrainingHomeWorkTypeByPK(curConnectionEntity, paramTrainingHomeWorkType);

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

            return TrainingHomeWorkType;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingHomeWorkTypeByForeignKeys(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingHomeWorkTypeBiz trainingHomeWorkTypeBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingHomeWorkTypeBiz = new TrainingHomeWorkTypeBiz();

                //执行Biz操作
                objDataTable = trainingHomeWorkTypeBiz.FindAllTrainingHomeWorkTypeByForeignKeys(curConnectionEntity, paramTrainingHomeWorkType);

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