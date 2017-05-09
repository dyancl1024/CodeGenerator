using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingMyCourse ( RH_TrainingMyCourse ) Logic类
    ///</summary>
    public class TrainingMyCourseLogic
    {

        /// <summary>
        /// 添加RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingMyCourse(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseBiz trainingMyCourseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseBiz = new TrainingMyCourseBiz();

                //执行Biz操作
                trainingMyCourseBiz.AddTrainingMyCourse(curConnectionEntity, paramTrainingMyCourse);

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
        /// 修改RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingMyCourse(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseBiz trainingMyCourseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseBiz = new TrainingMyCourseBiz();

                //执行Biz操作
                trainingMyCourseBiz.ModifyTrainingMyCourse(curConnectionEntity, paramTrainingMyCourse);

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
        /// 删除RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingMyCourse(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseBiz trainingMyCourseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseBiz = new TrainingMyCourseBiz();

                //执行Biz操作
                trainingMyCourseBiz.RemoveTrainingMyCourse(curConnectionEntity, paramTrainingMyCourse);

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
        /// 查看RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingMyCourseByPK(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseBiz trainingMyCourseBiz = null;

            TrainingMyCourseEntity trainingMyCourseEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseBiz = new TrainingMyCourseBiz();

                //执行Biz操作
                trainingMyCourse = trainingMyCourseBiz.FindTrainingMyCourseByPK(curConnectionEntity, paramTrainingMyCourse);

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

            return TrainingMyCourse;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingMyCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingMyCourseEntity" type="TrainingMyCourseEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingMyCourseByForeignKeys(Object paramConnectionEntity, TrainingMyCourseEntity paramTrainingMyCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingMyCourseBiz trainingMyCourseBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingMyCourseBiz = new TrainingMyCourseBiz();

                //执行Biz操作
                objDataTable = trainingMyCourseBiz.FindAllTrainingMyCourseByForeignKeys(curConnectionEntity, paramTrainingMyCourse);

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