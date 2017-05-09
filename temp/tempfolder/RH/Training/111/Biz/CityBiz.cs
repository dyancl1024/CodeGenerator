using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Dao;

namespace RH.Training.Biz
{
    ///<summary>
    ///RH_City ( RH_City ) Biz类
    ///</summary>
    public class CityBiz
    {

        /// <summary>
        /// 添加RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="void"></returns>
        public void AddCity(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CityDao cityDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                cityDao = new CityDao();

                //执行DAO操作
                cityDao.Insert(curConnectionEntity, paramCity);

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
        /// 修改RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyCity(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CityDao cityDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                cityDao = new CityDao();

                //执行DAO操作
                cityDao.Update(curConnectionEntity, paramCity);

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
        /// 删除RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveCity(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CityDao cityDao = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                cityDao = new CityDao();

                //执行DAO操作
                cityDao.Delete(curConnectionEntity, paramCity);

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
        /// 查看RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="void"></returns>
        public void FindCityByPK(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CityDao cityDao = null;

            CityEntity cityEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                cityDao = new CityDao();

                //执行DAO操作
                city = cityDao.SelectByPK(curConnectionEntity, paramCity);

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

            return City;
        }

        /// <summary>
        /// 根据外键查找RH_City
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCityEntity" type="CityEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllCityByForeignKeys(Object paramConnectionEntity, CityEntity paramCityEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            CityDao cityDao = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化DAO类
                cityDao = new CityDao();

                //执行DAO操作
                objDataTable = cityDao.SelectAllCityByForeignKeys(curConnectionEntity, paramCity);

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