using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingType ( RH_TrainingType ) Logic类
    ///</summary>
    public class TrainingTypeLogic
    {

        /// <summary>
        /// 添加RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingType(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeBiz trainingTypeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTypeBiz = new TrainingTypeBiz();

                //执行Biz操作
                trainingTypeBiz.AddTrainingType(curConnectionEntity, paramTrainingType);

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
        /// 修改RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingType(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeBiz trainingTypeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTypeBiz = new TrainingTypeBiz();

                //执行Biz操作
                trainingTypeBiz.ModifyTrainingType(curConnectionEntity, paramTrainingType);

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
        /// 删除RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingType(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeBiz trainingTypeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTypeBiz = new TrainingTypeBiz();

                //执行Biz操作
                trainingTypeBiz.RemoveTrainingType(curConnectionEntity, paramTrainingType);

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
        /// 查看RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingTypeByPK(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeBiz trainingTypeBiz = null;

            TrainingTypeEntity trainingTypeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTypeBiz = new TrainingTypeBiz();

                //执行Biz操作
                trainingType = trainingTypeBiz.FindTrainingTypeByPK(curConnectionEntity, paramTrainingType);

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

            return TrainingType;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingTypeByForeignKeys(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTypeBiz trainingTypeBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTypeBiz = new TrainingTypeBiz();

                //执行Biz操作
                objDataTable = trainingTypeBiz.FindAllTrainingTypeByForeignKeys(curConnectionEntity, paramTrainingType);

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