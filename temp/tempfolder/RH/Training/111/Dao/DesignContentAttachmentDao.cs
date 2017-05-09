using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_DesignContentAttachment ( RH_DesignContentAttachment ) Dao类
    ///</summary>
    public class DesignContentAttachmentDao
    {

        /// <summary>
        /// 添加
        /// RH_DesignContentAttachment : RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_DesignContentAttachment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DesignContentID,");
                strBuilder.Append("    AttachementName,");
                strBuilder.Append("    AttachmentUrl,");
                strBuilder.Append("    Version,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DesignContentID,");
                strBuilder.Append("    @AttachementName,");
                strBuilder.Append("    @AttachmentUrl,");
                strBuilder.Append("    @Version,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignContentAttachmentEntity.ID);

                ///DesignContentID : int DesignContentID
                m_sqlCmd.Parameters.AddWithValue("@DesignContentID",paramDesignContentAttachmentEntity.DesignContentID);

                ///AttachementName : nvarchar(50) AttachementName
                if (paramDesignContentAttachmentEntity.AttachementName != null && "".Equals(paramDesignContentAttachmentEntity.AttachementName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachementName", paramDesignContentAttachmentEntity.AttachementName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachementName", DBNull.Value);
                }

                ///AttachmentUrl : nvarchar(50) AttachmentUrl
                if (paramDesignContentAttachmentEntity.AttachmentUrl != null && "".Equals(paramDesignContentAttachmentEntity.AttachmentUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", paramDesignContentAttachmentEntity.AttachmentUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", DBNull.Value);
                }

                ///版本号：附件带版本号（系统自动编号），如：v1.0，2.0，按版本从高到低排序 : varchar(50) Version
                if (paramDesignContentAttachmentEntity.Version != null && "".Equals(paramDesignContentAttachmentEntity.Version.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Version", paramDesignContentAttachmentEntity.Version);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Version", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignContentAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignContentAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignContentAttachmentEntity.CreateTime);
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
        /// RH_DesignContentAttachment : RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_DesignContentAttachment");
                strBuilder.Append("  set ");
                strBuilder.Append("    DesignContentID=@DesignContentID,");
                strBuilder.Append("    AttachementName=@AttachementName,");
                strBuilder.Append("    AttachmentUrl=@AttachmentUrl,");
                strBuilder.Append("    Version=@Version,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignContentAttachmentEntity.ID);

                ///DesignContentID : int DesignContentID
                m_sqlCmd.Parameters.AddWithValue("@DesignContentID",paramDesignContentAttachmentEntity.DesignContentID);

                ///AttachementName : nvarchar(50) AttachementName
                if (paramDesignContentAttachmentEntity.AttachementName != null && "".Equals(paramDesignContentAttachmentEntity.AttachementName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachementName", paramDesignContentAttachmentEntity.AttachementName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachementName", DBNull.Value);
                }

                ///AttachmentUrl : nvarchar(50) AttachmentUrl
                if (paramDesignContentAttachmentEntity.AttachmentUrl != null && "".Equals(paramDesignContentAttachmentEntity.AttachmentUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", paramDesignContentAttachmentEntity.AttachmentUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", DBNull.Value);
                }

                ///版本号：附件带版本号（系统自动编号），如：v1.0，2.0，按版本从高到低排序 : varchar(50) Version
                if (paramDesignContentAttachmentEntity.Version != null && "".Equals(paramDesignContentAttachmentEntity.Version.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Version", paramDesignContentAttachmentEntity.Version);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Version", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignContentAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignContentAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignContentAttachmentEntity.CreateTime);
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
        /// RH_DesignContentAttachment : RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_DesignContentAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignContentAttachmentEntity.ID);

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
        /// RH_DesignContentAttachment : RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="DesignContentAttachmentEntity"></returns>
        public DesignContentAttachmentEntity SelectByPK(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DesignContentAttachmentEntity designContentAttachmentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignContentID AS DesignContentID,");
                strBuilder.Append("   AttachementName AS AttachementName,");
                strBuilder.Append("   AttachmentUrl AS AttachmentUrl,");
                strBuilder.Append("   Version AS Version,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_DesignContentAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignContentAttachmentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        designContentAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return designContentAttachmentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_DesignContentAttachment : RH_DesignContentAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignContentAttachmentEntity" type="DesignContentAttachmentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllDesignContentAttachmentByForeignKeys(Object paramConnectionEntity, DesignContentAttachmentEntity paramDesignContentAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable designContentAttachmentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignContentID AS DesignContentID,");
                strBuilder.Append("   AttachementName AS AttachementName,");
                strBuilder.Append("   AttachmentUrl AS AttachmentUrl,");
                strBuilder.Append("   Version AS Version,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_DesignContentAttachment");
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
        /// <returns type="DesignContentAttachmentEntity"></returns>
        private DesignContentAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return DesignContentAttachmentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}