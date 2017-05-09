using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingType ( RH_TrainingType ) Dao类
    ///</summary>
    public class TrainingTypeDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingType : RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingType");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingTypeEntity.ID);

                ///Name : nvarchar(50) Name
                if (paramTrainingTypeEntity.Name != null && "".Equals(paramTrainingTypeEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramTrainingTypeEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///Code : nvarchar(50) Code
                if (paramTrainingTypeEntity.Code != null && "".Equals(paramTrainingTypeEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramTrainingTypeEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramTrainingTypeEntity.Sort);

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
        /// RH_TrainingType : RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingType");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingTypeEntity.ID);

                ///Name : nvarchar(50) Name
                if (paramTrainingTypeEntity.Name != null && "".Equals(paramTrainingTypeEntity.Name.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", paramTrainingTypeEntity.Name);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }

                ///Code : nvarchar(50) Code
                if (paramTrainingTypeEntity.Code != null && "".Equals(paramTrainingTypeEntity.Code.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", paramTrainingTypeEntity.Code);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Code", DBNull.Value);
                }

                ///Sort : int Sort
                m_sqlCmd.Parameters.AddWithValue("@Sort",paramTrainingTypeEntity.Sort);

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
        /// RH_TrainingType : RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingType");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingTypeEntity.ID);

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
        /// RH_TrainingType : RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="TrainingTypeEntity"></returns>
        public TrainingTypeEntity SelectByPK(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingTypeEntity trainingTypeEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Sort AS Sort");
                strBuilder.Append(" from RH_TrainingType");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingTypeEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingTypeEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingTypeEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingType : RH_TrainingType
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingTypeEntity" type="TrainingTypeEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingTypeByForeignKeys(Object paramConnectionEntity, TrainingTypeEntity paramTrainingTypeEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingTypeEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   Name AS Name,");
                strBuilder.Append("   Code AS Code,");
                strBuilder.Append("   Sort AS Sort");
                strBuilder.Append(" from RH_TrainingType");
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
        /// <returns type="TrainingTypeEntity"></returns>
        private TrainingTypeEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingTypeMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}