using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_CoursePreset ( RH_CoursePreset ) Logic类
    ///</summary>
    public class CoursePresetLogic
    {

        /// <summary>
        /// 添加RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void AddCoursePreset(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetBiz coursePresetBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePresetBiz = new CoursePresetBiz();

                //执行Biz操作
                coursePresetBiz.AddCoursePreset(curConnectionEntity, paramCoursePreset);

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
        /// 修改RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCoursePreset(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetBiz coursePresetBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePresetBiz = new CoursePresetBiz();

                //执行Biz操作
                coursePresetBiz.ModifyCoursePreset(curConnectionEntity, paramCoursePreset);

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
        /// 删除RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCoursePreset(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetBiz coursePresetBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePresetBiz = new CoursePresetBiz();

                //执行Biz操作
                coursePresetBiz.RemoveCoursePreset(curConnectionEntity, paramCoursePreset);

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
        /// 查看RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public void FindCoursePresetByPK(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetBiz coursePresetBiz = null;

            CoursePresetEntity coursePresetEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePresetBiz = new CoursePresetBiz();

                //执行Biz操作
                coursePreset = coursePresetBiz.FindCoursePresetByPK(curConnectionEntity, paramCoursePreset);

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

            return CoursePreset;
        }

        /// <summary>
        /// 根据外键查找RH_CoursePreset
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCoursePresetEntity" type="CoursePresetEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCoursePresetByForeignKeys(Object paramConnectionEntity, CoursePresetEntity paramCoursePresetEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CoursePresetBiz coursePresetBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                coursePresetBiz = new CoursePresetBiz();

                //执行Biz操作
                objDataTable = coursePresetBiz.FindAllCoursePresetByForeignKeys(curConnectionEntity, paramCoursePreset);

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