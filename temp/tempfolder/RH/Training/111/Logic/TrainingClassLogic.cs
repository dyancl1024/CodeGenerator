using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_TrainingClass ( RH_TrainingClass ) Logic类
    ///</summary>
    public class TrainingClassLogic
    {

        /// <summary>
        /// 添加RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void AddTrainingClass(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassBiz trainingClassBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassBiz = new TrainingClassBiz();

                //执行Biz操作
                trainingClassBiz.AddTrainingClass(curConnectionEntity, paramTrainingClass);

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
        /// 修改RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTrainingClass(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassBiz trainingClassBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassBiz = new TrainingClassBiz();

                //执行Biz操作
                trainingClassBiz.ModifyTrainingClass(curConnectionEntity, paramTrainingClass);

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
        /// 删除RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTrainingClass(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassBiz trainingClassBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassBiz = new TrainingClassBiz();

                //执行Biz操作
                trainingClassBiz.RemoveTrainingClass(curConnectionEntity, paramTrainingClass);

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
        /// 查看RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public void FindTrainingClassByPK(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassBiz trainingClassBiz = null;

            TrainingClassEntity trainingClassEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassBiz = new TrainingClassBiz();

                //执行Biz操作
                trainingClass = trainingClassBiz.FindTrainingClassByPK(curConnectionEntity, paramTrainingClass);

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

            return TrainingClass;
        }

        /// <summary>
        /// 根据外键查找RH_TrainingClass
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingClassEntity" type="TrainingClassEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTrainingClassByForeignKeys(Object paramConnectionEntity, TrainingClassEntity paramTrainingClassEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            TrainingClassBiz trainingClassBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                trainingClassBiz = new TrainingClassBiz();

                //执行Biz操作
                objDataTable = trainingClassBiz.FindAllTrainingClassByForeignKeys(curConnectionEntity, paramTrainingClass);

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