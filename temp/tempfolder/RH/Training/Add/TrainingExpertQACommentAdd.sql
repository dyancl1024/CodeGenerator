/*
  RH_TrainingExpertQAComment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExpertQAComment_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingExpertQAComment_Add
(
   IN i_QAID int,
   IN i_Comment nvarchar(Max),
   IN i_IPAdress varchar(50),
   IN i_ParentID int,
   IN i_IsExpert int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingExpertQAComment
  (
      QAID,
      Comment,
      IPAdress,
      ParentID,
      IsExpert,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_QAID,  --  int (QAID)
      i_Comment,  --  nvarchar(Max) (Comment)
      i_IPAdress,  --  varchar(50) (IPAdress)
      i_ParentID,  --  int (ParentID)
      i_IsExpert,  --  int (是否专家回答 1.是 2.否)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
