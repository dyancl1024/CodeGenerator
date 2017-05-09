using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_District ( RH_District ) Logic类
    ///</summary>
    public class DistrictLogic
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

            DistrictBiz districtBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                districtBiz = new DistrictBiz();

                //执行Biz操作
                districtBiz.AddDistrict(curConnectionEntity, paramDistrict);

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

            DistrictBiz districtBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                districtBiz = new DistrictBiz();

                //执行Biz操作
                districtBiz.ModifyDistrict(curConnectionEntity, paramDistrict);

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

            DistrictBiz districtBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                districtBiz = new DistrictBiz();

                //执行Biz操作
                districtBiz.RemoveDistrict(curConnectionEntity, paramDistrict);

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

            DistrictBiz districtBiz = null;

            DistrictEntity districtEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                districtBiz = new DistrictBiz();

                //执行Biz操作
                district = districtBiz.FindDistrictByPK(curConnectionEntity, paramDistrict);

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

            DistrictBiz districtBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                districtBiz = new DistrictBiz();

                //执行Biz操作
                objDataTable = districtBiz.FindAllDistrictByForeignKeys(curConnectionEntity, paramDistrict);

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