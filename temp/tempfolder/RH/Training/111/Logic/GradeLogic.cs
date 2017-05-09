using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Grade ( RH_Grade ) Logic类
    ///</summary>
    public class GradeLogic
    {

        /// <summary>
        /// 添加RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="void"></returns>
        public void AddGrade(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeBiz gradeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeBiz = new GradeBiz();

                //执行Biz操作
                gradeBiz.AddGrade(curConnectionEntity, paramGrade);

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
        /// 修改RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyGrade(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeBiz gradeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeBiz = new GradeBiz();

                //执行Biz操作
                gradeBiz.ModifyGrade(curConnectionEntity, paramGrade);

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
        /// 删除RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveGrade(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeBiz gradeBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeBiz = new GradeBiz();

                //执行Biz操作
                gradeBiz.RemoveGrade(curConnectionEntity, paramGrade);

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
        /// 查看RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="void"></returns>
        public void FindGradeByPK(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeBiz gradeBiz = null;

            GradeEntity gradeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeBiz = new GradeBiz();

                //执行Biz操作
                grade = gradeBiz.FindGradeByPK(curConnectionEntity, paramGrade);

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

            return Grade;
        }

        /// <summary>
        /// 根据外键查找RH_Grade
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramGradeEntity" type="GradeEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllGradeByForeignKeys(Object paramConnectionEntity, GradeEntity paramGradeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            GradeBiz gradeBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                gradeBiz = new GradeBiz();

                //执行Biz操作
                objDataTable = gradeBiz.FindAllGradeByForeignKeys(curConnectionEntity, paramGrade);

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