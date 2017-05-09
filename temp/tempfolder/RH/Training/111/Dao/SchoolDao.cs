using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_School ( RH_School ) Dao类
    ///</summary>
    public class SchoolDao
    {

        /// <summary>
        /// 添加
        /// RH_School : RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_School");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DistrictID,");
                strBuilder.Append("    SchoolName,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DistrictID,");
                strBuilder.Append("    @SchoolName,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
                strBuilder.Append("    @UpdateBy,");
                strBuilder.Append("    @UpdateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramSchoolEntity.ID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramSchoolEntity.DistrictID);

                ///SchoolName : nvarchar(50) SchoolName
                if (paramSchoolEntity.SchoolName != null && "".Equals(paramSchoolEntity.SchoolName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SchoolName", paramSchoolEntity.SchoolName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SchoolName", DBNull.Value);
                }

                ///Status : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramSchoolEntity.Status);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramSchoolEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramSchoolEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramSchoolEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramSchoolEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramSchoolEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramSchoolEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
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
        /// RH_School : RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_School");
                strBuilder.Append("  set ");
                strBuilder.Append("    DistrictID=@DistrictID,");
                strBuilder.Append("    SchoolName=@SchoolName,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
                strBuilder.Append("    UpdateBy=@UpdateBy,");
                strBuilder.Append("    UpdateTime=@UpdateTime");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramSchoolEntity.ID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramSchoolEntity.DistrictID);

                ///SchoolName : nvarchar(50) SchoolName
                if (paramSchoolEntity.SchoolName != null && "".Equals(paramSchoolEntity.SchoolName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@SchoolName", paramSchoolEntity.SchoolName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@SchoolName", DBNull.Value);
                }

                ///Status : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramSchoolEntity.Status);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramSchoolEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramSchoolEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramSchoolEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramSchoolEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramSchoolEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramSchoolEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
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
        /// RH_School : RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_School");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramSchoolEntity.ID);

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
        /// RH_School : RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="SchoolEntity"></returns>
        public SchoolEntity SelectByPK(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            SchoolEntity schoolEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   SchoolName AS SchoolName,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_School");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramSchoolEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        schoolEntity = ParseDataRowToEntity(dataRows[0]);
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

            return schoolEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_School : RH_School
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramSchoolEntity" type="SchoolEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllSchoolByForeignKeys(Object paramConnectionEntity, SchoolEntity paramSchoolEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable schoolEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   SchoolName AS SchoolName,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_School");
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
        /// <returns type="SchoolEntity"></returns>
        private SchoolEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return SchoolMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}