using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_CourseAttachment ( RH_CourseAttachment ) Dao类
    ///</summary>
    public class CourseAttachmentDao
    {

        /// <summary>
        /// 添加
        /// RH_CourseAttachment : RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_CourseAttachment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    CourseID,");
                strBuilder.Append("    AttachmentName,");
                strBuilder.Append("    AttachmentUrl,");
                strBuilder.Append("    AttachmentType,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @CourseID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseAttachmentEntity.ID);

                ///CourseID : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramCourseAttachmentEntity.CourseID);

                ///AttachmentName : nvarchar(50) AttachmentName
                if (paramCourseAttachmentEntity.AttachmentName != null && "".Equals(paramCourseAttachmentEntity.AttachmentName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", paramCourseAttachmentEntity.AttachmentName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", DBNull.Value);
                }

                ///AttachmentUrl : nvarchar(50) AttachmentUrl
                if (paramCourseAttachmentEntity.AttachmentUrl != null && "".Equals(paramCourseAttachmentEntity.AttachmentUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", paramCourseAttachmentEntity.AttachmentUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", DBNull.Value);
                }

                ///AttachmentType : int AttachmentType
                m_sqlCmd.Parameters.AddWithValue("@AttachmentType",paramCourseAttachmentEntity.AttachmentType);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramCourseAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramCourseAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramCourseAttachmentEntity.CreateTime);
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
        /// RH_CourseAttachment : RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_CourseAttachment");
                strBuilder.Append("  set ");
                strBuilder.Append("    CourseID=@CourseID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseAttachmentEntity.ID);

                ///CourseID : int CourseID
                m_sqlCmd.Parameters.AddWithValue("@CourseID",paramCourseAttachmentEntity.CourseID);

                ///AttachmentName : nvarchar(50) AttachmentName
                if (paramCourseAttachmentEntity.AttachmentName != null && "".Equals(paramCourseAttachmentEntity.AttachmentName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", paramCourseAttachmentEntity.AttachmentName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentName", DBNull.Value);
                }

                ///AttachmentUrl : nvarchar(50) AttachmentUrl
                if (paramCourseAttachmentEntity.AttachmentUrl != null && "".Equals(paramCourseAttachmentEntity.AttachmentUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", paramCourseAttachmentEntity.AttachmentUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AttachmentUrl", DBNull.Value);
                }

                ///AttachmentType : int AttachmentType
                m_sqlCmd.Parameters.AddWithValue("@AttachmentType",paramCourseAttachmentEntity.AttachmentType);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramCourseAttachmentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramCourseAttachmentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramCourseAttachmentEntity.CreateTime);
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
        /// RH_CourseAttachment : RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_CourseAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseAttachmentEntity.ID);

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
        /// RH_CourseAttachment : RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="CourseAttachmentEntity"></returns>
        public CourseAttachmentEntity SelectByPK(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            CourseAttachmentEntity courseAttachmentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   AttachmentName AS AttachmentName,");
                strBuilder.Append("   AttachmentUrl AS AttachmentUrl,");
                strBuilder.Append("   AttachmentType AS AttachmentType,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_CourseAttachment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramCourseAttachmentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        courseAttachmentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return courseAttachmentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_CourseAttachment : RH_CourseAttachment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramCourseAttachmentEntity" type="CourseAttachmentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllCourseAttachmentByForeignKeys(Object paramConnectionEntity, CourseAttachmentEntity paramCourseAttachmentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable courseAttachmentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   CourseID AS CourseID,");
                strBuilder.Append("   AttachmentName AS AttachmentName,");
                strBuilder.Append("   AttachmentUrl AS AttachmentUrl,");
                strBuilder.Append("   AttachmentType AS AttachmentType,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_CourseAttachment");
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
        /// <returns type="CourseAttachmentEntity"></returns>
        private CourseAttachmentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return CourseAttachmentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}