using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_District ( RH_District ) Dao类
    ///</summary>
    public class DistrictDao
    {

        /// <summary>
        /// 添加
        /// RH_District : RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_District");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DistrictName,");
                strBuilder.Append("    DistrictPY,");
                strBuilder.Append("    CityID");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DistrictName,");
                strBuilder.Append("    @DistrictPY,");
                strBuilder.Append("    @CityID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDistrictEntity.ID);

                ///DistrictName : nvarchar(50) DistrictName
                if (paramDistrictEntity.DistrictName != null && "".Equals(paramDistrictEntity.DistrictName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DistrictName", paramDistrictEntity.DistrictName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DistrictName", DBNull.Value);
                }

                ///DistrictPY : varchar(50) DistrictPY
                if (paramDistrictEntity.DistrictPY != null && "".Equals(paramDistrictEntity.DistrictPY.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DistrictPY", paramDistrictEntity.DistrictPY);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DistrictPY", DBNull.Value);
                }

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramDistrictEntity.CityID);

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
        /// RH_District : RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_District");
                strBuilder.Append("  set ");
                strBuilder.Append("    DistrictName=@DistrictName,");
                strBuilder.Append("    DistrictPY=@DistrictPY,");
                strBuilder.Append("    CityID=@CityID");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDistrictEntity.ID);

                ///DistrictName : nvarchar(50) DistrictName
                if (paramDistrictEntity.DistrictName != null && "".Equals(paramDistrictEntity.DistrictName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DistrictName", paramDistrictEntity.DistrictName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DistrictName", DBNull.Value);
                }

                ///DistrictPY : varchar(50) DistrictPY
                if (paramDistrictEntity.DistrictPY != null && "".Equals(paramDistrictEntity.DistrictPY.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DistrictPY", paramDistrictEntity.DistrictPY);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DistrictPY", DBNull.Value);
                }

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramDistrictEntity.CityID);

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
        /// RH_District : RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_District");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDistrictEntity.ID);

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
        /// RH_District : RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="DistrictEntity"></returns>
        public DistrictEntity SelectByPK(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DistrictEntity districtEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DistrictName AS DistrictName,");
                strBuilder.Append("   DistrictPY AS DistrictPY,");
                strBuilder.Append("   CityID AS CityID");
                strBuilder.Append(" from RH_District");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDistrictEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        districtEntity = ParseDataRowToEntity(dataRows[0]);
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

            return districtEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_District : RH_District
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDistrictEntity" type="DistrictEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllDistrictByForeignKeys(Object paramConnectionEntity, DistrictEntity paramDistrictEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable districtEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DistrictName AS DistrictName,");
                strBuilder.Append("   DistrictPY AS DistrictPY,");
                strBuilder.Append("   CityID AS CityID");
                strBuilder.Append(" from RH_District");
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
        /// <returns type="DistrictEntity"></returns>
        private DistrictEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return DistrictMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}