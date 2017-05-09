using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingOther ( RH_TrainingOther ) Dao类
    ///</summary>
    public class TrainingOtherDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingOther : RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingOther");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    TID,");
                strBuilder.Append("    SubTID,");
                strBuilder.Append("    TTitle,");
                strBuilder.Append("    TType,");
                strBuilder.Append("    TContent,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @TID,");
                strBuilder.Append("    @SubTID,");
                strBuilder.Append("    @TTitle,");
                strBuilder.Append("    @TType,");
                strBuilder.Append("    @TContent,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingOtherEntity.ID);

                ///TID : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingOtherEntity.TID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingOtherEntity.SubTID);

                ///TTitle : nvarchar(50) TTitle
                if (paramTrainingOtherEntity.TTitle != null && "".Equals(paramTrainingOtherEntity.TTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TTitle", paramTrainingOtherEntity.TTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TTitle", DBNull.Value);
                }

                ///项目附属信息  1.项目考核方案 2.学员手册 3.辅导老师手册 4.项目实施方案 : int TType
                m_sqlCmd.Parameters.AddWithValue("@TType",paramTrainingOtherEntity.TType);

                ///TContent : nvarchar(Max) TContent
                if (paramTrainingOtherEntity.TContent != null && "".Equals(paramTrainingOtherEntity.TContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TContent", paramTrainingOtherEntity.TContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TContent", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingOtherEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingOtherEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingOtherEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingOtherEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingOtherEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingOtherEntity.UpdateTime);
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
        /// RH_TrainingOther : RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingOther");
                strBuilder.Append("  set ");
                strBuilder.Append("    TID=@TID,");
                strBuilder.Append("    SubTID=@SubTID,");
                strBuilder.Append("    TTitle=@TTitle,");
                strBuilder.Append("    TType=@TType,");
                strBuilder.Append("    TContent=@TContent,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingOtherEntity.ID);

                ///TID : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingOtherEntity.TID);

                ///SubTID : int SubTID
                m_sqlCmd.Parameters.AddWithValue("@SubTID",paramTrainingOtherEntity.SubTID);

                ///TTitle : nvarchar(50) TTitle
                if (paramTrainingOtherEntity.TTitle != null && "".Equals(paramTrainingOtherEntity.TTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TTitle", paramTrainingOtherEntity.TTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TTitle", DBNull.Value);
                }

                ///项目附属信息  1.项目考核方案 2.学员手册 3.辅导老师手册 4.项目实施方案 : int TType
                m_sqlCmd.Parameters.AddWithValue("@TType",paramTrainingOtherEntity.TType);

                ///TContent : nvarchar(Max) TContent
                if (paramTrainingOtherEntity.TContent != null && "".Equals(paramTrainingOtherEntity.TContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TContent", paramTrainingOtherEntity.TContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TContent", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingOtherEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingOtherEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingOtherEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingOtherEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingOtherEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingOtherEntity.UpdateTime);
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
        /// RH_TrainingOther : RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingOther");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingOtherEntity.ID);

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
        /// RH_TrainingOther : RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="TrainingOtherEntity"></returns>
        public TrainingOtherEntity SelectByPK(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingOtherEntity trainingOtherEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   TTitle AS TTitle,");
                strBuilder.Append("   TType AS TType,");
                strBuilder.Append("   TContent AS TContent,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingOther");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingOtherEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingOtherEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingOtherEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingOther : RH_TrainingOther
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingOtherEntity" type="TrainingOtherEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingOtherByForeignKeys(Object paramConnectionEntity, TrainingOtherEntity paramTrainingOtherEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingOtherEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   SubTID AS SubTID,");
                strBuilder.Append("   TTitle AS TTitle,");
                strBuilder.Append("   TType AS TType,");
                strBuilder.Append("   TContent AS TContent,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingOther");
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
        /// <returns type="TrainingOtherEntity"></returns>
        private TrainingOtherEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingOtherMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}