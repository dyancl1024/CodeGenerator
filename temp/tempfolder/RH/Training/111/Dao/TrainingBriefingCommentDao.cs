using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingBriefingComment ( RH_TrainingBriefingComment ) Dao类
    ///</summary>
    public class TrainingBriefingCommentDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingBriefingComment : RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingBriefingComment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    TBID,");
                strBuilder.Append("    Comment,");
                strBuilder.Append("    IPAdress,");
                strBuilder.Append("    ParentID,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @TBID,");
                strBuilder.Append("    @Comment,");
                strBuilder.Append("    @IPAdress,");
                strBuilder.Append("    @ParentID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingBriefingCommentEntity.ID);

                ///项目简报ID 对应RH_TrainingBriefing : int TBID
                m_sqlCmd.Parameters.AddWithValue("@TBID",paramTrainingBriefingCommentEntity.TBID);

                ///评论内容 : nvarchar(Max) Comment
                if (paramTrainingBriefingCommentEntity.Comment != null && "".Equals(paramTrainingBriefingCommentEntity.Comment.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", paramTrainingBriefingCommentEntity.Comment);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", DBNull.Value);
                }

                ///IP地址 : varchar(50) IPAdress
                if (paramTrainingBriefingCommentEntity.IPAdress != null && "".Equals(paramTrainingBriefingCommentEntity.IPAdress.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", paramTrainingBriefingCommentEntity.IPAdress);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", DBNull.Value);
                }

                ///评论的父级ID : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramTrainingBriefingCommentEntity.ParentID);

                ///评论人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingBriefingCommentEntity.CreateBy);

                ///评论时间 : datetime CreateTime
                if (paramTrainingBriefingCommentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingBriefingCommentEntity.CreateTime);
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
        /// RH_TrainingBriefingComment : RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingBriefingComment");
                strBuilder.Append("  set ");
                strBuilder.Append("    TBID=@TBID,");
                strBuilder.Append("    Comment=@Comment,");
                strBuilder.Append("    IPAdress=@IPAdress,");
                strBuilder.Append("    ParentID=@ParentID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingBriefingCommentEntity.ID);

                ///项目简报ID 对应RH_TrainingBriefing : int TBID
                m_sqlCmd.Parameters.AddWithValue("@TBID",paramTrainingBriefingCommentEntity.TBID);

                ///评论内容 : nvarchar(Max) Comment
                if (paramTrainingBriefingCommentEntity.Comment != null && "".Equals(paramTrainingBriefingCommentEntity.Comment.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", paramTrainingBriefingCommentEntity.Comment);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", DBNull.Value);
                }

                ///IP地址 : varchar(50) IPAdress
                if (paramTrainingBriefingCommentEntity.IPAdress != null && "".Equals(paramTrainingBriefingCommentEntity.IPAdress.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", paramTrainingBriefingCommentEntity.IPAdress);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", DBNull.Value);
                }

                ///评论的父级ID : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramTrainingBriefingCommentEntity.ParentID);

                ///评论人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingBriefingCommentEntity.CreateBy);

                ///评论时间 : datetime CreateTime
                if (paramTrainingBriefingCommentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingBriefingCommentEntity.CreateTime);
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
        /// RH_TrainingBriefingComment : RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingBriefingComment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingBriefingCommentEntity.ID);

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
        /// RH_TrainingBriefingComment : RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="TrainingBriefingCommentEntity"></returns>
        public TrainingBriefingCommentEntity SelectByPK(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingBriefingCommentEntity trainingBriefingCommentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TBID AS TBID,");
                strBuilder.Append("   Comment AS Comment,");
                strBuilder.Append("   IPAdress AS IPAdress,");
                strBuilder.Append("   ParentID AS ParentID,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingBriefingComment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingBriefingCommentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingBriefingCommentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingBriefingCommentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingBriefingComment : RH_TrainingBriefingComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingCommentEntity" type="TrainingBriefingCommentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingBriefingCommentByForeignKeys(Object paramConnectionEntity, TrainingBriefingCommentEntity paramTrainingBriefingCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingBriefingCommentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TBID AS TBID,");
                strBuilder.Append("   Comment AS Comment,");
                strBuilder.Append("   IPAdress AS IPAdress,");
                strBuilder.Append("   ParentID AS ParentID,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingBriefingComment");
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
        /// <returns type="TrainingBriefingCommentEntity"></returns>
        private TrainingBriefingCommentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingBriefingCommentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}