using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Temp_BasicData_TrainingSub ( RH_Temp_BasicData_TrainingSub ) Logic类
    ///</summary>
    public class Temp_BasicData_TrainingSubLogic
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void AddTemp_BasicData_TrainingSub(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubBiz temp_BasicData_TrainingSubBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_TrainingSubBiz = new Temp_BasicData_TrainingSubBiz();

                //执行Biz操作
                temp_BasicData_TrainingSubBiz.AddTemp_BasicData_TrainingSub(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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
        /// 修改RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyTemp_BasicData_TrainingSub(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubBiz temp_BasicData_TrainingSubBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_TrainingSubBiz = new Temp_BasicData_TrainingSubBiz();

                //执行Biz操作
                temp_BasicData_TrainingSubBiz.ModifyTemp_BasicData_TrainingSub(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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
        /// 删除RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveTemp_BasicData_TrainingSub(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubBiz temp_BasicData_TrainingSubBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_TrainingSubBiz = new Temp_BasicData_TrainingSubBiz();

                //执行Biz操作
                temp_BasicData_TrainingSubBiz.RemoveTemp_BasicData_TrainingSub(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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
        /// 查看RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void FindTemp_BasicData_TrainingSubByPK(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubBiz temp_BasicData_TrainingSubBiz = null;

            Temp_BasicData_TrainingSubEntity temp_BasicData_TrainingSubEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_TrainingSubBiz = new Temp_BasicData_TrainingSubBiz();

                //执行Biz操作
                temp_BasicData_TrainingSub = temp_BasicData_TrainingSubBiz.FindTemp_BasicData_TrainingSubByPK(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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

            return Temp_BasicData_TrainingSub;
        }

        /// <summary>
        /// 根据外键查找RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTemp_BasicData_TrainingSubEntity" type="Temp_BasicData_TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllTemp_BasicData_TrainingSubByForeignKeys(Object paramConnectionEntity, Temp_BasicData_TrainingSubEntity paramTemp_BasicData_TrainingSubEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            Temp_BasicData_TrainingSubBiz temp_BasicData_TrainingSubBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                temp_BasicData_TrainingSubBiz = new Temp_BasicData_TrainingSubBiz();

                //执行Biz操作
                objDataTable = temp_BasicData_TrainingSubBiz.FindAllTemp_BasicData_TrainingSubByForeignKeys(curConnectionEntity, paramTemp_BasicData_TrainingSub);

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