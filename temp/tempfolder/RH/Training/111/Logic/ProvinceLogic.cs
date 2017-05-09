using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_Province ( RH_Province ) Logic类
    ///</summary>
    public class ProvinceLogic
    {

        /// <summary>
        /// 添加RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void AddProvince(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceBiz provinceBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                provinceBiz = new ProvinceBiz();

                //执行Biz操作
                provinceBiz.AddProvince(curConnectionEntity, paramProvince);

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
        /// 修改RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyProvince(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceBiz provinceBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                provinceBiz = new ProvinceBiz();

                //执行Biz操作
                provinceBiz.ModifyProvince(curConnectionEntity, paramProvince);

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
        /// 删除RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveProvince(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceBiz provinceBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                provinceBiz = new ProvinceBiz();

                //执行Biz操作
                provinceBiz.RemoveProvince(curConnectionEntity, paramProvince);

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
        /// 查看RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void FindProvinceByPK(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceBiz provinceBiz = null;

            ProvinceEntity provinceEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                provinceBiz = new ProvinceBiz();

                //执行Biz操作
                province = provinceBiz.FindProvinceByPK(curConnectionEntity, paramProvince);

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

            return Province;
        }

        /// <summary>
        /// 根据外键查找RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllProvinceByForeignKeys(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            ProvinceBiz provinceBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                provinceBiz = new ProvinceBiz();

                //执行Biz操作
                objDataTable = provinceBiz.FindAllProvinceByForeignKeys(curConnectionEntity, paramProvince);

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