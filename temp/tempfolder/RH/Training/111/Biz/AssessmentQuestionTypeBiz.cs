using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_AssessmentQuestionType ( RH_AssessmentQuestionType ) Biz类
    ///</summary>
    public class AssessmentQuestionTypeBiz
    {

        /// <summary>
        /// 添加RH_AssessmentQuestionType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionTypeEntity" type="AssessmentQuestionTypeEntity"></param>
        /// <returns type="void"></returns>
        public void AddAssessmentQuestionType(Object paramConnectionEntity, AssessmentQuestionTypeEntity paramAssessmentQuestionTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionTypeDao assessmentQuestionTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionTypeDao = new AssessmentQuestionTypeDao();

                //执行DAO操作
                assessmentQuestionTypeDao.Insert(curConnectionEntity, paramAssessmentQuestionType);

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
        /// 修改RH_AssessmentQuestionType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionTypeEntity" type="AssessmentQuestionTypeEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyAssessmentQuestionType(Object paramConnectionEntity, AssessmentQuestionTypeEntity paramAssessmentQuestionTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionTypeDao assessmentQuestionTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionTypeDao = new AssessmentQuestionTypeDao();

                //执行DAO操作
                assessmentQuestionTypeDao.Update(curConnectionEntity, paramAssessmentQuestionType);

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
        /// 删除RH_AssessmentQuestionType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionTypeEntity" type="AssessmentQuestionTypeEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveAssessmentQuestionType(Object paramConnectionEntity, AssessmentQuestionTypeEntity paramAssessmentQuestionTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionTypeDao assessmentQuestionTypeDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionTypeDao = new AssessmentQuestionTypeDao();

                //执行DAO操作
                assessmentQuestionTypeDao.Delete(curConnectionEntity, paramAssessmentQuestionType);

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
        /// 查看RH_AssessmentQuestionType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionTypeEntity" type="AssessmentQuestionTypeEntity"></param>
        /// <returns type="void"></returns>
        public void FindAssessmentQuestionTypeByPK(Object paramConnectionEntity, AssessmentQuestionTypeEntity paramAssessmentQuestionTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionTypeDao assessmentQuestionTypeDao = null;

            AssessmentQuestionTypeEntity assessmentQuestionTypeEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionTypeDao = new AssessmentQuestionTypeDao();

                //执行DAO操作
                assessmentQuestionType = assessmentQuestionTypeDao.SelectByPK(curConnectionEntity, paramAssessmentQuestionType);

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

            return AssessmentQuestionType;
        }

        /// <summary>
        /// 根据外键查找RH_AssessmentQuestionType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentQuestionTypeEntity" type="AssessmentQuestionTypeEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllAssessmentQuestionTypeByForeignKeys(Object paramConnectionEntity, AssessmentQuestionTypeEntity paramAssessmentQuestionTypeEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentQuestionTypeDao assessmentQuestionTypeDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                assessmentQuestionTypeDao = new AssessmentQuestionTypeDao();

                //执行DAO操作
                objDataTable = assessmentQuestionTypeDao.SelectAllAssessmentQuestionTypeByForeignKeys(curConnectionEntity, paramAssessmentQuestionType);

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