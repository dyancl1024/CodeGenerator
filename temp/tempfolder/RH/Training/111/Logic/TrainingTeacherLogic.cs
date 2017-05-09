using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingTeacher ( RH_TrainingTeacher ) Logic类
    ///</summary>
    public class TrainingTeacherLogic
    {

        /// <summary>
        /// 添加RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingTeacher(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherBiz trainingTeacherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherBiz = new TrainingTeacherBiz();

                //执行Biz操作
                trainingTeacherBiz.AddTrainingTeacher(curConnectionEntity, paramTrainingTeacher);

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
        /// 修改RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingTeacher(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherBiz trainingTeacherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherBiz = new TrainingTeacherBiz();

                //执行Biz操作
                trainingTeacherBiz.ModifyTrainingTeacher(curConnectionEntity, paramTrainingTeacher);

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
        /// 删除RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingTeacher(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherBiz trainingTeacherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherBiz = new TrainingTeacherBiz();

                //执行Biz操作
                trainingTeacherBiz.RemoveTrainingTeacher(curConnectionEntity, paramTrainingTeacher);

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
        /// 查看RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingTeacherByPK(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherBiz trainingTeacherBiz = null;

            TrainingTeacherEntity trainingTeacherEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherBiz = new TrainingTeacherBiz();

                //执行Biz操作
                trainingTeacher = trainingTeacherBiz.FindTrainingTeacherByPK(curConnectionEntity, paramTrainingTeacher);

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

            return TrainingTeacher;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherEntity" type="TrainingTeacherEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingTeacherByForeignKeys(Object paramConnectionEntity, TrainingTeacherEntity paramTrainingTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingTeacherBiz trainingTeacherBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingTeacherBiz = new TrainingTeacherBiz();

                //执行Biz操作
                objDataTable = trainingTeacherBiz.FindAllTrainingTeacherByForeignKeys(curConnectionEntity, paramTrainingTeacher);

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