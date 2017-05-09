using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_Training ( RH_Training ) Dao类
    ///</summary>
    public class TrainingDao
    {

        /// <summary>
        /// 添加
        /// RH_Training : RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_Training");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    DesignID,");
                strBuilder.Append("    TName,");
                strBuilder.Append("    TrainingPhase,");
                strBuilder.Append("    TrainingNum,");
                strBuilder.Append("    TrainingLevelCode,");
                strBuilder.Append("    TrainingTypeCode,");
                strBuilder.Append("    ProvinceID,");
                strBuilder.Append("    CityID,");
                strBuilder.Append("    DistrictID,");
                strBuilder.Append("    TrainingDateB,");
                strBuilder.Append("    TrainingDateE,");
                strBuilder.Append("    IsStage,");
                strBuilder.Append("    TrainingUrl,");
                strBuilder.Append("    TrainingCode,");
                strBuilder.Append("    TrainingHeadImg,");
                strBuilder.Append("    StaticUrl,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    CreateBy,");
                strBuilder.Append("    CreateTime,");
                strBuilder.Append("    UpdateBy,");
                strBuilder.Append("    UpdateTime,");
                strBuilder.Append("    Publisher,");
                strBuilder.Append("    PublishDate");
                strBuilder.Append("  )");
                strBuilder.Append("     values ");
                strBuilder.Append("  (");
                strBuilder.Append("    @ID,");
                strBuilder.Append("    @DesignID,");
                strBuilder.Append("    @TName,");
                strBuilder.Append("    @TrainingPhase,");
                strBuilder.Append("    @TrainingNum,");
                strBuilder.Append("    @TrainingLevelCode,");
                strBuilder.Append("    @TrainingTypeCode,");
                strBuilder.Append("    @ProvinceID,");
                strBuilder.Append("    @CityID,");
                strBuilder.Append("    @DistrictID,");
                strBuilder.Append("    @TrainingDateB,");
                strBuilder.Append("    @TrainingDateE,");
                strBuilder.Append("    @IsStage,");
                strBuilder.Append("    @TrainingUrl,");
                strBuilder.Append("    @TrainingCode,");
                strBuilder.Append("    @TrainingHeadImg,");
                strBuilder.Append("    @StaticUrl,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @CreateBy,");
                strBuilder.Append("    @CreateTime,");
                strBuilder.Append("    @UpdateBy,");
                strBuilder.Append("    @UpdateTime,");
                strBuilder.Append("    @Publisher,");
                strBuilder.Append("    @PublishDate");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingEntity.ID);

                ///社区id : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramTrainingEntity.DesignID);

                ///项目名称 : nvarchar(200) TName
                if (paramTrainingEntity.TName != null && "".Equals(paramTrainingEntity.TName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TName", paramTrainingEntity.TName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TName", DBNull.Value);
                }

                ///学时 : int TrainingPhase
                m_sqlCmd.Parameters.AddWithValue("@TrainingPhase",paramTrainingEntity.TrainingPhase);

                ///项目名称 : int TrainingNum
                m_sqlCmd.Parameters.AddWithValue("@TrainingNum",paramTrainingEntity.TrainingNum);

                ///承担机构id 对应表FJ_TrainingOrg的ID : varchar(50) TrainingLevelCode
                if (paramTrainingEntity.TrainingLevelCode != null && "".Equals(paramTrainingEntity.TrainingLevelCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", paramTrainingEntity.TrainingLevelCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", DBNull.Value);
                }

                ///TrainingTypeCode : varchar(50) TrainingTypeCode
                if (paramTrainingEntity.TrainingTypeCode != null && "".Equals(paramTrainingEntity.TrainingTypeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", paramTrainingEntity.TrainingTypeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramTrainingEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramTrainingEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramTrainingEntity.DistrictID);

                ///时间安排起 : datetime TrainingDateB
                if (paramTrainingEntity.TrainingDateB > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", paramTrainingEntity.TrainingDateB);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", DBNull.Value);
                }

                ///时间安排止 : datetime TrainingDateE
                if (paramTrainingEntity.TrainingDateE > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", paramTrainingEntity.TrainingDateE);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", DBNull.Value);
                }

                ///是否阶段项目 1 是 2 否 : int IsStage
                m_sqlCmd.Parameters.AddWithValue("@IsStage",paramTrainingEntity.IsStage);

                ///TrainingUrl : varchar(200) TrainingUrl
                if (paramTrainingEntity.TrainingUrl != null && "".Equals(paramTrainingEntity.TrainingUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingUrl", paramTrainingEntity.TrainingUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingUrl", DBNull.Value);
                }

                ///项目编码 : varchar(50) TrainingCode
                if (paramTrainingEntity.TrainingCode != null && "".Equals(paramTrainingEntity.TrainingCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingCode", paramTrainingEntity.TrainingCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingCode", DBNull.Value);
                }

                ///TrainingHeadImg : varchar(200) TrainingHeadImg
                if (paramTrainingEntity.TrainingHeadImg != null && "".Equals(paramTrainingEntity.TrainingHeadImg.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingHeadImg", paramTrainingEntity.TrainingHeadImg);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingHeadImg", DBNull.Value);
                }

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingEntity.StaticUrl != null && "".Equals(paramTrainingEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                ///发布人 : int Publisher
                m_sqlCmd.Parameters.AddWithValue("@Publisher",paramTrainingEntity.Publisher);

                ///发布时间 : datetime PublishDate
                if (paramTrainingEntity.PublishDate > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@PublishDate", paramTrainingEntity.PublishDate);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@PublishDate", DBNull.Value);
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
        /// RH_Training : RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_Training");
                strBuilder.Append("  set ");
                strBuilder.Append("    DesignID=@DesignID,");
                strBuilder.Append("    TName=@TName,");
                strBuilder.Append("    TrainingPhase=@TrainingPhase,");
                strBuilder.Append("    TrainingNum=@TrainingNum,");
                strBuilder.Append("    TrainingLevelCode=@TrainingLevelCode,");
                strBuilder.Append("    TrainingTypeCode=@TrainingTypeCode,");
                strBuilder.Append("    ProvinceID=@ProvinceID,");
                strBuilder.Append("    CityID=@CityID,");
                strBuilder.Append("    DistrictID=@DistrictID,");
                strBuilder.Append("    TrainingDateB=@TrainingDateB,");
                strBuilder.Append("    TrainingDateE=@TrainingDateE,");
                strBuilder.Append("    IsStage=@IsStage,");
                strBuilder.Append("    TrainingUrl=@TrainingUrl,");
                strBuilder.Append("    TrainingCode=@TrainingCode,");
                strBuilder.Append("    TrainingHeadImg=@TrainingHeadImg,");
                strBuilder.Append("    StaticUrl=@StaticUrl,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    CreateBy=@CreateBy,");
                strBuilder.Append("    CreateTime=@CreateTime,");
                strBuilder.Append("    UpdateBy=@UpdateBy,");
                strBuilder.Append("    UpdateTime=@UpdateTime,");
                strBuilder.Append("    Publisher=@Publisher,");
                strBuilder.Append("    PublishDate=@PublishDate");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingEntity.ID);

                ///社区id : int DesignID
                m_sqlCmd.Parameters.AddWithValue("@DesignID",paramTrainingEntity.DesignID);

                ///项目名称 : nvarchar(200) TName
                if (paramTrainingEntity.TName != null && "".Equals(paramTrainingEntity.TName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TName", paramTrainingEntity.TName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TName", DBNull.Value);
                }

                ///学时 : int TrainingPhase
                m_sqlCmd.Parameters.AddWithValue("@TrainingPhase",paramTrainingEntity.TrainingPhase);

                ///项目名称 : int TrainingNum
                m_sqlCmd.Parameters.AddWithValue("@TrainingNum",paramTrainingEntity.TrainingNum);

                ///承担机构id 对应表FJ_TrainingOrg的ID : varchar(50) TrainingLevelCode
                if (paramTrainingEntity.TrainingLevelCode != null && "".Equals(paramTrainingEntity.TrainingLevelCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", paramTrainingEntity.TrainingLevelCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", DBNull.Value);
                }

                ///TrainingTypeCode : varchar(50) TrainingTypeCode
                if (paramTrainingEntity.TrainingTypeCode != null && "".Equals(paramTrainingEntity.TrainingTypeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", paramTrainingEntity.TrainingTypeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", DBNull.Value);
                }

                ///ProvinceID : int ProvinceID
                m_sqlCmd.Parameters.AddWithValue("@ProvinceID",paramTrainingEntity.ProvinceID);

                ///CityID : int CityID
                m_sqlCmd.Parameters.AddWithValue("@CityID",paramTrainingEntity.CityID);

                ///DistrictID : int DistrictID
                m_sqlCmd.Parameters.AddWithValue("@DistrictID",paramTrainingEntity.DistrictID);

                ///时间安排起 : datetime TrainingDateB
                if (paramTrainingEntity.TrainingDateB > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", paramTrainingEntity.TrainingDateB);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", DBNull.Value);
                }

                ///时间安排止 : datetime TrainingDateE
                if (paramTrainingEntity.TrainingDateE > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", paramTrainingEntity.TrainingDateE);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", DBNull.Value);
                }

                ///是否阶段项目 1 是 2 否 : int IsStage
                m_sqlCmd.Parameters.AddWithValue("@IsStage",paramTrainingEntity.IsStage);

                ///TrainingUrl : varchar(200) TrainingUrl
                if (paramTrainingEntity.TrainingUrl != null && "".Equals(paramTrainingEntity.TrainingUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingUrl", paramTrainingEntity.TrainingUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingUrl", DBNull.Value);
                }

                ///项目编码 : varchar(50) TrainingCode
                if (paramTrainingEntity.TrainingCode != null && "".Equals(paramTrainingEntity.TrainingCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingCode", paramTrainingEntity.TrainingCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingCode", DBNull.Value);
                }

                ///TrainingHeadImg : varchar(200) TrainingHeadImg
                if (paramTrainingEntity.TrainingHeadImg != null && "".Equals(paramTrainingEntity.TrainingHeadImg.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingHeadImg", paramTrainingEntity.TrainingHeadImg);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingHeadImg", DBNull.Value);
                }

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingEntity.StaticUrl != null && "".Equals(paramTrainingEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingEntity.Status);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                ///发布人 : int Publisher
                m_sqlCmd.Parameters.AddWithValue("@Publisher",paramTrainingEntity.Publisher);

                ///发布时间 : datetime PublishDate
                if (paramTrainingEntity.PublishDate > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@PublishDate", paramTrainingEntity.PublishDate);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@PublishDate", DBNull.Value);
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
        /// RH_Training : RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_Training");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingEntity.ID);

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
        /// RH_Training : RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="TrainingEntity"></returns>
        public TrainingEntity SelectByPK(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingEntity trainingEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   TName AS TName,");
                strBuilder.Append("   TrainingPhase AS TrainingPhase,");
                strBuilder.Append("   TrainingNum AS TrainingNum,");
                strBuilder.Append("   TrainingLevelCode AS TrainingLevelCode,");
                strBuilder.Append("   TrainingTypeCode AS TrainingTypeCode,");
                strBuilder.Append("   ProvinceID AS ProvinceID,");
                strBuilder.Append("   CityID AS CityID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   TrainingDateB AS TrainingDateB,");
                strBuilder.Append("   TrainingDateE AS TrainingDateE,");
                strBuilder.Append("   IsStage AS IsStage,");
                strBuilder.Append("   TrainingUrl AS TrainingUrl,");
                strBuilder.Append("   TrainingCode AS TrainingCode,");
                strBuilder.Append("   TrainingHeadImg AS TrainingHeadImg,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime,");
                strBuilder.Append("   Publisher AS Publisher,");
                strBuilder.Append("   PublishDate AS PublishDate");
                strBuilder.Append(" from RH_Training");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_Training : RH_Training
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingEntity" type="TrainingEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingByForeignKeys(Object paramConnectionEntity, TrainingEntity paramTrainingEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   DesignID AS DesignID,");
                strBuilder.Append("   TName AS TName,");
                strBuilder.Append("   TrainingPhase AS TrainingPhase,");
                strBuilder.Append("   TrainingNum AS TrainingNum,");
                strBuilder.Append("   TrainingLevelCode AS TrainingLevelCode,");
                strBuilder.Append("   TrainingTypeCode AS TrainingTypeCode,");
                strBuilder.Append("   ProvinceID AS ProvinceID,");
                strBuilder.Append("   CityID AS CityID,");
                strBuilder.Append("   DistrictID AS DistrictID,");
                strBuilder.Append("   TrainingDateB AS TrainingDateB,");
                strBuilder.Append("   TrainingDateE AS TrainingDateE,");
                strBuilder.Append("   IsStage AS IsStage,");
                strBuilder.Append("   TrainingUrl AS TrainingUrl,");
                strBuilder.Append("   TrainingCode AS TrainingCode,");
                strBuilder.Append("   TrainingHeadImg AS TrainingHeadImg,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime,");
                strBuilder.Append("   Publisher AS Publisher,");
                strBuilder.Append("   PublishDate AS PublishDate");
                strBuilder.Append(" from RH_Training");
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
        /// <returns type="TrainingEntity"></returns>
        private TrainingEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}