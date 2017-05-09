using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_Grade ( RH_Grade ) Biz类
    ///</summary>
    public class GradeBiz
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

            GradeDao gradeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeDao = new GradeDao();

                //执行DAO操作
                gradeDao.Insert(curConnectionEntity, paramGrade);

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

            GradeDao gradeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeDao = new GradeDao();

                //执行DAO操作
                gradeDao.Update(curConnectionEntity, paramGrade);

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

            GradeDao gradeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeDao = new GradeDao();

                //执行DAO操作
                gradeDao.Delete(curConnectionEntity, paramGrade);

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

            GradeDao gradeDao = null;

            GradeEntity gradeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeDao = new GradeDao();

                //执行DAO操作
                grade = gradeDao.SelectByPK(curConnectionEntity, paramGrade);

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

            GradeDao gradeDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                gradeDao = new GradeDao();

                //执行DAO操作
                objDataTable = gradeDao.SelectAllGradeByForeignKeys(curConnectionEntity, paramGrade);

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