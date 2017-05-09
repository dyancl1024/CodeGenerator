using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingStudyGroupUser ( RH_TrainingStudyGroupUser ) Logic类
    ///</summary>
    public class TrainingStudyGroupUserLogic
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingStudyGroupUser(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupUserBiz trainingStudyGroupUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupUserBiz = new TrainingStudyGroupUserBiz();

                //执行Biz操作
                trainingStudyGroupUserBiz.AddTrainingStudyGroupUser(curConnectionEntity, paramTrainingStudyGroupUser);

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
        /// 修改RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingStudyGroupUser(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupUserBiz trainingStudyGroupUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupUserBiz = new TrainingStudyGroupUserBiz();

                //执行Biz操作
                trainingStudyGroupUserBiz.ModifyTrainingStudyGroupUser(curConnectionEntity, paramTrainingStudyGroupUser);

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
        /// 删除RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingStudyGroupUser(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupUserBiz trainingStudyGroupUserBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupUserBiz = new TrainingStudyGroupUserBiz();

                //执行Biz操作
                trainingStudyGroupUserBiz.RemoveTrainingStudyGroupUser(curConnectionEntity, paramTrainingStudyGroupUser);

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
        /// 查看RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingStudyGroupUserByPK(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupUserBiz trainingStudyGroupUserBiz = null;

            TrainingStudyGroupUserEntity trainingStudyGroupUserEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupUserBiz = new TrainingStudyGroupUserBiz();

                //执行Biz操作
                trainingStudyGroupUser = trainingStudyGroupUserBiz.FindTrainingStudyGroupUserByPK(curConnectionEntity, paramTrainingStudyGroupUser);

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

            return TrainingStudyGroupUser;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupUserEntity" type="TrainingStudyGroupUserEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingStudyGroupUserByForeignKeys(Object paramConnectionEntity, TrainingStudyGroupUserEntity paramTrainingStudyGroupUserEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingStudyGroupUserBiz trainingStudyGroupUserBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingStudyGroupUserBiz = new TrainingStudyGroupUserBiz();

                //执行Biz操作
                objDataTable = trainingStudyGroupUserBiz.FindAllTrainingStudyGroupUserByForeignKeys(curConnectionEntity, paramTrainingStudyGroupUser);

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