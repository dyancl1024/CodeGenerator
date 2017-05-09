using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingOtherAttachment ( RH_TrainingOtherAttachment ) Dao类
    ///</summary>
    public class TrainingOtherAttachmentDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingOtherAttachment : RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingOtherAttachment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    TOID,");
                strBuilder.Append("    AttachmentName,");
                strBuilder.Append("    AttachmentURL,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @TOID,");
                strBuilder.Append("    @AttachmentName,");
                strBuilder.Append("    @AttachmentURL,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingOtherAttachmentEntity.ID);

                ///对应RH_TrainingOther表id : int TOID
                m_sqlCmd.Parameters.AddWithValue("@TOID",paramTrainingOtherAttachmentEntity.TOID);

                ///AttachmentName : nvarchar(200) AttachmentName
                if (paramTrainingOtherAttachmentEntity.AttachmentName != null && "".Equals(paramTrainingOtherAttachmentEntity.AttachmentName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", paramTrainingOtherAttachmentEntity.AttachmentName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", DBNull.Value);
                }

                ///AttachmentURL : nvarchar(200) AttachmentURL
                if (paramTrainingOtherAttachmentEntity.AttachmentURL != null && "".Equals(paramTrainingOtherAttachmentEntity.AttachmentURL.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentURL", paramTrainingOtherAttachmentEntity.AttachmentURL);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentURL", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingOtherAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTrainingOtherAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingOtherAttachmentEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingOtherAttachmentEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramTrainingOtherAttachmentEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingOtherAttachmentEntity.UpdateTime);
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
        /// RH_TrainingOtherAttachment : RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingOtherAttachment");
                strBuilder.Append("  set ");
                strBuilder.Append("    TOID=@TOID,");
                strBuilder.Append("    AttachmentName=@AttachmentName,");
                strBuilder.Append("    AttachmentURL=@AttachmentURL,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingOtherAttachmentEntity.ID);

                ///对应RH_TrainingOther表id : int TOID
                m_sqlCmd.Parameters.AddWithValue("@TOID",paramTrainingOtherAttachmentEntity.TOID);

                ///AttachmentName : nvarchar(200) AttachmentName
                if (paramTrainingOtherAttachmentEntity.AttachmentName != null && "".Equals(paramTrainingOtherAttachmentEntity.AttachmentName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", paramTrainingOtherAttachmentEntity.AttachmentName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", DBNull.Value);
                }

                ///AttachmentURL : nvarchar(200) AttachmentURL
                if (paramTrainingOtherAttachmentEntity.AttachmentURL != null && "".Equals(paramTrainingOtherAttachmentEntity.AttachmentURL.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentURL", paramTrainingOtherAttachmentEntity.AttachmentURL);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentURL", DBNull.Value);
                }

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingOtherAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTrainingOtherAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingOtherAttachmentEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///UpdateBy : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingOtherAttachmentEntity.UpdateBy);

                ///UpdateTime : datetime UpdateTime
                if (paramTrainingOtherAttachmentEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingOtherAttachmentEntity.UpdateTime);
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
        /// RH_TrainingOtherAttachment : RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingOtherAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingOtherAttachmentEntity.ID);

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
        /// RH_TrainingOtherAttachment : RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="TrainingOtherAttachmentEntity"></returns>
        public TrainingOtherAttachmentEntity SelectByPK(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingOtherAttachmentEntity trainingOtherAttachmentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TOID AS TOID,");
                strBuilder.Append("   AttachmentName AS AttachmentName,");
                strBuilder.Append("   AttachmentURL AS AttachmentURL,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingOtherAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingOtherAttachmentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingOtherAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingOtherAttachmentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingOtherAttachment : RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherAttachmentEntity" type="TrainingOtherAttachmentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingOtherAttachmentByForeignKeys(Object paramConnectionEntity, TrainingOtherAttachmentEntity paramTrainingOtherAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingOtherAttachmentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TOID AS TOID,");
                strBuilder.Append("   AttachmentName AS AttachmentName,");
                strBuilder.Append("   AttachmentURL AS AttachmentURL,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingOtherAttachment");
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
        /// <returns type="TrainingOtherAttachmentEntity"></returns>
        private TrainingOtherAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingOtherAttachmentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}