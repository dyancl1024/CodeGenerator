using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Province ( RH_Province ) Dao类
    ///</summary>
    public class ProvinceDao
    {

        /// <summary>
        /// 添加
        /// RH_Province : RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Province");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    ProvinceName,");
                strBuilder.Append("    ProvincePY,");
                strBuilder.Append("    CountyID,");
                strBuilder.Append("    Status");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @ProvinceName,");
                strBuilder.Append("    @ProvincePY,");
                strBuilder.Append("    @CountyID,");
                strBuilder.Append("    @Status");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramProvinceEntity.ID);

                ///ProvinceName : nvarchar(50) ProvinceName
                if (paramProvinceEntity.ProvinceName != null && "".Equals(paramProvinceEntity.ProvinceName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProvinceName", paramProvinceEntity.ProvinceName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProvinceName", DBNull.Value);
                }

                ///ProvincePY : varchar(50) ProvincePY
                if (paramProvinceEntity.ProvincePY != null && "".Equals(paramProvinceEntity.ProvincePY.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProvincePY", paramProvinceEntity.ProvincePY);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProvincePY", DBNull.Value);
                }

                ///CountyID : int CountyID
                m_sqlCmd.Parameters.AddWithValue("@CountyID",paramProvinceEntity.CountyID);

                ///Status : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramProvinceEntity.Status);

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
        /// RH_Province : RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Province");
                strBuilder.Append("  set ");
                strBuilder.Append("    ProvinceName=@ProvinceName,");
                strBuilder.Append("    ProvincePY=@ProvincePY,");
                strBuilder.Append("    CountyID=@CountyID,");
                strBuilder.Append("    Status=@Status");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramProvinceEntity.ID);

                ///ProvinceName : nvarchar(50) ProvinceName
                if (paramProvinceEntity.ProvinceName != null && "".Equals(paramProvinceEntity.ProvinceName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProvinceName", paramProvinceEntity.ProvinceName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProvinceName", DBNull.Value);
                }

                ///ProvincePY : varchar(50) ProvincePY
                if (paramProvinceEntity.ProvincePY != null && "".Equals(paramProvinceEntity.ProvincePY.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProvincePY", paramProvinceEntity.ProvincePY);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ProvincePY", DBNull.Value);
                }

                ///CountyID : int CountyID
                m_sqlCmd.Parameters.AddWithValue("@CountyID",paramProvinceEntity.CountyID);

                ///Status : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramProvinceEntity.Status);

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
        /// RH_Province : RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Province");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramProvinceEntity.ID);

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
        /// RH_Province : RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="ProvinceEntity"></returns>
        public ProvinceEntity SelectByPK(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            ProvinceEntity provinceEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ProvinceName AS ProvinceName,");
                strBuilder.Append("   ProvincePY AS ProvincePY,");
                strBuilder.Append("   CountyID AS CountyID,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_Province");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramProvinceEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        provinceEntity = ParseDataRowToEntity(dataRows[0]);
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

            return provinceEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Province : RH_Province
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramProvinceEntity" type="ProvinceEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllProvinceByForeignKeys(Object paramConnectionEntity, ProvinceEntity paramProvinceEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable provinceEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ProvinceName AS ProvinceName,");
                strBuilder.Append("   ProvincePY AS ProvincePY,");
                strBuilder.Append("   CountyID AS CountyID,");
                strBuilder.Append("   Status AS Status");
                strBuilder.Append(" from RH_Province");
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
        /// <returns type="ProvinceEntity"></returns>
        private ProvinceEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return ProvinceMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}