using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingExpertQA ( RH_TrainingExpertQA ) Logic类
    ///</summary>
    public class TrainingExpertQALogic
    {

        /// <summary>
        /// 添加RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingExpertQA(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQABiz trainingExpertQABiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQABiz = new TrainingExpertQABiz();

                //执行Biz操作
                trainingExpertQABiz.AddTrainingExpertQA(curConnectionEntity, paramTrainingExpertQA);

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
        /// 修改RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingExpertQA(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQABiz trainingExpertQABiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQABiz = new TrainingExpertQABiz();

                //执行Biz操作
                trainingExpertQABiz.ModifyTrainingExpertQA(curConnectionEntity, paramTrainingExpertQA);

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
        /// 删除RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingExpertQA(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQABiz trainingExpertQABiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQABiz = new TrainingExpertQABiz();

                //执行Biz操作
                trainingExpertQABiz.RemoveTrainingExpertQA(curConnectionEntity, paramTrainingExpertQA);

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
        /// 查看RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingExpertQAByPK(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQABiz trainingExpertQABiz = null;

            TrainingExpertQAEntity trainingExpertQAEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQABiz = new TrainingExpertQABiz();

                //执行Biz操作
                trainingExpertQA = trainingExpertQABiz.FindTrainingExpertQAByPK(curConnectionEntity, paramTrainingExpertQA);

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

            return TrainingExpertQA;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingExpertQAByForeignKeys(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertQABiz trainingExpertQABiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertQABiz = new TrainingExpertQABiz();

                //执行Biz操作
                objDataTable = trainingExpertQABiz.FindAllTrainingExpertQAByForeignKeys(curConnectionEntity, paramTrainingExpertQA);

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