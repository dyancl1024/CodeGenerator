using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingHomeWorkAttachment ( RH_TrainingHomeWorkAttachment ) Dao类
    ///</summary>
    public class TrainingHomeWorkAttachmentDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingHomeWorkAttachment : RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingHomeWorkAttachment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    HomeWorkID,");
                strBuilder.Append("    AttachmentName,");
                strBuilder.Append("    AttachmentUrl,");
                strBuilder.Append("    AttachmentType,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @HomeWorkID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkAttachmentEntity.ID);

                ///HomeWorkID : int HomeWorkID
                m_sqlCmd.Parameters.AddWithValue("@HomeWorkID",paramTrainingHomeWorkAttachmentEntity.HomeWorkID);

                ///AttachmentName : nvarchar(50) AttachmentName
                if (paramTrainingHomeWorkAttachmentEntity.AttachmentName != null && "".Equals(paramTrainingHomeWorkAttachmentEntity.AttachmentName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", paramTrainingHomeWorkAttachmentEntity.AttachmentName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", DBNull.Value);
                }

                ///AttachmentUrl : nvarchar(50) AttachmentUrl
                if (paramTrainingHomeWorkAttachmentEntity.AttachmentUrl != null && "".Equals(paramTrainingHomeWorkAttachmentEntity.AttachmentUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", paramTrainingHomeWorkAttachmentEntity.AttachmentUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", DBNull.Value);
                }

                ///1-文本 2-视频 3-图片 4-音频 : int AttachmentType
                m_sqlCmd.Parameters.AddWithValue("@AttachmentType",paramTrainingHomeWorkAttachmentEntity.AttachmentType);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingHomeWorkAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTrainingHomeWorkAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingHomeWorkAttachmentEntity.CreateTime);
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
        /// RH_TrainingHomeWorkAttachment : RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingHomeWorkAttachment");
                strBuilder.Append("  set ");
                strBuilder.Append("    HomeWorkID=@HomeWorkID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkAttachmentEntity.ID);

                ///HomeWorkID : int HomeWorkID
                m_sqlCmd.Parameters.AddWithValue("@HomeWorkID",paramTrainingHomeWorkAttachmentEntity.HomeWorkID);

                ///AttachmentName : nvarchar(50) AttachmentName
                if (paramTrainingHomeWorkAttachmentEntity.AttachmentName != null && "".Equals(paramTrainingHomeWorkAttachmentEntity.AttachmentName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", paramTrainingHomeWorkAttachmentEntity.AttachmentName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", DBNull.Value);
                }

                ///AttachmentUrl : nvarchar(50) AttachmentUrl
                if (paramTrainingHomeWorkAttachmentEntity.AttachmentUrl != null && "".Equals(paramTrainingHomeWorkAttachmentEntity.AttachmentUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", paramTrainingHomeWorkAttachmentEntity.AttachmentUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", DBNull.Value);
                }

                ///1-文本 2-视频 3-图片 4-音频 : int AttachmentType
                m_sqlCmd.Parameters.AddWithValue("@AttachmentType",paramTrainingHomeWorkAttachmentEntity.AttachmentType);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingHomeWorkAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTrainingHomeWorkAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingHomeWorkAttachmentEntity.CreateTime);
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
        /// RH_TrainingHomeWorkAttachment : RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingHomeWorkAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkAttachmentEntity.ID);

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
        /// RH_TrainingHomeWorkAttachment : RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="TrainingHomeWorkAttachmentEntity"></returns>
        public TrainingHomeWorkAttachmentEntity SelectByPK(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingHomeWorkAttachmentEntity trainingHomeWorkAttachmentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   HomeWorkID AS HomeWorkID,");
                strBuilder.Append("   AttachmentName AS AttachmentName,");
                strBuilder.Append("   AttachmentUrl AS AttachmentUrl,");
                strBuilder.Append("   AttachmentType AS AttachmentType,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingHomeWorkAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkAttachmentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingHomeWorkAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingHomeWorkAttachmentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingHomeWorkAttachment : RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkAttachmentEntity" type="TrainingHomeWorkAttachmentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingHomeWorkAttachmentByForeignKeys(Object paramConnectionEntity, TrainingHomeWorkAttachmentEntity paramTrainingHomeWorkAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingHomeWorkAttachmentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   HomeWorkID AS HomeWorkID,");
                strBuilder.Append("   AttachmentName AS AttachmentName,");
                strBuilder.Append("   AttachmentUrl AS AttachmentUrl,");
                strBuilder.Append("   AttachmentType AS AttachmentType,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingHomeWorkAttachment");
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
        /// <returns type="TrainingHomeWorkAttachmentEntity"></returns>
        private TrainingHomeWorkAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingHomeWorkAttachmentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}