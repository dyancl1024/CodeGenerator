using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingExpertQA ( RH_TrainingExpertQA ) Dao类
    ///</summary>
    public class TrainingExpertQADao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingExpertQA : RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingExpertQA");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    TID,");
                strBuilder.Append("    QATitle,");
                strBuilder.Append("    QAContent,");
                strBuilder.Append("    ClickNum,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @TID,");
                strBuilder.Append("    @QATitle,");
                strBuilder.Append("    @QAContent,");
                strBuilder.Append("    @ClickNum,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertQAEntity.ID);

                ///项目id : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingExpertQAEntity.TID);

                ///答疑标题 : nvarchar(50) QATitle
                if (paramTrainingExpertQAEntity.QATitle != null && "".Equals(paramTrainingExpertQAEntity.QATitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QATitle", paramTrainingExpertQAEntity.QATitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QATitle", DBNull.Value);
                }

                ///答疑内容 : nvarchar(Max) QAContent
                if (paramTrainingExpertQAEntity.QAContent != null && "".Equals(paramTrainingExpertQAEntity.QAContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QAContent", paramTrainingExpertQAEntity.QAContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QAContent", DBNull.Value);
                }

                ///点击率 : int ClickNum
                m_sqlCmd.Parameters.AddWithValue("@ClickNum",paramTrainingExpertQAEntity.ClickNum);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingExpertQAEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingExpertQAEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingExpertQAEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingExpertQAEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingExpertQAEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingExpertQAEntity.UpdateTime);
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
        /// RH_TrainingExpertQA : RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingExpertQA");
                strBuilder.Append("  set ");
                strBuilder.Append("    TID=@TID,");
                strBuilder.Append("    QATitle=@QATitle,");
                strBuilder.Append("    QAContent=@QAContent,");
                strBuilder.Append("    ClickNum=@ClickNum,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertQAEntity.ID);

                ///项目id : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingExpertQAEntity.TID);

                ///答疑标题 : nvarchar(50) QATitle
                if (paramTrainingExpertQAEntity.QATitle != null && "".Equals(paramTrainingExpertQAEntity.QATitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QATitle", paramTrainingExpertQAEntity.QATitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QATitle", DBNull.Value);
                }

                ///答疑内容 : nvarchar(Max) QAContent
                if (paramTrainingExpertQAEntity.QAContent != null && "".Equals(paramTrainingExpertQAEntity.QAContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@QAContent", paramTrainingExpertQAEntity.QAContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@QAContent", DBNull.Value);
                }

                ///点击率 : int ClickNum
                m_sqlCmd.Parameters.AddWithValue("@ClickNum",paramTrainingExpertQAEntity.ClickNum);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingExpertQAEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingExpertQAEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingExpertQAEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingExpertQAEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingExpertQAEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingExpertQAEntity.UpdateTime);
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
        /// RH_TrainingExpertQA : RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingExpertQA");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertQAEntity.ID);

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
        /// RH_TrainingExpertQA : RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="TrainingExpertQAEntity"></returns>
        public TrainingExpertQAEntity SelectByPK(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingExpertQAEntity trainingExpertQAEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   QATitle AS QATitle,");
                strBuilder.Append("   QAContent AS QAContent,");
                strBuilder.Append("   ClickNum AS ClickNum,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingExpertQA");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertQAEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingExpertQAEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingExpertQAEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingExpertQA : RH_TrainingExpertQA
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQAEntity" type="TrainingExpertQAEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingExpertQAByForeignKeys(Object paramConnectionEntity, TrainingExpertQAEntity paramTrainingExpertQAEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingExpertQAEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   QATitle AS QATitle,");
                strBuilder.Append("   QAContent AS QAContent,");
                strBuilder.Append("   ClickNum AS ClickNum,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingExpertQA");
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
        /// <returns type="TrainingExpertQAEntity"></returns>
        private TrainingExpertQAEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingExpertQAMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}