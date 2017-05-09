using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingStudyGroupComment ( RH_TrainingStudyGroupComment ) Dao类
    ///</summary>
    public class TrainingStudyGroupCommentDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingStudyGroupComment : RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingStudyGroupComment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    StudyGroupID,");
                strBuilder.Append("    CommentTitile,");
                strBuilder.Append("    Comment,");
                strBuilder.Append("    IPAdress,");
                strBuilder.Append("    ParentID,");
                strBuilder.Append("    IsExpert,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @StudyGroupID,");
                strBuilder.Append("    @CommentTitile,");
                strBuilder.Append("    @Comment,");
                strBuilder.Append("    @IPAdress,");
                strBuilder.Append("    @ParentID,");
                strBuilder.Append("    @IsExpert,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupCommentEntity.ID);

                ///StudyGroupID : int StudyGroupID
                m_sqlCmd.Parameters.AddWithValue("@StudyGroupID",paramTrainingStudyGroupCommentEntity.StudyGroupID);

                ///CommentTitile : nvarchar(50) CommentTitile
                if (paramTrainingStudyGroupCommentEntity.CommentTitile != null && "".Equals(paramTrainingStudyGroupCommentEntity.CommentTitile.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CommentTitile", paramTrainingStudyGroupCommentEntity.CommentTitile);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CommentTitile", DBNull.Value);
                }

                ///评论内容 : nvarchar(Max) Comment
                if (paramTrainingStudyGroupCommentEntity.Comment != null && "".Equals(paramTrainingStudyGroupCommentEntity.Comment.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", paramTrainingStudyGroupCommentEntity.Comment);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", DBNull.Value);
                }

                ///IP地址 : varchar(50) IPAdress
                if (paramTrainingStudyGroupCommentEntity.IPAdress != null && "".Equals(paramTrainingStudyGroupCommentEntity.IPAdress.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", paramTrainingStudyGroupCommentEntity.IPAdress);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", DBNull.Value);
                }

                ///评论的父级ID : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramTrainingStudyGroupCommentEntity.ParentID);

                ///1.专家2.非专家 : int IsExpert
                m_sqlCmd.Parameters.AddWithValue("@IsExpert",paramTrainingStudyGroupCommentEntity.IsExpert);

                ///评论人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingStudyGroupCommentEntity.CreateBy);

                ///评论时间 : datetime CreateTime
                if (paramTrainingStudyGroupCommentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingStudyGroupCommentEntity.CreateTime);
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
        /// RH_TrainingStudyGroupComment : RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingStudyGroupComment");
                strBuilder.Append("  set ");
                strBuilder.Append("    StudyGroupID=@StudyGroupID,");
                strBuilder.Append("    CommentTitile=@CommentTitile,");
                strBuilder.Append("    Comment=@Comment,");
                strBuilder.Append("    IPAdress=@IPAdress,");
                strBuilder.Append("    ParentID=@ParentID,");
                strBuilder.Append("    IsExpert=@IsExpert,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupCommentEntity.ID);

                ///StudyGroupID : int StudyGroupID
                m_sqlCmd.Parameters.AddWithValue("@StudyGroupID",paramTrainingStudyGroupCommentEntity.StudyGroupID);

                ///CommentTitile : nvarchar(50) CommentTitile
                if (paramTrainingStudyGroupCommentEntity.CommentTitile != null && "".Equals(paramTrainingStudyGroupCommentEntity.CommentTitile.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@CommentTitile", paramTrainingStudyGroupCommentEntity.CommentTitile);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CommentTitile", DBNull.Value);
                }

                ///评论内容 : nvarchar(Max) Comment
                if (paramTrainingStudyGroupCommentEntity.Comment != null && "".Equals(paramTrainingStudyGroupCommentEntity.Comment.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", paramTrainingStudyGroupCommentEntity.Comment);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", DBNull.Value);
                }

                ///IP地址 : varchar(50) IPAdress
                if (paramTrainingStudyGroupCommentEntity.IPAdress != null && "".Equals(paramTrainingStudyGroupCommentEntity.IPAdress.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", paramTrainingStudyGroupCommentEntity.IPAdress);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", DBNull.Value);
                }

                ///评论的父级ID : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramTrainingStudyGroupCommentEntity.ParentID);

                ///1.专家2.非专家 : int IsExpert
                m_sqlCmd.Parameters.AddWithValue("@IsExpert",paramTrainingStudyGroupCommentEntity.IsExpert);

                ///评论人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingStudyGroupCommentEntity.CreateBy);

                ///评论时间 : datetime CreateTime
                if (paramTrainingStudyGroupCommentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingStudyGroupCommentEntity.CreateTime);
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
        /// RH_TrainingStudyGroupComment : RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingStudyGroupComment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupCommentEntity.ID);

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
        /// RH_TrainingStudyGroupComment : RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="TrainingStudyGroupCommentEntity"></returns>
        public TrainingStudyGroupCommentEntity SelectByPK(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingStudyGroupCommentEntity trainingStudyGroupCommentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   StudyGroupID AS StudyGroupID,");
                strBuilder.Append("   CommentTitile AS CommentTitile,");
                strBuilder.Append("   Comment AS Comment,");
                strBuilder.Append("   IPAdress AS IPAdress,");
                strBuilder.Append("   ParentID AS ParentID,");
                strBuilder.Append("   IsExpert AS IsExpert,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingStudyGroupComment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingStudyGroupCommentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingStudyGroupCommentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingStudyGroupCommentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingStudyGroupComment : RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingStudyGroupCommentEntity" type="TrainingStudyGroupCommentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingStudyGroupCommentByForeignKeys(Object paramConnectionEntity, TrainingStudyGroupCommentEntity paramTrainingStudyGroupCommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingStudyGroupCommentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   StudyGroupID AS StudyGroupID,");
                strBuilder.Append("   CommentTitile AS CommentTitile,");
                strBuilder.Append("   Comment AS Comment,");
                strBuilder.Append("   IPAdress AS IPAdress,");
                strBuilder.Append("   ParentID AS ParentID,");
                strBuilder.Append("   IsExpert AS IsExpert,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingStudyGroupComment");
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
        /// <returns type="TrainingStudyGroupCommentEntity"></returns>
        private TrainingStudyGroupCommentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingStudyGroupCommentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}