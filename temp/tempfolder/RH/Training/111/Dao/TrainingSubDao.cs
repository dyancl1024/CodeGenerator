using System;
using System.Text;
using System.Data.SqlClient;
using RH.Training.Entity;
using RH.Training.MapUtil;

namespace RH.Training.Dao
{
    ///<summary>
    ///RH_TrainingSub ( RH_TrainingSub ) Dao类
    ///</summary>
    public class TrainingSubDao
    {

        /// <summary>
        /// 添加
        /// RH_TrainingSub : RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void Insert(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  insert into RH_TrainingSub");
                strBuilder.Append("  (");
                strBuilder.Append("    ID,");
                strBuilder.Append("    TID,");
                strBuilder.Append("    TName,");
                strBuilder.Append("    TrainingNum,");
                strBuilder.Append("    TrainingLevelCode,");
                strBuilder.Append("    TrainingTypeCode,");
                strBuilder.Append("    TMethod,");
                strBuilder.Append("    IsGP,");
                strBuilder.Append("    OrgCode,");
                strBuilder.Append("    TrainingDateB,");
                strBuilder.Append("    TrainingDateE,");
                strBuilder.Append("    SignupRule,");
                strBuilder.Append("    ClassRule,");
                strBuilder.Append("    IsStage,");
                strBuilder.Append("    TrainingUrl,");
                strBuilder.Append("    TrainingHeadImg,");
                strBuilder.Append("    StaticUrl,");
                strBuilder.Append("    Status,");
                strBuilder.Append("    AskTel,");
                strBuilder.Append("    IsShowQQ,");
                strBuilder.Append("    TestMethod,");
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
                strBuilder.Append("    @TID,");
                strBuilder.Append("    @TName,");
                strBuilder.Append("    @TrainingNum,");
                strBuilder.Append("    @TrainingLevelCode,");
                strBuilder.Append("    @TrainingTypeCode,");
                strBuilder.Append("    @TMethod,");
                strBuilder.Append("    @IsGP,");
                strBuilder.Append("    @OrgCode,");
                strBuilder.Append("    @TrainingDateB,");
                strBuilder.Append("    @TrainingDateE,");
                strBuilder.Append("    @SignupRule,");
                strBuilder.Append("    @ClassRule,");
                strBuilder.Append("    @IsStage,");
                strBuilder.Append("    @TrainingUrl,");
                strBuilder.Append("    @TrainingHeadImg,");
                strBuilder.Append("    @StaticUrl,");
                strBuilder.Append("    @Status,");
                strBuilder.Append("    @AskTel,");
                strBuilder.Append("    @IsShowQQ,");
                strBuilder.Append("    @TestMethod,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingSubEntity.ID);

                ///主项目ID : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingSubEntity.TID);

                ///项目名称 : nvarchar(200) TName
                if (paramTrainingSubEntity.TName != null && "".Equals(paramTrainingSubEntity.TName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TName", paramTrainingSubEntity.TName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TName", DBNull.Value);
                }

                ///项目名称 : int TrainingNum
                m_sqlCmd.Parameters.AddWithValue("@TrainingNum",paramTrainingSubEntity.TrainingNum);

                ///承担机构id 对应表FJ_TrainingOrg的ID : varchar(50) TrainingLevelCode
                if (paramTrainingSubEntity.TrainingLevelCode != null && "".Equals(paramTrainingSubEntity.TrainingLevelCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", paramTrainingSubEntity.TrainingLevelCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", DBNull.Value);
                }

                ///TrainingTypeCode : varchar(50) TrainingTypeCode
                if (paramTrainingSubEntity.TrainingTypeCode != null && "".Equals(paramTrainingSubEntity.TrainingTypeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", paramTrainingSubEntity.TrainingTypeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", DBNull.Value);
                }

                ///研修方式：1.网络培训 2.现场培训 3.能力提升 : int TMethod
                m_sqlCmd.Parameters.AddWithValue("@TMethod",paramTrainingSubEntity.TMethod);

                ///是否国培 1 是 2 否 : int IsGP
                m_sqlCmd.Parameters.AddWithValue("@IsGP",paramTrainingSubEntity.IsGP);

                ///OrgCode : varchar(50) OrgCode
                if (paramTrainingSubEntity.OrgCode != null && "".Equals(paramTrainingSubEntity.OrgCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@OrgCode", paramTrainingSubEntity.OrgCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@OrgCode", DBNull.Value);
                }

                ///时间安排起 : datetime TrainingDateB
                if (paramTrainingSubEntity.TrainingDateB > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", paramTrainingSubEntity.TrainingDateB);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", DBNull.Value);
                }

                ///时间安排止 : datetime TrainingDateE
                if (paramTrainingSubEntity.TrainingDateE > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", paramTrainingSubEntity.TrainingDateE);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", DBNull.Value);
                }

                ///报名规则：1.导入报名 2.自主报名 : int SignupRule
                m_sqlCmd.Parameters.AddWithValue("@SignupRule",paramTrainingSubEntity.SignupRule);

                ///分班规则：1.规则分班 2.人工分班 : nchar(10) ClassRule
                if (paramTrainingSubEntity.ClassRule != null && "".Equals(paramTrainingSubEntity.ClassRule.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ClassRule", paramTrainingSubEntity.ClassRule);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ClassRule", DBNull.Value);
                }

                ///是否阶段项目 1 是 2 否 : int IsStage
                m_sqlCmd.Parameters.AddWithValue("@IsStage",paramTrainingSubEntity.IsStage);

                ///TrainingUrl : varchar(200) TrainingUrl
                if (paramTrainingSubEntity.TrainingUrl != null && "".Equals(paramTrainingSubEntity.TrainingUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingUrl", paramTrainingSubEntity.TrainingUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingUrl", DBNull.Value);
                }

                ///TrainingHeadImg : varchar(200) TrainingHeadImg
                if (paramTrainingSubEntity.TrainingHeadImg != null && "".Equals(paramTrainingSubEntity.TrainingHeadImg.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingHeadImg", paramTrainingSubEntity.TrainingHeadImg);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingHeadImg", DBNull.Value);
                }

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingSubEntity.StaticUrl != null && "".Equals(paramTrainingSubEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingSubEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingSubEntity.Status);

                ///咨询电话 : varchar(50) AskTel
                if (paramTrainingSubEntity.AskTel != null && "".Equals(paramTrainingSubEntity.AskTel.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AskTel", paramTrainingSubEntity.AskTel);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AskTel", DBNull.Value);
                }

                ///是否显示在线客服 1 是 2 否 : int IsShowQQ
                m_sqlCmd.Parameters.AddWithValue("@IsShowQQ",paramTrainingSubEntity.IsShowQQ);

                ///测评工具 1内部 2外部 : int TestMethod
                m_sqlCmd.Parameters.AddWithValue("@TestMethod",paramTrainingSubEntity.TestMethod);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingSubEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingSubEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingSubEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingSubEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingSubEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingSubEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                ///发布人 : int Publisher
                m_sqlCmd.Parameters.AddWithValue("@Publisher",paramTrainingSubEntity.Publisher);

                ///发布时间 : datetime PublishDate
                if (paramTrainingSubEntity.PublishDate > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@PublishDate", paramTrainingSubEntity.PublishDate);
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
        /// RH_TrainingSub : RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void Update(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append("  update RH_TrainingSub");
                strBuilder.Append("  set ");
                strBuilder.Append("    TID=@TID,");
                strBuilder.Append("    TName=@TName,");
                strBuilder.Append("    TrainingNum=@TrainingNum,");
                strBuilder.Append("    TrainingLevelCode=@TrainingLevelCode,");
                strBuilder.Append("    TrainingTypeCode=@TrainingTypeCode,");
                strBuilder.Append("    TMethod=@TMethod,");
                strBuilder.Append("    IsGP=@IsGP,");
                strBuilder.Append("    OrgCode=@OrgCode,");
                strBuilder.Append("    TrainingDateB=@TrainingDateB,");
                strBuilder.Append("    TrainingDateE=@TrainingDateE,");
                strBuilder.Append("    SignupRule=@SignupRule,");
                strBuilder.Append("    ClassRule=@ClassRule,");
                strBuilder.Append("    IsStage=@IsStage,");
                strBuilder.Append("    TrainingUrl=@TrainingUrl,");
                strBuilder.Append("    TrainingHeadImg=@TrainingHeadImg,");
                strBuilder.Append("    StaticUrl=@StaticUrl,");
                strBuilder.Append("    Status=@Status,");
                strBuilder.Append("    AskTel=@AskTel,");
                strBuilder.Append("    IsShowQQ=@IsShowQQ,");
                strBuilder.Append("    TestMethod=@TestMethod,");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingSubEntity.ID);

                ///主项目ID : int TID
                m_sqlCmd.Parameters.AddWithValue("@TID",paramTrainingSubEntity.TID);

                ///项目名称 : nvarchar(200) TName
                if (paramTrainingSubEntity.TName != null && "".Equals(paramTrainingSubEntity.TName.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TName", paramTrainingSubEntity.TName);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TName", DBNull.Value);
                }

                ///项目名称 : int TrainingNum
                m_sqlCmd.Parameters.AddWithValue("@TrainingNum",paramTrainingSubEntity.TrainingNum);

                ///承担机构id 对应表FJ_TrainingOrg的ID : varchar(50) TrainingLevelCode
                if (paramTrainingSubEntity.TrainingLevelCode != null && "".Equals(paramTrainingSubEntity.TrainingLevelCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", paramTrainingSubEntity.TrainingLevelCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingLevelCode", DBNull.Value);
                }

                ///TrainingTypeCode : varchar(50) TrainingTypeCode
                if (paramTrainingSubEntity.TrainingTypeCode != null && "".Equals(paramTrainingSubEntity.TrainingTypeCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", paramTrainingSubEntity.TrainingTypeCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingTypeCode", DBNull.Value);
                }

                ///研修方式：1.网络培训 2.现场培训 3.能力提升 : int TMethod
                m_sqlCmd.Parameters.AddWithValue("@TMethod",paramTrainingSubEntity.TMethod);

                ///是否国培 1 是 2 否 : int IsGP
                m_sqlCmd.Parameters.AddWithValue("@IsGP",paramTrainingSubEntity.IsGP);

                ///OrgCode : varchar(50) OrgCode
                if (paramTrainingSubEntity.OrgCode != null && "".Equals(paramTrainingSubEntity.OrgCode.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@OrgCode", paramTrainingSubEntity.OrgCode);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@OrgCode", DBNull.Value);
                }

                ///时间安排起 : datetime TrainingDateB
                if (paramTrainingSubEntity.TrainingDateB > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", paramTrainingSubEntity.TrainingDateB);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateB", DBNull.Value);
                }

                ///时间安排止 : datetime TrainingDateE
                if (paramTrainingSubEntity.TrainingDateE > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", paramTrainingSubEntity.TrainingDateE);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingDateE", DBNull.Value);
                }

                ///报名规则：1.导入报名 2.自主报名 : int SignupRule
                m_sqlCmd.Parameters.AddWithValue("@SignupRule",paramTrainingSubEntity.SignupRule);

                ///分班规则：1.规则分班 2.人工分班 : nchar(10) ClassRule
                if (paramTrainingSubEntity.ClassRule != null && "".Equals(paramTrainingSubEntity.ClassRule.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@ClassRule", paramTrainingSubEntity.ClassRule);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@ClassRule", DBNull.Value);
                }

                ///是否阶段项目 1 是 2 否 : int IsStage
                m_sqlCmd.Parameters.AddWithValue("@IsStage",paramTrainingSubEntity.IsStage);

                ///TrainingUrl : varchar(200) TrainingUrl
                if (paramTrainingSubEntity.TrainingUrl != null && "".Equals(paramTrainingSubEntity.TrainingUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingUrl", paramTrainingSubEntity.TrainingUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingUrl", DBNull.Value);
                }

                ///TrainingHeadImg : varchar(200) TrainingHeadImg
                if (paramTrainingSubEntity.TrainingHeadImg != null && "".Equals(paramTrainingSubEntity.TrainingHeadImg.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingHeadImg", paramTrainingSubEntity.TrainingHeadImg);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@TrainingHeadImg", DBNull.Value);
                }

                ///StaticUrl : nvarchar(200) StaticUrl
                if (paramTrainingSubEntity.StaticUrl != null && "".Equals(paramTrainingSubEntity.StaticUrl.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", paramTrainingSubEntity.StaticUrl);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@StaticUrl", DBNull.Value);
                }

                ///1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除 : int Status
                m_sqlCmd.Parameters.AddWithValue("@Status",paramTrainingSubEntity.Status);

                ///咨询电话 : varchar(50) AskTel
                if (paramTrainingSubEntity.AskTel != null && "".Equals(paramTrainingSubEntity.AskTel.Trim()))
                {
                    m_sqlCmd.Parameters.AddWithValue("@AskTel", paramTrainingSubEntity.AskTel);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@AskTel", DBNull.Value);
                }

                ///是否显示在线客服 1 是 2 否 : int IsShowQQ
                m_sqlCmd.Parameters.AddWithValue("@IsShowQQ",paramTrainingSubEntity.IsShowQQ);

                ///测评工具 1内部 2外部 : int TestMethod
                m_sqlCmd.Parameters.AddWithValue("@TestMethod",paramTrainingSubEntity.TestMethod);

                ///创建人 : int CreateBy
                m_sqlCmd.Parameters.AddWithValue("@CreateBy",paramTrainingSubEntity.CreateBy);

                ///创建时间 : datetime CreateTime
                if (paramTrainingSubEntity.CreateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", paramTrainingSubEntity.CreateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@CreateTime", DBNull.Value);
                }

                ///更新人 : int UpdateBy
                m_sqlCmd.Parameters.AddWithValue("@UpdateBy",paramTrainingSubEntity.UpdateBy);

                ///更新时间 : datetime UpdateTime
                if (paramTrainingSubEntity.UpdateTime > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", paramTrainingSubEntity.UpdateTime);
                }
                else
                {
                    m_sqlCmd.Parameters.AddWithValue("@UpdateTime", DBNull.Value);
                }

                ///发布人 : int Publisher
                m_sqlCmd.Parameters.AddWithValue("@Publisher",paramTrainingSubEntity.Publisher);

                ///发布时间 : datetime PublishDate
                if (paramTrainingSubEntity.PublishDate > DateTime.MinValue)
                {
                    m_sqlCmd.Parameters.AddWithValue("@PublishDate", paramTrainingSubEntity.PublishDate);
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
        /// RH_TrainingSub : RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="void"></returns>
        public void Delete(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" delete from RH_TrainingSub");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingSubEntity.ID);

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
        /// RH_TrainingSub : RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="TrainingSubEntity"></returns>
        public TrainingSubEntity SelectByPK(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            TrainingSubEntity trainingSubEntity = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   TName AS TName,");
                strBuilder.Append("   TrainingNum AS TrainingNum,");
                strBuilder.Append("   TrainingLevelCode AS TrainingLevelCode,");
                strBuilder.Append("   TrainingTypeCode AS TrainingTypeCode,");
                strBuilder.Append("   TMethod AS TMethod,");
                strBuilder.Append("   IsGP AS IsGP,");
                strBuilder.Append("   OrgCode AS OrgCode,");
                strBuilder.Append("   TrainingDateB AS TrainingDateB,");
                strBuilder.Append("   TrainingDateE AS TrainingDateE,");
                strBuilder.Append("   SignupRule AS SignupRule,");
                strBuilder.Append("   ClassRule AS ClassRule,");
                strBuilder.Append("   IsStage AS IsStage,");
                strBuilder.Append("   TrainingUrl AS TrainingUrl,");
                strBuilder.Append("   TrainingHeadImg AS TrainingHeadImg,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   AskTel AS AskTel,");
                strBuilder.Append("   IsShowQQ AS IsShowQQ,");
                strBuilder.Append("   TestMethod AS TestMethod,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime,");
                strBuilder.Append("   Publisher AS Publisher,");
                strBuilder.Append("   PublishDate AS PublishDate");
                strBuilder.Append(" from RH_TrainingSub");
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
                m_sqlCmd.Parameters.AddWithValue("@ID",paramTrainingSubEntity.ID);

                //执行数据库操作
                SqlDataAdapter dat=new SqlDataAdapter(m_sqlCmd);
                dat.Fill(objDataTable);

                if (objDataTable != null &&  objDataTable.Rows.Count > 0)
                {
                    System.Data.DataRow[] dataRows=objDataTable.Select();
                    if (dataRows != null)
                    {
                        trainingSubEntity = ParseDataRowToEntity(dataRows[0]);
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

            return trainingSubEntity;
        }

        /// <summary>
        /// 根据外键查找
        /// RH_TrainingSub : RH_TrainingSub
        /// </summary>
        /// <param name="paramConnectionEntity" type="Object"></param>
        /// <param name="paramTrainingSubEntity" type="TrainingSubEntity"></param>
        /// <returns type="DataTable"></returns>
        public DataTable SelectAllTrainingSubByForeignKeys(Object paramConnectionEntity, TrainingSubEntity paramTrainingSubEntity)
        {
            SqlCommand m_sqlCmd = null;
            StringBuilder strBuilder = new StringBuilder("");
            //SQL变量
            String strSQL = null;

            DataTable objDataTable = new DataTable();

            DataTable trainingSubEntityList = null;

            try
            {
                //以下生成SQL语句
                strBuilder.Append(" select ");
                strBuilder.Append("   ID AS ID,");
                strBuilder.Append("   TID AS TID,");
                strBuilder.Append("   TName AS TName,");
                strBuilder.Append("   TrainingNum AS TrainingNum,");
                strBuilder.Append("   TrainingLevelCode AS TrainingLevelCode,");
                strBuilder.Append("   TrainingTypeCode AS TrainingTypeCode,");
                strBuilder.Append("   TMethod AS TMethod,");
                strBuilder.Append("   IsGP AS IsGP,");
                strBuilder.Append("   OrgCode AS OrgCode,");
                strBuilder.Append("   TrainingDateB AS TrainingDateB,");
                strBuilder.Append("   TrainingDateE AS TrainingDateE,");
                strBuilder.Append("   SignupRule AS SignupRule,");
                strBuilder.Append("   ClassRule AS ClassRule,");
                strBuilder.Append("   IsStage AS IsStage,");
                strBuilder.Append("   TrainingUrl AS TrainingUrl,");
                strBuilder.Append("   TrainingHeadImg AS TrainingHeadImg,");
                strBuilder.Append("   StaticUrl AS StaticUrl,");
                strBuilder.Append("   Status AS Status,");
                strBuilder.Append("   AskTel AS AskTel,");
                strBuilder.Append("   IsShowQQ AS IsShowQQ,");
                strBuilder.Append("   TestMethod AS TestMethod,");
                strBuilder.Append("   CreateBy AS CreateBy,");
                strBuilder.Append("   CreateTime AS CreateTime,");
                strBuilder.Append("   UpdateBy AS UpdateBy,");
                strBuilder.Append("   UpdateTime AS UpdateTime,");
                strBuilder.Append("   Publisher AS Publisher,");
                strBuilder.Append("   PublishDate AS PublishDate");
                strBuilder.Append(" from RH_TrainingSub");
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
        /// <returns type="TrainingSubEntity"></returns>
        private TrainingSubEntity ParseDataRowToEntity(DataRow dataRow)
        {
            return TrainingSubMapUtil.ParseDataRowToEntity(dataRow);
        }
    }
}