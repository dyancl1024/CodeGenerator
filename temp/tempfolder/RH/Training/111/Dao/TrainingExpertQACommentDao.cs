using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingExpertQAComment ( RH_TrainingExpertQAComment ) Dao类
    ///</summary>
    public class TrainingExpertQACommentDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingExpertQAComment : RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingExpertQAComment");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    QAID,");
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
                strBuilder.Append("    @QAID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertQACommentEntity.ID);

                ///QAID : int QAID
                m_sqlCmd.Parameters.AddWithValue("@QAID",paramTrainingExpertQACommentEntity.QAID);

                ///Comment : nvarchar(Max) Comment
                if (paramTrainingExpertQACommentEntity.Comment != null && "".Equals(paramTrainingExpertQACommentEntity.Comment.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", paramTrainingExpertQACommentEntity.Comment);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", DBNull.Value);
                }

                ///IPAdress : varchar(50) IPAdress
                if (paramTrainingExpertQACommentEntity.IPAdress != null && "".Equals(paramTrainingExpertQACommentEntity.IPAdress.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", paramTrainingExpertQACommentEntity.IPAdress);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", DBNull.Value);
                }

                ///ParentID : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramTrainingExpertQACommentEntity.ParentID);

                ///是否专家回答 1.是 2.否 : int IsExpert
                m_sqlCmd.Parameters.AddWithValue("@IsExpert",paramTrainingExpertQACommentEntity.IsExpert);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingExpertQACommentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTrainingExpertQACommentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingExpertQACommentEntity.CreateTime);
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
        /// RH_TrainingExpertQAComment : RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingExpertQAComment");
                strBuilder.Append("  set ");
                strBuilder.Append("    QAID=@QAID,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertQACommentEntity.ID);

                ///QAID : int QAID
                m_sqlCmd.Parameters.AddWithValue("@QAID",paramTrainingExpertQACommentEntity.QAID);

                ///Comment : nvarchar(Max) Comment
                if (paramTrainingExpertQACommentEntity.Comment != null && "".Equals(paramTrainingExpertQACommentEntity.Comment.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", paramTrainingExpertQACommentEntity.Comment);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Comment", DBNull.Value);
                }

                ///IPAdress : varchar(50) IPAdress
                if (paramTrainingExpertQACommentEntity.IPAdress != null && "".Equals(paramTrainingExpertQACommentEntity.IPAdress.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", paramTrainingExpertQACommentEntity.IPAdress);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@IPAdress", DBNull.Value);
                }

                ///ParentID : int ParentID
                m_sqlCmd.Parameters.AddWithValue("@ParentID",paramTrainingExpertQACommentEntity.ParentID);

                ///是否专家回答 1.是 2.否 : int IsExpert
                m_sqlCmd.Parameters.AddWithValue("@IsExpert",paramTrainingExpertQACommentEntity.IsExpert);

                ///CreateBy : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingExpertQACommentEntity.CreateBy);

                ///CreateTime : datetime CreateTime
                if (paramTrainingExpertQACommentEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingExpertQACommentEntity.CreateTime);
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
        /// RH_TrainingExpertQAComment : RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingExpertQAComment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertQACommentEntity.ID);

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
        /// RH_TrainingExpertQAComment : RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="TrainingExpertQACommentEntity"></returns>
        public TrainingExpertQACommentEntity SelectByPK(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingExpertQACommentEntity trainingExpertQACommentEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   QAID AS QAID,");
                strBuilder.Append("   Comment AS Comment,");
                strBuilder.Append("   IPAdress AS IPAdress,");
                strBuilder.Append("   ParentID AS ParentID,");
                strBuilder.Append("   IsExpert AS IsExpert,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingExpertQAComment");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingExpertQACommentEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingExpertQACommentEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingExpertQACommentEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingExpertQAComment : RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingExpertQACommentEntity" type="TrainingExpertQACommentEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingExpertQACommentByForeignKeys(Object paramConnectionEntity, TrainingExpertQACommentEntity paramTrainingExpertQACommentEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingExpertQACommentEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   QAID AS QAID,");
                strBuilder.Append("   Comment AS Comment,");
                strBuilder.Append("   IPAdress AS IPAdress,");
                strBuilder.Append("   ParentID AS ParentID,");
                strBuilder.Append("   IsExpert AS IsExpert,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime");
                strBuilder.Append(" from RH_TrainingExpertQAComment");
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
        /// <returns type="TrainingExpertQACommentEntity"></returns>
        private TrainingExpertQACommentEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingExpertQACommentMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}