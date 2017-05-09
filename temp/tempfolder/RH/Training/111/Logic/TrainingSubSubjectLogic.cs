using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingSubSubject ( RH_TrainingSubSubject ) Logic类
    ///</summary>
    public class TrainingSubSubjectLogic
    {

        /// <summary>
        /// 添加RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingSubSubject(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectBiz trainingSubSubjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingSubSubjectBiz = new TrainingSubSubjectBiz();

                //执行Biz操作
                trainingSubSubjectBiz.AddTrainingSubSubject(curConnectionEntity, paramTrainingSubSubject);

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
        /// 修改RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingSubSubject(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectBiz trainingSubSubjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingSubSubjectBiz = new TrainingSubSubjectBiz();

                //执行Biz操作
                trainingSubSubjectBiz.ModifyTrainingSubSubject(curConnectionEntity, paramTrainingSubSubject);

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
        /// 删除RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingSubSubject(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectBiz trainingSubSubjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingSubSubjectBiz = new TrainingSubSubjectBiz();

                //执行Biz操作
                trainingSubSubjectBiz.RemoveTrainingSubSubject(curConnectionEntity, paramTrainingSubSubject);

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
        /// 查看RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingSubSubjectByPK(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectBiz trainingSubSubjectBiz = null;

            TrainingSubSubjectEntity trainingSubSubjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingSubSubjectBiz = new TrainingSubSubjectBiz();

                //执行Biz操作
                trainingSubSubject = trainingSubSubjectBiz.FindTrainingSubSubjectByPK(curConnectionEntity, paramTrainingSubSubject);

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

            return TrainingSubSubject;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingSubSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubSubjectEntity" type="TrainingSubSubjectEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingSubSubjectByForeignKeys(Object paramConnectionEntity, TrainingSubSubjectEntity paramTrainingSubSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingSubSubjectBiz trainingSubSubjectBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingSubSubjectBiz = new TrainingSubSubjectBiz();

                //执行Biz操作
                objDataTable = trainingSubSubjectBiz.FindAllTrainingSubSubjectByForeignKeys(curConnectionEntity, paramTrainingSubSubject);

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