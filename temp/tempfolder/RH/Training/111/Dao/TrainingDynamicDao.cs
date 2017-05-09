using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingDynamic ( RH_TrainingDynamic ) Dao类
    ///</summary>
    public class TrainingDynamicDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingDynamic : RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingDynamic");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    ObjectID,");
                strBuilder.Append("    MType,");
                strBuilder.Append("    DyTitle,");
                strBuilder.Append("    DyType,");
                strBuilder.Append("    DyContent,");
                strBuilder.Append("    DyLink,");
                strBuilder.Append("    DyPicUrl,");
                strBuilder.Append("    DState,");
                strBuilder.Append("    CilckNum,");
                strBuilder.Append("    StaticUrl,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @ObjectID,");
                strBuilder.Append("    @MType,");
                strBuilder.Append("    @DyTitle,");
                strBuilder.Append("    @DyType,");
                strBuilder.Append("    @DyContent,");
                strBuilder.Append("    @DyLink,");
                strBuilder.Append("    @DyPicUrl,");
                strBuilder.Append("    @DState,");
                strBuilder.Append("    @CilckNum,");
                strBuilder.Append("    @StaticUrl,");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingDynamicEntity.ID);

                ///社区ID : int ObjectID
                m_sqlCmd.Parameters.AddWithValue("@ObjectID",paramTrainingDynamicEntity.ObjectID);

                ///类型：1.项目 2.班级 : int MType
                m_sqlCmd.Parameters.AddWithValue("@MType",paramTrainingDynamicEntity.MType);

                ///动态标题 : nvarchar(100) DyTitle
                if (paramTrainingDynamicEntity.DyTitle != null && "".Equals(paramTrainingDynamicEntity.DyTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyTitle", paramTrainingDynamicEntity.DyTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyTitle", DBNull.Value);
                }

                ///动态类型 1-文字 2-图片 3.链接类型 （无点击率） : int DyType
                m_sqlCmd.Parameters.AddWithValue("@DyType",paramTrainingDynamicEntity.DyType);

                ///内容 : nvarchar(Max) DyContent
                if (paramTrainingDynamicEntity.DyContent != null && "".Equals(paramTrainingDynamicEntity.DyContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyContent", paramTrainingDynamicEntity.DyContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyContent", DBNull.Value);
                }

                ///当DyType为3链接时 存放link url : nvarchar(200) DyLink
                if (paramTrainingDynamicEntity.DyLink != null && "".Equals(paramTrainingDynamicEntity.DyLink.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyLink", paramTrainingDynamicEntity.DyLink);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyLink", DBNull.Value);
                }

                ///当DyType为2图片和图片广告4时 存放图片的 url : nvarchar(200) DyPicUrl
                if (paramTrainingDynamicEntity.DyPicUrl != null && "".Equals(paramTrainingDynamicEntity.DyPicUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyPicUrl", paramTrainingDynamicEntity.DyPicUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyPicUrl", DBNull.Value);
                }

                ///动态状态 1-正常 2-删除 : int DState
                m_sqlCmd.Parameters.AddWithValue("@DState",paramTrainingDynamicEntity.DState);

                ///点击率 : int CilckNum
                m_sqlCmd.Parameters.AddWithValue("@CilckNum",paramTrainingDynamicEntity.CilckNum);

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingDynamicEntity.StaticUrl != null && "".Equals(paramTrainingDynamicEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingDynamicEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingDynamicEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingDynamicEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingDynamicEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingDynamicEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingDynamicEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingDynamicEntity.UpdateTime);
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
        /// RH_TrainingDynamic : RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingDynamic");
                strBuilder.Append("  set ");
                strBuilder.Append("    ObjectID=@ObjectID,");
                strBuilder.Append("    MType=@MType,");
                strBuilder.Append("    DyTitle=@DyTitle,");
                strBuilder.Append("    DyType=@DyType,");
                strBuilder.Append("    DyContent=@DyContent,");
                strBuilder.Append("    DyLink=@DyLink,");
                strBuilder.Append("    DyPicUrl=@DyPicUrl,");
                strBuilder.Append("    DState=@DState,");
                strBuilder.Append("    CilckNum=@CilckNum,");
                strBuilder.Append("    StaticUrl=@StaticUrl,");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingDynamicEntity.ID);

                ///社区ID : int ObjectID
                m_sqlCmd.Parameters.AddWithValue("@ObjectID",paramTrainingDynamicEntity.ObjectID);

                ///类型：1.项目 2.班级 : int MType
                m_sqlCmd.Parameters.AddWithValue("@MType",paramTrainingDynamicEntity.MType);

                ///动态标题 : nvarchar(100) DyTitle
                if (paramTrainingDynamicEntity.DyTitle != null && "".Equals(paramTrainingDynamicEntity.DyTitle.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyTitle", paramTrainingDynamicEntity.DyTitle);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyTitle", DBNull.Value);
                }

                ///动态类型 1-文字 2-图片 3.链接类型 （无点击率） : int DyType
                m_sqlCmd.Parameters.AddWithValue("@DyType",paramTrainingDynamicEntity.DyType);

                ///内容 : nvarchar(Max) DyContent
                if (paramTrainingDynamicEntity.DyContent != null && "".Equals(paramTrainingDynamicEntity.DyContent.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyContent", paramTrainingDynamicEntity.DyContent);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyContent", DBNull.Value);
                }

                ///当DyType为3链接时 存放link url : nvarchar(200) DyLink
                if (paramTrainingDynamicEntity.DyLink != null && "".Equals(paramTrainingDynamicEntity.DyLink.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyLink", paramTrainingDynamicEntity.DyLink);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyLink", DBNull.Value);
                }

                ///当DyType为2图片和图片广告4时 存放图片的 url : nvarchar(200) DyPicUrl
                if (paramTrainingDynamicEntity.DyPicUrl != null && "".Equals(paramTrainingDynamicEntity.DyPicUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyPicUrl", paramTrainingDynamicEntity.DyPicUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@DyPicUrl", DBNull.Value);
                }

                ///动态状态 1-正常 2-删除 : int DState
                m_sqlCmd.Parameters.AddWithValue("@DState",paramTrainingDynamicEntity.DState);

                ///点击率 : int CilckNum
                m_sqlCmd.Parameters.AddWithValue("@CilckNum",paramTrainingDynamicEntity.CilckNum);

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingDynamicEntity.StaticUrl != null && "".Equals(paramTrainingDynamicEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingDynamicEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingDynamicEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingDynamicEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingDynamicEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingDynamicEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingDynamicEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingDynamicEntity.UpdateTime);
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
        /// RH_TrainingDynamic : RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingDynamic");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingDynamicEntity.ID);

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
        /// RH_TrainingDynamic : RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="TrainingDynamicEntity"></returns>
        public TrainingDynamicEntity SelectByPK(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingDynamicEntity trainingDynamicEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ObjectID AS ObjectID,");
                strBuilder.Append("   MType AS MType,");
                strBuilder.Append("   DyTitle AS DyTitle,");
                strBuilder.Append("   DyType AS DyType,");
                strBuilder.Append("   DyContent AS DyContent,");
                strBuilder.Append("   DyLink AS DyLink,");
                strBuilder.Append("   DyPicUrl AS DyPicUrl,");
                strBuilder.Append("   DState AS DState,");
                strBuilder.Append("   CilckNum AS CilckNum,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingDynamic");
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

                ///主键 : int ID
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingDynamicEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingDynamicEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingDynamicEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingDynamic : RH_TrainingDynamic
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingDynamicEntity" type="TrainingDynamicEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingDynamicByForeignKeys(Object paramConnectionEntity, TrainingDynamicEntity paramTrainingDynamicEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingDynamicEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   ObjectID AS ObjectID,");
                strBuilder.Append("   MType AS MType,");
                strBuilder.Append("   DyTitle AS DyTitle,");
                strBuilder.Append("   DyType AS DyType,");
                strBuilder.Append("   DyContent AS DyContent,");
                strBuilder.Append("   DyLink AS DyLink,");
                strBuilder.Append("   DyPicUrl AS DyPicUrl,");
                strBuilder.Append("   DState AS DState,");
                strBuilder.Append("   CilckNum AS CilckNum,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime");
                strBuilder.Append(" from RH_TrainingDynamic");
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
        /// <returns type="TrainingDynamicEntity"></returns>
        private TrainingDynamicEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingDynamicMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}