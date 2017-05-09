using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_DesignAttachment ( RH_DesignAttachment ) Dao类
    ///</summary>
    public class DesignAttachmentDao
    {

        /// <summary>
        /// 添加
        /// RH_DesignAttachment : RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_DesignAttachment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DesignID,");
                strBuilder.Append("    AttachmentName,");
                strBuilder.Append("    AttachmentUrl,");
                strBuilder.Append("    AttachmentType,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DesignID,");
                strBuilder.Append("    @AttachmentName,");
                strBuilder.Append("    @AttachmentUrl,");
                strBuilder.Append("    @AttachmentType,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignAttachmentEntity.ID);

                ///DesignID : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramDesignAttachmentEntity.DesignID);

                ///AttachmentName : nvarchar(50) AttachmentName
                if (paramDesignAttachmentEntity.AttachmentName != null && "".Equals(paramDesignAttachmentEntity.AttachmentName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", paramDesignAttachmentEntity.AttachmentName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", DBNull.Value);
                }

                ///AttachmentUrl : nvarchar(50) AttachmentUrl
                if (paramDesignAttachmentEntity.AttachmentUrl != null && "".Equals(paramDesignAttachmentEntity.AttachmentUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", paramDesignAttachmentEntity.AttachmentUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", DBNull.Value);
                }

                ///AttachmentType : int AttachmentType
                m_sqlCmd.Parameters.AddWithValue("@AttachmentType",paramDesignAttachmentEntity.AttachmentType);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignAttachmentEntity.CreateTime);
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
        /// RH_DesignAttachment : RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_DesignAttachment");
                strBuilder.Append("  set ");
                strBuilder.Append("    DesignID=@DesignID,");
                strBuilder.Append("    AttachmentName=@AttachmentName,");
                strBuilder.Append("    AttachmentUrl=@AttachmentUrl,");
                strBuilder.Append("    AttachmentType=@AttachmentType,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignAttachmentEntity.ID);

                ///DesignID : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramDesignAttachmentEntity.DesignID);

                ///AttachmentName : nvarchar(50) AttachmentName
                if (paramDesignAttachmentEntity.AttachmentName != null && "".Equals(paramDesignAttachmentEntity.AttachmentName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", paramDesignAttachmentEntity.AttachmentName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", DBNull.Value);
                }

                ///AttachmentUrl : nvarchar(50) AttachmentUrl
                if (paramDesignAttachmentEntity.AttachmentUrl != null && "".Equals(paramDesignAttachmentEntity.AttachmentUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", paramDesignAttachmentEntity.AttachmentUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", DBNull.Value);
                }

                ///AttachmentType : int AttachmentType
                m_sqlCmd.Parameters.AddWithValue("@AttachmentType",paramDesignAttachmentEntity.AttachmentType);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramDesignAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramDesignAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramDesignAttachmentEntity.CreateTime);
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
        /// RH_DesignAttachment : RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_DesignAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignAttachmentEntity.ID);

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
        /// RH_DesignAttachment : RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="DesignAttachmentEntity"></returns>
        public DesignAttachmentEntity SelectByPK(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DesignAttachmentEntity designAttachmentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   AttachmentName AS AttachmentName,");
                strBuilder.Append("   AttachmentUrl AS AttachmentUrl,");
                strBuilder.Append("   AttachmentType AS AttachmentType,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_DesignAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramDesignAttachmentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        designAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return designAttachmentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_DesignAttachment : RH_DesignAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramDesignAttachmentEntity" type="DesignAttachmentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllDesignAttachmentByForeignKeys(Object paramConnectionEntity, DesignAttachmentEntity paramDesignAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable designAttachmentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   AttachmentName AS AttachmentName,");
                strBuilder.Append("   AttachmentUrl AS AttachmentUrl,");
                strBuilder.Append("   AttachmentType AS AttachmentType,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_DesignAttachment");
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
        /// <returns type="DesignAttachmentEntity"></returns>
        private DesignAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return DesignAttachmentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}