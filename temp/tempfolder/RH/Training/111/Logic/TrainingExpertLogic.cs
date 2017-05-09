using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingExpert ( RH_TrainingExpert ) Logic类
    ///</summary>
    public class TrainingExpertLogic
    {

        /// <summary>
        /// 添加RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingExpert(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertBiz trainingExpertBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertBiz = new TrainingExpertBiz();

                //执行Biz操作
                trainingExpertBiz.AddTrainingExpert(curConnectionEntity, paramTrainingExpert);

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
        /// 修改RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingExpert(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertBiz trainingExpertBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertBiz = new TrainingExpertBiz();

                //执行Biz操作
                trainingExpertBiz.ModifyTrainingExpert(curConnectionEntity, paramTrainingExpert);

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
        /// 删除RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingExpert(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertBiz trainingExpertBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertBiz = new TrainingExpertBiz();

                //执行Biz操作
                trainingExpertBiz.RemoveTrainingExpert(curConnectionEntity, paramTrainingExpert);

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
        /// 查看RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingExpertByPK(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertBiz trainingExpertBiz = null;

            TrainingExpertEntity trainingExpertEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertBiz = new TrainingExpertBiz();

                //执行Biz操作
                trainingExpert = trainingExpertBiz.FindTrainingExpertByPK(curConnectionEntity, paramTrainingExpert);

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

            return TrainingExpert;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingExpert
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertEntity" type="TrainingExpertEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingExpertByForeignKeys(Object paramConnectionEntity, TrainingExpertEntity paramTrainingExpertEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingExpertBiz trainingExpertBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingExpertBiz = new TrainingExpertBiz();

                //执行Biz操作
                objDataTable = trainingExpertBiz.FindAllTrainingExpertByForeignKeys(curConnectionEntity, paramTrainingExpert);

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