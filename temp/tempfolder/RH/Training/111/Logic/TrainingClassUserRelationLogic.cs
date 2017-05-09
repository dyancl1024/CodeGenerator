using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingClassUserRelation ( RH_TrainingClassUserRelation ) Logic类
    ///</summary>
    public class TrainingClassUserRelationLogic
    {

        /// <summary>
        /// 添加RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingClassUserRelation(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationBiz trainingClassUserRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassUserRelationBiz = new TrainingClassUserRelationBiz();

                //执行Biz操作
                trainingClassUserRelationBiz.AddTrainingClassUserRelation(curConnectionEntity, paramTrainingClassUserRelation);

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
        /// 修改RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingClassUserRelation(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationBiz trainingClassUserRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassUserRelationBiz = new TrainingClassUserRelationBiz();

                //执行Biz操作
                trainingClassUserRelationBiz.ModifyTrainingClassUserRelation(curConnectionEntity, paramTrainingClassUserRelation);

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
        /// 删除RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingClassUserRelation(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationBiz trainingClassUserRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassUserRelationBiz = new TrainingClassUserRelationBiz();

                //执行Biz操作
                trainingClassUserRelationBiz.RemoveTrainingClassUserRelation(curConnectionEntity, paramTrainingClassUserRelation);

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
        /// 查看RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingClassUserRelationByPK(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationBiz trainingClassUserRelationBiz = null;

            TrainingClassUserRelationEntity trainingClassUserRelationEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassUserRelationBiz = new TrainingClassUserRelationBiz();

                //执行Biz操作
                trainingClassUserRelation = trainingClassUserRelationBiz.FindTrainingClassUserRelationByPK(curConnectionEntity, paramTrainingClassUserRelation);

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

            return TrainingClassUserRelation;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassUserRelationEntity" type="TrainingClassUserRelationEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingClassUserRelationByForeignKeys(Object paramConnectionEntity, TrainingClassUserRelationEntity paramTrainingClassUserRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassUserRelationBiz trainingClassUserRelationBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassUserRelationBiz = new TrainingClassUserRelationBiz();

                //执行Biz操作
                objDataTable = trainingClassUserRelationBiz.FindAllTrainingClassUserRelationByForeignKeys(curConnectionEntity, paramTrainingClassUserRelation);

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