/*
  RH_TrainingDynamic - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingDynamic_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingDynamic_Add
(
   IN i_ObjectID int,
   IN i_MType int,
   IN i_DyTitle nvarchar(100),
   IN i_DyType int,
   IN i_DyContent nvarchar(Max),
   IN i_DyLink nvarchar(200),
   IN i_DyPicUrl nvarchar(200),
   IN i_DState int,
   IN i_CilckNum int,
   IN i_StaticUrl nvarchar(200),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingDynamic
  (
      ObjectID,
      MType,
      DyTitle,
      DyType,
      DyContent,
      DyLink,
      DyPicUrl,
      DState,
      CilckNum,
      StaticUrl,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_ObjectID,  --  int (社区ID)
      i_MType,  --  int (类型：1.项目 2.班级)
      i_DyTitle,  --  nvarchar(100) (动态标题)
      i_DyType,  --  int (动态类型 1-文字 2-图片 3.链接类型 （无点击率）)
      i_DyContent,  --  nvarchar(Max) (内容)
      i_DyLink,  --  nvarchar(200) (当DyType为3链接时 存放link url)
      i_DyPicUrl,  --  nvarchar(200) (当DyType为2图片和图片广告4时 存放图片的 url)
      i_DState,  --  int (动态状态 1-正常 2-删除)
      i_CilckNum,  --  int (点击率)
      i_StaticUrl,  --  nvarchar(200) (StaticUrl)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
