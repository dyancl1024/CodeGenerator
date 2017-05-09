using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_City ( RH_City ) Logic类
    ///</summary>
    public class CityLogic
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

            CityBiz cityBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                cityBiz = new CityBiz();

                //执行Biz操作
                cityBiz.AddCity(curConnectionEntity, paramCity);

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

            CityBiz cityBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                cityBiz = new CityBiz();

                //执行Biz操作
                cityBiz.ModifyCity(curConnectionEntity, paramCity);

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

            CityBiz cityBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                cityBiz = new CityBiz();

                //执行Biz操作
                cityBiz.RemoveCity(curConnectionEntity, paramCity);

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

            CityBiz cityBiz = null;

            CityEntity cityEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                cityBiz = new CityBiz();

                //执行Biz操作
                city = cityBiz.FindCityByPK(curConnectionEntity, paramCity);

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

            CityBiz cityBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                cityBiz = new CityBiz();

                //执行Biz操作
                objDataTable = cityBiz.FindAllCityByForeignKeys(curConnectionEntity, paramCity);

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