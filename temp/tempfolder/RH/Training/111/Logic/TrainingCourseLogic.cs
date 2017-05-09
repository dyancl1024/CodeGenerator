using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingCourse ( RH_TrainingCourse ) Logic类
    ///</summary>
    public class TrainingCourseLogic
    {

        /// <summary>
        /// 添加RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingCourse(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseBiz trainingCourseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingCourseBiz = new TrainingCourseBiz();

                //执行Biz操作
                trainingCourseBiz.AddTrainingCourse(curConnectionEntity, paramTrainingCourse);

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
        /// 修改RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingCourse(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseBiz trainingCourseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingCourseBiz = new TrainingCourseBiz();

                //执行Biz操作
                trainingCourseBiz.ModifyTrainingCourse(curConnectionEntity, paramTrainingCourse);

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
        /// 删除RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingCourse(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseBiz trainingCourseBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingCourseBiz = new TrainingCourseBiz();

                //执行Biz操作
                trainingCourseBiz.RemoveTrainingCourse(curConnectionEntity, paramTrainingCourse);

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
        /// 查看RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingCourseByPK(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseBiz trainingCourseBiz = null;

            TrainingCourseEntity trainingCourseEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingCourseBiz = new TrainingCourseBiz();

                //执行Biz操作
                trainingCourse = trainingCourseBiz.FindTrainingCourseByPK(curConnectionEntity, paramTrainingCourse);

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

            return TrainingCourse;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingCourse
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingCourseEntity" type="TrainingCourseEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingCourseByForeignKeys(Object paramConnectionEntity, TrainingCourseEntity paramTrainingCourseEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingCourseBiz trainingCourseBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingCourseBiz = new TrainingCourseBiz();

                //执行Biz操作
                objDataTable = trainingCourseBiz.FindAllTrainingCourseByForeignKeys(curConnectionEntity, paramTrainingCourse);

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