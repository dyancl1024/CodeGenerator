using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_District ( RH_District ) Biz类
    ///</summary>
    public class DistrictBiz
    {

        /// <summary>
        /// 添加RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="void"></returns>
        public void AddDistrict(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DistrictDao districtDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                districtDao = new DistrictDao();

                //执行DAO操作
                districtDao.Insert(curConnectionEntity, paramDistrict);

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
        /// 修改RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyDistrict(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DistrictDao districtDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                districtDao = new DistrictDao();

                //执行DAO操作
                districtDao.Update(curConnectionEntity, paramDistrict);

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
        /// 删除RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveDistrict(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DistrictDao districtDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                districtDao = new DistrictDao();

                //执行DAO操作
                districtDao.Delete(curConnectionEntity, paramDistrict);

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
        /// 查看RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="void"></returns>
        public void FindDistrictByPK(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DistrictDao districtDao = null;

            DistrictEntity districtEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                districtDao = new DistrictDao();

                //执行DAO操作
                district = districtDao.SelectByPK(curConnectionEntity, paramDistrict);

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

            return District;
        }

        /// <summary>
        /// 根据外键查找RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllDistrictByForeignKeys(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            DistrictDao districtDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                districtDao = new DistrictDao();

                //执行DAO操作
                objDataTable = districtDao.SelectAllDistrictByForeignKeys(curConnectionEntity, paramDistrict);

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