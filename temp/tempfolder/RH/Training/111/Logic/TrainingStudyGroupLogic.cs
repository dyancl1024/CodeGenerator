using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingStudyGroup ( RH_TrainingStudyGroup ) Logic类
    ///</summary>
    public class TrainingStudyGroupLogic
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingStudyGroup(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupBiz trainingStudyGroupBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupBiz = new TrainingStudyGroupBiz();

                //执行Biz操作
                trainingStudyGroupBiz.AddTrainingStudyGroup(curConnectionEntity, paramTrainingStudyGroup);

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
        /// 修改RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingStudyGroup(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupBiz trainingStudyGroupBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupBiz = new TrainingStudyGroupBiz();

                //执行Biz操作
                trainingStudyGroupBiz.ModifyTrainingStudyGroup(curConnectionEntity, paramTrainingStudyGroup);

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
        /// 删除RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingStudyGroup(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupBiz trainingStudyGroupBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupBiz = new TrainingStudyGroupBiz();

                //执行Biz操作
                trainingStudyGroupBiz.RemoveTrainingStudyGroup(curConnectionEntity, paramTrainingStudyGroup);

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
        /// 查看RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingStudyGroupByPK(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupBiz trainingStudyGroupBiz = null;

            TrainingStudyGroupEntity trainingStudyGroupEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupBiz = new TrainingStudyGroupBiz();

                //执行Biz操作
                trainingStudyGroup = trainingStudyGroupBiz.FindTrainingStudyGroupByPK(curConnectionEntity, paramTrainingStudyGroup);

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

            return TrainingStudyGroup;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingStudyGroup
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupEntity" type="TrainingStudyGroupEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingStudyGroupByForeignKeys(Object paramConnectionEntity, TrainingStudyGroupEntity paramTrainingStudyGroupEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupBiz trainingStudyGroupBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupBiz = new TrainingStudyGroupBiz();

                //执行Biz操作
                objDataTable = trainingStudyGroupBiz.FindAllTrainingStudyGroupByForeignKeys(curConnectionEntity, paramTrainingStudyGroup);

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