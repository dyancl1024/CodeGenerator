using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) Dao类
    ///</summary>
    public class TrainingTeacherSummaryDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingTeacherSummary : RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingTeacherSummary");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    TID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    Ttype,");
                strBuilder.Append("    TeacherSummaryTitle,");
                strBuilder.Append("    TeacherSummaryContent,");
                strBuilder.Append("    StaticUrl,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @TID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @Ttype,");
                strBuilder.Append("    @TeacherSummaryTitle,");
                strBuilder.Append("    @TeacherSummaryContent,");
                strBuilder.Append("    @StaticUrl,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingTeacherSummaryEntity.ID);

                ///总项目id : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingTeacherSummaryEntity.TID);

                ///阶段项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingTeacherSummaryEntity.SubTID);

                ///总结类型：1.辅导老师工作总结 2.项目总结（挂在总项目下，教务的操作） : int Ttype
                m_sqlCmd.Parameters.AddWithValue("@Ttype",paramTrainingTeacherSummaryEntity.Ttype);

                ///TeacherSummaryTitle : nvarchar(50) TeacherSummaryTitle
                if (paramTrainingTeacherSummaryEntity.TeacherSummaryTitle != null && "".Equals(paramTrainingTeacherSummaryEntity.TeacherSummaryTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherSummaryTitle", paramTrainingTeacherSummaryEntity.TeacherSummaryTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherSummaryTitle", DBNull.Value);
                }

                ///TeacherSummaryContent : nvarchar(Max) TeacherSummaryContent
                if (paramTrainingTeacherSummaryEntity.TeacherSummaryContent != null && "".Equals(paramTrainingTeacherSummaryEntity.TeacherSummaryContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherSummaryContent", paramTrainingTeacherSummaryEntity.TeacherSummaryContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherSummaryContent", DBNull.Value);
                }

                ///静态访问地址 : nvarchar(200) StaticUrl
                if (paramTrainingTeacherSummaryEntity.StaticUrl != null && "".Equals(paramTrainingTeacherSummaryEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingTeacherSummaryEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingTeacherSummaryEntity.CreateBy);

                ///发布时间 : datetime CreateTime
                if (paramTrainingTeacherSummaryEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingTeacherSummaryEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新时间 : datetime UpdateTime
                if (paramTrainingTeacherSummaryEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingTeacherSummaryEntity.UpdateTime);
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
        /// RH_TrainingTeacherSummary : RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingTeacherSummary");
                strBuilder.Append("  set ");
                strBuilder.Append("    TID=@TID,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    Ttype=@Ttype,");
                strBuilder.Append("    TeacherSummaryTitle=@TeacherSummaryTitle,");
                strBuilder.Append("    TeacherSummaryContent=@TeacherSummaryContent,");
                strBuilder.Append("    StaticUrl=@StaticUrl,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingTeacherSummaryEntity.ID);

                ///总项目id : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingTeacherSummaryEntity.TID);

                ///阶段项目id : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingTeacherSummaryEntity.SubTID);

                ///总结类型：1.辅导老师工作总结 2.项目总结（挂在总项目下，教务的操作） : int Ttype
                m_sqlCmd.Parameters.AddWithValue("@Ttype",paramTrainingTeacherSummaryEntity.Ttype);

                ///TeacherSummaryTitle : nvarchar(50) TeacherSummaryTitle
                if (paramTrainingTeacherSummaryEntity.TeacherSummaryTitle != null && "".Equals(paramTrainingTeacherSummaryEntity.TeacherSummaryTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherSummaryTitle", paramTrainingTeacherSummaryEntity.TeacherSummaryTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherSummaryTitle", DBNull.Value);
                }

                ///TeacherSummaryContent : nvarchar(Max) TeacherSummaryContent
                if (paramTrainingTeacherSummaryEntity.TeacherSummaryContent != null && "".Equals(paramTrainingTeacherSummaryEntity.TeacherSummaryContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherSummaryContent", paramTrainingTeacherSummaryEntity.TeacherSummaryContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TeacherSummaryContent", DBNull.Value);
                }

                ///静态访问地址 : nvarchar(200) StaticUrl
                if (paramTrainingTeacherSummaryEntity.StaticUrl != null && "".Equals(paramTrainingTeacherSummaryEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingTeacherSummaryEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingTeacherSummaryEntity.CreateBy);

                ///发布时间 : datetime CreateTime
                if (paramTrainingTeacherSummaryEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingTeacherSummaryEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新时间 : datetime UpdateTime
                if (paramTrainingTeacherSummaryEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingTeacherSummaryEntity.UpdateTime);
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
        /// RH_TrainingTeacherSummary : RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingTeacherSummary");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingTeacherSummaryEntity.ID);

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
        /// RH_TrainingTeacherSummary : RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="TrainingTeacherSummaryEntity"></returns>
        public TrainingTeacherSummaryEntity SelectByPK(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingTeacherSummaryEntity trainingTeacherSummaryEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   Ttype AS Ttype,");
                strBuilder.Append("   TeacherSummaryTitle AS TeacherSummaryTitle,");
                strBuilder.Append("   TeacherSummaryContent AS TeacherSummaryContent,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingTeacherSummary");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingTeacherSummaryEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingTeacherSummaryEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingTeacherSummaryEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingTeacherSummary : RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTeacherSummaryEntity" type="TrainingTeacherSummaryEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingTeacherSummaryByForeignKeys(Object paramConnectionEntity, TrainingTeacherSummaryEntity paramTrainingTeacherSummaryEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingTeacherSummaryEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   Ttype AS Ttype,");
                strBuilder.Append("   TeacherSummaryTitle AS TeacherSummaryTitle,");
                strBuilder.Append("   TeacherSummaryContent AS TeacherSummaryContent,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingTeacherSummary");
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
        /// <returns type="TrainingTeacherSummaryEntity"></returns>
        private TrainingTeacherSummaryEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingTeacherSummaryMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}