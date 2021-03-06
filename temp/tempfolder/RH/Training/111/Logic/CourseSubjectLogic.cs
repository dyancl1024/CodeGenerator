using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CourseSubject ( RH_CourseSubject ) Logic类
    ///</summary>
    public class CourseSubjectLogic
    {

        /// <summary>
        /// 添加RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseSubject(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectBiz courseSubjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseSubjectBiz = new CourseSubjectBiz();

                //执行Biz操作
                courseSubjectBiz.AddCourseSubject(curConnectionEntity, paramCourseSubject);

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
        /// 修改RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseSubject(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectBiz courseSubjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseSubjectBiz = new CourseSubjectBiz();

                //执行Biz操作
                courseSubjectBiz.ModifyCourseSubject(curConnectionEntity, paramCourseSubject);

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
        /// 删除RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseSubject(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectBiz courseSubjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseSubjectBiz = new CourseSubjectBiz();

                //执行Biz操作
                courseSubjectBiz.RemoveCourseSubject(curConnectionEntity, paramCourseSubject);

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
        /// 查看RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseSubjectByPK(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectBiz courseSubjectBiz = null;

            CourseSubjectEntity courseSubjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseSubjectBiz = new CourseSubjectBiz();

                //执行Biz操作
                courseSubject = courseSubjectBiz.FindCourseSubjectByPK(curConnectionEntity, paramCourseSubject);

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

            return CourseSubject;
        }

        /// <summary>
        /// 根据外键查找RH_CourseSubject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseSubjectEntity" type="CourseSubjectEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseSubjectByForeignKeys(Object paramConnectionEntity, CourseSubjectEntity paramCourseSubjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseSubjectBiz courseSubjectBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseSubjectBiz = new CourseSubjectBiz();

                //执行Biz操作
                objDataTable = courseSubjectBiz.FindAllCourseSubjectByForeignKeys(curConnectionEntity, paramCourseSubject);

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