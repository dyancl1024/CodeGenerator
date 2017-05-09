using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) Logic类
    ///</summary>
    public class CourseThemeRelationLogic
    {

        /// <summary>
        /// 添加RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void AddCourseThemeRelation(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationBiz courseThemeRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeRelationBiz = new CourseThemeRelationBiz();

                //执行Biz操作
                courseThemeRelationBiz.AddCourseThemeRelation(curConnectionEntity, paramCourseThemeRelation);

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
        /// 修改RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCourseThemeRelation(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationBiz courseThemeRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeRelationBiz = new CourseThemeRelationBiz();

                //执行Biz操作
                courseThemeRelationBiz.ModifyCourseThemeRelation(curConnectionEntity, paramCourseThemeRelation);

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
        /// 删除RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCourseThemeRelation(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationBiz courseThemeRelationBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeRelationBiz = new CourseThemeRelationBiz();

                //执行Biz操作
                courseThemeRelationBiz.RemoveCourseThemeRelation(curConnectionEntity, paramCourseThemeRelation);

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
        /// 查看RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public void FindCourseThemeRelationByPK(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationBiz courseThemeRelationBiz = null;

            CourseThemeRelationEntity courseThemeRelationEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeRelationBiz = new CourseThemeRelationBiz();

                //执行Biz操作
                courseThemeRelation = courseThemeRelationBiz.FindCourseThemeRelationByPK(curConnectionEntity, paramCourseThemeRelation);

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

            return CourseThemeRelation;
        }

        /// <summary>
        /// 根据外键查找RH_CourseThemeRelation
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseThemeRelationEntity" type="CourseThemeRelationEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCourseThemeRelationByForeignKeys(Object paramConnectionEntity, CourseThemeRelationEntity paramCourseThemeRelationEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CourseThemeRelationBiz courseThemeRelationBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                courseThemeRelationBiz = new CourseThemeRelationBiz();

                //执行Biz操作
                objDataTable = courseThemeRelationBiz.FindAllCourseThemeRelationByForeignKeys(curConnectionEntity, paramCourseThemeRelation);

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