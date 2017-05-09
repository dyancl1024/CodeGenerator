using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_BannerObject ( RH_BannerObject ) Dao类
    ///</summary>
    public class BannerObjectDao
    {

        /// <summary>
        /// 添加
        /// RH_BannerObject : RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_BannerObject");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    BannerID,");
                strBuilder.Append("    ObjectID,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @BannerID,");
                strBuilder.Append("    @ObjectID,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime");
                strBuilder.Append("  )");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerObjectEntity.ID);

                ///BannerID : int BannerID
                m_sqlCmd.Parameters.AddWithValue("@BannerID",paramBannerObjectEntity.BannerID);

                ///ObjectID : int ObjectID
                m_sqlCmd.Parameters.AddWithValue("@ObjectID",paramBannerObjectEntity.ObjectID);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramBannerObjectEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramBannerObjectEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramBannerObjectEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 修改
        /// RH_BannerObject : RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_BannerObject");
                strBuilder.Append("  set ");
                strBuilder.Append("    BannerID=@BannerID,");
                strBuilder.Append("    ObjectID=@ObjectID,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime");
                strBuilder.Append("  where ");
                strBuilder.Append("    ID=@ID");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerObjectEntity.ID);

                ///BannerID : int BannerID
                m_sqlCmd.Parameters.AddWithValue("@BannerID",paramBannerObjectEntity.BannerID);

                ///ObjectID : int ObjectID
                m_sqlCmd.Parameters.AddWithValue("@ObjectID",paramBannerObjectEntity.ObjectID);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramBannerObjectEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramBannerObjectEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramBannerObjectEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 删除
        /// RH_BannerObject : RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_BannerObject");
                strBuilder.Append(" where ");
                strBuilder.Append("    ID=@ID");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerObjectEntity.ID);

                //执行数据库操作
                m_sqlCmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }
        }

        /// <summary>
        /// 查看
        /// RH_BannerObject : RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="BannerObjectEntity"></returns>
        public BannerObjectEntity SelectByPK(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            BannerObjectEntity bannerObjectEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   BannerID AS BannerID,");
                strBuilder.Append("   ObjectID AS ObjectID,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_BannerObject");
                strBuilder.Append("   where 1=1 ");
                strBuilder.Append("   AND ID=@ID ");

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                /////参数赋值

                ///ID : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramBannerObjectEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        bannerObjectEntity = ParseDataRowToEntity(dataRows[0]);
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }

            return bannerObjectEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_BannerObject : RH_BannerObject
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramBannerObjectEntity" type="BannerObjectEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllBannerObjectByForeignKeys(Object paramConnectionEntity, BannerObjectEntity paramBannerObjectEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable bannerObjectEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   BannerID AS BannerID,");
                strBuilder.Append("   ObjectID AS ObjectID,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_BannerObject");
                strBuilder.Append(" where 1=1 ");

                //---设置查询条件

                //向SQL字符串变量赋值
                strSQL = strBuilder.ToString();

                //获得数据库连接 
                SqlConnection sqlConn = ConnectionManager.GetSQLConnection(paramConnectionEntity);
                SqlTransaction sqlTrans = ConnectionManager.GetSQLTransaction(paramConnectionEntity);
                m_sqlCmd = new SqlCommand(strSQL, sqlConn);
                m_sqlCmd.Transaction = sqlTrans;

                //执行数据库操作
                SqlDataAdapter dat = new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //释放SqlCommand
                ConnectionManager.ReleaseSqlCommand(m_sqlCmd);
            }

            return objDataTable;
        }

        /// <summary>
        /// 实体映射
        /// </summary>
        /// <param name="dataRow" type="DataRow"></param>
        /// <returns type="BannerObjectEntity"></returns>
        private BannerObjectEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return BannerObjectMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}