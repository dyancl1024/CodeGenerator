using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_AssessmentOptions ( RH_AssessmentOptions ) Biz类
    ///</summary>
    public class AssessmentOptionsBiz
    {

        /// <summary>
        /// 添加RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="void"></returns>
        public void AddAssessmentOptions(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentOptionsDao assessmentOptionsDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentOptionsDao = new AssessmentOptionsDao();

                //执行DAO操作
                assessmentOptionsDao.Insert(curConnectionEntity, paramAssessmentOptions);

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
        /// 修改RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyAssessmentOptions(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentOptionsDao assessmentOptionsDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentOptionsDao = new AssessmentOptionsDao();

                //执行DAO操作
                assessmentOptionsDao.Update(curConnectionEntity, paramAssessmentOptions);

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
        /// 删除RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveAssessmentOptions(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentOptionsDao assessmentOptionsDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentOptionsDao = new AssessmentOptionsDao();

                //执行DAO操作
                assessmentOptionsDao.Delete(curConnectionEntity, paramAssessmentOptions);

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
        /// 查看RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="void"></returns>
        public void FindAssessmentOptionsByPK(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentOptionsDao assessmentOptionsDao = null;

            AssessmentOptionsEntity assessmentOptionsEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentOptionsDao = new AssessmentOptionsDao();

                //执行DAO操作
                assessmentOptions = assessmentOptionsDao.SelectByPK(curConnectionEntity, paramAssessmentOptions);

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

            return AssessmentOptions;
        }

        /// <summary>
        /// 根据外键查找RH_AssessmentOptions
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentOptionsEntity" type="AssessmentOptionsEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllAssessmentOptionsByForeignKeys(Object paramConnectionEntity, AssessmentOptionsEntity paramAssessmentOptionsEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentOptionsDao assessmentOptionsDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentOptionsDao = new AssessmentOptionsDao();

                //执行DAO操作
                objDataTable = assessmentOptionsDao.SelectAllAssessmentOptionsByForeignKeys(curConnectionEntity, paramAssessmentOptions);

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