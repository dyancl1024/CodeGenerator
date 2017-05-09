using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) Dao类
    ///</summary>
    public class TrainingBriefingDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingBriefing : RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingBriefing");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    ObjectID,");
                strBuilder.Append("    MType,");
                strBuilder.Append("    Periods,");
                strBuilder.Append("    Title,");
                strBuilder.Append("    BContnet,");
                strBuilder.Append("    ClickNum,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime,");
                strBuilder.Append("    StaticUrl");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @ObjectID,");
                strBuilder.Append("    @MType,");
                strBuilder.Append("    @Periods,");
                strBuilder.Append("    @Title,");
                strBuilder.Append("    @BContnet,");
                strBuilder.Append("    @ClickNum,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
                strBuilder.Append("    @UpdateBy,");
                strBuilder.Append("    @UpdateTime,");
                strBuilder.Append("    @StaticUrl");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingBriefingEntity.ID);

                ///项目id : int ObjectID
                m_sqlCmd.Parameters.AddWithValue("@ObjectID",paramTrainingBriefingEntity.ObjectID);

                ///1.项目 2.班级 : int MType
                m_sqlCmd.Parameters.AddWithValue("@MType",paramTrainingBriefingEntity.MType);

                ///期数 录入 : nvarchar(50) Periods
                if (paramTrainingBriefingEntity.Periods != null && "".Equals(paramTrainingBriefingEntity.Periods.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Periods", paramTrainingBriefingEntity.Periods);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Periods", DBNull.Value);
                }

                ///标题 : nvarchar(200) Title
                if (paramTrainingBriefingEntity.Title != null && "".Equals(paramTrainingBriefingEntity.Title.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Title", paramTrainingBriefingEntity.Title);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Title", DBNull.Value);
                }

                ///内容 : nvarchar(Max) BContnet
                if (paramTrainingBriefingEntity.BContnet != null && "".Equals(paramTrainingBriefingEntity.BContnet.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@BContnet", paramTrainingBriefingEntity.BContnet);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@BContnet", DBNull.Value);
                }

                ///ClickNum : int ClickNum
                m_sqlCmd.Parameters.AddWithValue("@ClickNum",paramTrainingBriefingEntity.ClickNum);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingBriefingEntity.CreateBy);

                ///发布时间 : datetime CreateTime
                if (paramTrainingBriefingEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingBriefingEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingBriefingEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingBriefingEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingBriefingEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingBriefingEntity.StaticUrl != null && "".Equals(paramTrainingBriefingEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingBriefingEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
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
        /// RH_TrainingBriefing : RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingBriefing");
                strBuilder.Append("  set ");
                strBuilder.Append("    ObjectID=@ObjectID,");
                strBuilder.Append("    MType=@MType,");
                strBuilder.Append("    Periods=@Periods,");
                strBuilder.Append("    Title=@Title,");
                strBuilder.Append("    BContnet=@BContnet,");
                strBuilder.Append("    ClickNum=@ClickNum,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
                strBuilder.Append("    UpdateBy=@UpdateBy,");
                strBuilder.Append("    UpdateTime=@UpdateTime,");
                strBuilder.Append("    StaticUrl=@StaticUrl");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingBriefingEntity.ID);

                ///项目id : int ObjectID
                m_sqlCmd.Parameters.AddWithValue("@ObjectID",paramTrainingBriefingEntity.ObjectID);

                ///1.项目 2.班级 : int MType
                m_sqlCmd.Parameters.AddWithValue("@MType",paramTrainingBriefingEntity.MType);

                ///期数 录入 : nvarchar(50) Periods
                if (paramTrainingBriefingEntity.Periods != null && "".Equals(paramTrainingBriefingEntity.Periods.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Periods", paramTrainingBriefingEntity.Periods);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Periods", DBNull.Value);
                }

                ///标题 : nvarchar(200) Title
                if (paramTrainingBriefingEntity.Title != null && "".Equals(paramTrainingBriefingEntity.Title.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@Title", paramTrainingBriefingEntity.Title);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@Title", DBNull.Value);
                }

                ///内容 : nvarchar(Max) BContnet
                if (paramTrainingBriefingEntity.BContnet != null && "".Equals(paramTrainingBriefingEntity.BContnet.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@BContnet", paramTrainingBriefingEntity.BContnet);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@BContnet", DBNull.Value);
                }

                ///ClickNum : int ClickNum
                m_sqlCmd.Parameters.AddWithValue("@ClickNum",paramTrainingBriefingEntity.ClickNum);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingBriefingEntity.CreateBy);

                ///发布时间 : datetime CreateTime
                if (paramTrainingBriefingEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingBriefingEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingBriefingEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingBriefingEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingBriefingEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingBriefingEntity.StaticUrl != null && "".Equals(paramTrainingBriefingEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingBriefingEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
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
        /// RH_TrainingBriefing : RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingBriefing");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingBriefingEntity.ID);

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
        /// RH_TrainingBriefing : RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="TrainingBriefingEntity"></returns>
        public TrainingBriefingEntity SelectByPK(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingBriefingEntity trainingBriefingEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ObjectID AS ObjectID,");
                strBuilder.Append("   MType AS MType,");
                strBuilder.Append("   Periods AS Periods,");
                strBuilder.Append("   Title AS Title,");
                strBuilder.Append("   BContnet AS BContnet,");
                strBuilder.Append("   ClickNum AS ClickNum,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime,");
                strBuilder.Append("   StaticUrl AS StaticUrl");
                strBuilder.Append(" from RH_TrainingBriefing");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingBriefingEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingBriefingEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingBriefingEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingBriefing : RH_TrainingBriefing
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingBriefingEntity" type="TrainingBriefingEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingBriefingByForeignKeys(Object paramConnectionEntity, TrainingBriefingEntity paramTrainingBriefingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingBriefingEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ObjectID AS ObjectID,");
                strBuilder.Append("   MType AS MType,");
                strBuilder.Append("   Periods AS Periods,");
                strBuilder.Append("   Title AS Title,");
                strBuilder.Append("   BContnet AS BContnet,");
                strBuilder.Append("   ClickNum AS ClickNum,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime,");
                strBuilder.Append("   StaticUrl AS StaticUrl");
                strBuilder.Append(" from RH_TrainingBriefing");
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
        /// <returns type="TrainingBriefingEntity"></returns>
        private TrainingBriefingEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingBriefingMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}