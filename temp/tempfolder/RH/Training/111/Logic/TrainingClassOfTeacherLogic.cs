using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) Logic类
    ///</summary>
    public class TrainingClassOfTeacherLogic
    {

        /// <summary>
        /// 添加RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingClassOfTeacher(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherBiz trainingClassOfTeacherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassOfTeacherBiz = new TrainingClassOfTeacherBiz();

                //执行Biz操作
                trainingClassOfTeacherBiz.AddTrainingClassOfTeacher(curConnectionEntity, paramTrainingClassOfTeacher);

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
        /// 修改RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingClassOfTeacher(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherBiz trainingClassOfTeacherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassOfTeacherBiz = new TrainingClassOfTeacherBiz();

                //执行Biz操作
                trainingClassOfTeacherBiz.ModifyTrainingClassOfTeacher(curConnectionEntity, paramTrainingClassOfTeacher);

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
        /// 删除RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingClassOfTeacher(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherBiz trainingClassOfTeacherBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassOfTeacherBiz = new TrainingClassOfTeacherBiz();

                //执行Biz操作
                trainingClassOfTeacherBiz.RemoveTrainingClassOfTeacher(curConnectionEntity, paramTrainingClassOfTeacher);

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
        /// 查看RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingClassOfTeacherByPK(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherBiz trainingClassOfTeacherBiz = null;

            TrainingClassOfTeacherEntity trainingClassOfTeacherEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassOfTeacherBiz = new TrainingClassOfTeacherBiz();

                //执行Biz操作
                trainingClassOfTeacher = trainingClassOfTeacherBiz.FindTrainingClassOfTeacherByPK(curConnectionEntity, paramTrainingClassOfTeacher);

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

            return TrainingClassOfTeacher;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingClassOfTeacher
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassOfTeacherEntity" type="TrainingClassOfTeacherEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingClassOfTeacherByForeignKeys(Object paramConnectionEntity, TrainingClassOfTeacherEntity paramTrainingClassOfTeacherEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassOfTeacherBiz trainingClassOfTeacherBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassOfTeacherBiz = new TrainingClassOfTeacherBiz();

                //执行Biz操作
                objDataTable = trainingClassOfTeacherBiz.FindAllTrainingClassOfTeacherByForeignKeys(curConnectionEntity, paramTrainingClassOfTeacher);

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