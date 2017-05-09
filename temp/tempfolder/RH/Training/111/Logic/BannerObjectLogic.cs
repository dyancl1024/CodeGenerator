using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Biz;

namespace RH.Training.Logic
{
    ///<summary>
    ///RH_BannerObject ( RH_BannerObject ) Logic类
    ///</summary>
    public class BannerObjectLogic
    {

        /// <summary>
        /// 添加RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void AddBannerObject(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectBiz bannerObjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerObjectBiz = new BannerObjectBiz();

                //执行Biz操作
                bannerObjectBiz.AddBannerObject(curConnectionEntity, paramBannerObject);

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
        /// 修改RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void ModifyBannerObject(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectBiz bannerObjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerObjectBiz = new BannerObjectBiz();

                //执行Biz操作
                bannerObjectBiz.ModifyBannerObject(curConnectionEntity, paramBannerObject);

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
        /// 删除RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void RemoveBannerObject(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectBiz bannerObjectBiz = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerObjectBiz = new BannerObjectBiz();

                //执行Biz操作
                bannerObjectBiz.RemoveBannerObject(curConnectionEntity, paramBannerObject);

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
        /// 查看RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void FindBannerObjectByPK(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectBiz bannerObjectBiz = null;

            BannerObjectEntity bannerObjectEntity = null;

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerObjectBiz = new BannerObjectBiz();

                //执行Biz操作
                bannerObject = bannerObjectBiz.FindBannerObjectByPK(curConnectionEntity, paramBannerObject);

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

            return BannerObject;
        }

        /// <summary>
        /// 根据外键查找RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public DataTable FindAllBannerObjectByForeignKeys(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            DbConnectionEntity curConnectionEntity = null;

            BannerObjectBiz bannerObjectBiz = null;

            DataTable objDataTable = new DataTable();

            try
            {
                //-----------开始业务逻辑-------------
                //检查并初始化数据库连接
                curConnectionEntity = ConnectionManager.CheckAndGetConnection(paramConnectionEntity);

                //初始化Biz类
                bannerObjectBiz = new BannerObjectBiz();

                //执行Biz操作
                objDataTable = bannerObjectBiz.FindAllBannerObjectByForeignKeys(curConnectionEntity, paramBannerObject);

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