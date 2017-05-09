using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingHomeWorkType ( RH_TrainingHomeWorkType ) Dao类
    ///</summary>
    public class TrainingHomeWorkTypeDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingHomeWorkType : RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingHomeWorkType");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    Name,");
                strBuilder.Append("    Code,");
                strBuilder.Append("    Sort");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @Name,");
                strBuilder.Append("    @Code,");
                strBuilder.Append("    @Sort");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkTypeEntity.ID);

                ///Name : nvarchar(50) Name
                if (paramTrainingHomeWorkTypeEntity.Name != null && "".Equals(paramTrainingHomeWorkTypeEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramTrainingHomeWorkTypeEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///Code : varchar(50) Code
                if (paramTrainingHomeWorkTypeEntity.Code != null && "".Equals(paramTrainingHomeWorkTypeEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramTrainingHomeWorkTypeEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramTrainingHomeWorkTypeEntity.Sort);

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
        /// RH_TrainingHomeWorkType : RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingHomeWorkType");
                strBuilder.Append("  set ");
                strBuilder.Append("    Name=@Name,");
                strBuilder.Append("    Code=@Code,");
                strBuilder.Append("    Sort=@Sort");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkTypeEntity.ID);

                ///Name : nvarchar(50) Name
                if (paramTrainingHomeWorkTypeEntity.Name != null && "".Equals(paramTrainingHomeWorkTypeEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramTrainingHomeWorkTypeEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///Code : varchar(50) Code
                if (paramTrainingHomeWorkTypeEntity.Code != null && "".Equals(paramTrainingHomeWorkTypeEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramTrainingHomeWorkTypeEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramTrainingHomeWorkTypeEntity.Sort);

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
        /// RH_TrainingHomeWorkType : RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingHomeWorkType");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkTypeEntity.ID);

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
        /// RH_TrainingHomeWorkType : RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="TrainingHomeWorkTypeEntity"></returns>
        public TrainingHomeWorkTypeEntity SelectByPK(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingHomeWorkTypeEntity trainingHomeWorkTypeEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Sort AS Sort");
                strBuilder.Append(" from RH_TrainingHomeWorkType");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingHomeWorkTypeEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingHomeWorkTypeEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingHomeWorkTypeEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingHomeWorkType : RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingHomeWorkTypeEntity" type="TrainingHomeWorkTypeEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingHomeWorkTypeByForeignKeys(Object paramConnectionEntity, TrainingHomeWorkTypeEntity paramTrainingHomeWorkTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingHomeWorkTypeEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Sort AS Sort");
                strBuilder.Append(" from RH_TrainingHomeWorkType");
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
        /// <returns type="TrainingHomeWorkTypeEntity"></returns>
        private TrainingHomeWorkTypeEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingHomeWorkTypeMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}