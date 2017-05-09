using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CourseAnswer ( RH_CourseAnswer ) Logic类
    ///</summary>
    public class CourseAnswerLogic
    {

        /// <summary>
        /// 添加RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseAnswer(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerBiz courseAnswerBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAnswerBiz = new CourseAnswerBiz();

                //执行Biz操作
                courseAnswerBiz.AddCourseAnswer(curConnectionEntity, paramCourseAnswer);

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
        /// 修改RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseAnswer(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerBiz courseAnswerBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAnswerBiz = new CourseAnswerBiz();

                //执行Biz操作
                courseAnswerBiz.ModifyCourseAnswer(curConnectionEntity, paramCourseAnswer);

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
        /// 删除RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseAnswer(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerBiz courseAnswerBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAnswerBiz = new CourseAnswerBiz();

                //执行Biz操作
                courseAnswerBiz.RemoveCourseAnswer(curConnectionEntity, paramCourseAnswer);

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
        /// 查看RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseAnswerByPK(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerBiz courseAnswerBiz = null;

            CourseAnswerEntity courseAnswerEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAnswerBiz = new CourseAnswerBiz();

                //执行Biz操作
                courseAnswer = courseAnswerBiz.FindCourseAnswerByPK(curConnectionEntity, paramCourseAnswer);

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

            return CourseAnswer;
        }

        /// <summary>
        /// 根据外键查找RH_CourseAnswer
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAnswerEntity" type="CourseAnswerEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseAnswerByForeignKeys(Object paramConnectionEntity, CourseAnswerEntity paramCourseAnswerEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseAnswerBiz courseAnswerBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseAnswerBiz = new CourseAnswerBiz();

                //执行Biz操作
                objDataTable = courseAnswerBiz.FindAllCourseAnswerByForeignKeys(curConnectionEntity, paramCourseAnswer);

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