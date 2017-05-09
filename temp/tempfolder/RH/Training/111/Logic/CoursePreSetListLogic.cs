using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) Logic类
    ///</summary>
    public class CoursePreSetListLogic
    {

        /// <summary>
        /// 添加RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void AddCoursePreSetList(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListBiz coursePreSetListBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePreSetListBiz = new CoursePreSetListBiz();

                //执行Biz操作
                coursePreSetListBiz.AddCoursePreSetList(curConnectionEntity, paramCoursePreSetList);

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
        /// 修改RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCoursePreSetList(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListBiz coursePreSetListBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePreSetListBiz = new CoursePreSetListBiz();

                //执行Biz操作
                coursePreSetListBiz.ModifyCoursePreSetList(curConnectionEntity, paramCoursePreSetList);

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
        /// 删除RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCoursePreSetList(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListBiz coursePreSetListBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePreSetListBiz = new CoursePreSetListBiz();

                //执行Biz操作
                coursePreSetListBiz.RemoveCoursePreSetList(curConnectionEntity, paramCoursePreSetList);

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
        /// 查看RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public void FindCoursePreSetListByPK(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListBiz coursePreSetListBiz = null;

            CoursePreSetListEntity coursePreSetListEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePreSetListBiz = new CoursePreSetListBiz();

                //执行Biz操作
                coursePreSetList = coursePreSetListBiz.FindCoursePreSetListByPK(curConnectionEntity, paramCoursePreSetList);

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

            return CoursePreSetList;
        }

        /// <summary>
        /// 根据外键查找RH_CoursePreSetList
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePreSetListEntity" type="CoursePreSetListEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCoursePreSetListByForeignKeys(Object paramConnectionEntity, CoursePreSetListEntity paramCoursePreSetListEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePreSetListBiz coursePreSetListBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePreSetListBiz = new CoursePreSetListBiz();

                //执行Biz操作
                objDataTable = coursePreSetListBiz.FindAllCoursePreSetListByForeignKeys(curConnectionEntity, paramCoursePreSetList);

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