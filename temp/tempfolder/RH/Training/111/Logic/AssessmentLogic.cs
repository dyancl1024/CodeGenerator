using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Assessment ( RH_Assessment ) Logic类
    ///</summary>
    public class AssessmentLogic
    {

        /// <summary>
        /// 添加RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void AddAssessment(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentBiz assessmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentBiz = new AssessmentBiz();

                //执行Biz操作
                assessmentBiz.AddAssessment(curConnectionEntity, paramAssessment);

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
        /// 修改RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyAssessment(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentBiz assessmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentBiz = new AssessmentBiz();

                //执行Biz操作
                assessmentBiz.ModifyAssessment(curConnectionEntity, paramAssessment);

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
        /// 删除RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveAssessment(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentBiz assessmentBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentBiz = new AssessmentBiz();

                //执行Biz操作
                assessmentBiz.RemoveAssessment(curConnectionEntity, paramAssessment);

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
        /// 查看RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public void FindAssessmentByPK(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentBiz assessmentBiz = null;

            AssessmentEntity assessmentEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentBiz = new AssessmentBiz();

                //执行Biz操作
                assessment = assessmentBiz.FindAssessmentByPK(curConnectionEntity, paramAssessment);

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

            return Assessment;
        }

        /// <summary>
        /// 根据外键查找RH_Assessment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramAssessmentEntity" type="AssessmentEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllAssessmentByForeignKeys(Object paramConnectionEntity, AssessmentEntity paramAssessmentEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            AssessmentBiz assessmentBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                assessmentBiz = new AssessmentBiz();

                //执行Biz操作
                objDataTable = assessmentBiz.FindAllAssessmentByForeignKeys(curConnectionEntity, paramAssessment);

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