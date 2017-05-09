/*
  RH_TrainingBriefingComment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingBriefingComment_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingBriefingComment_Add
(
   IN i_TBID int,
   IN i_Comment nvarchar(Max),
   IN i_IPAdress varchar(50),
   IN i_ParentID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingBriefingComment
  (
      TBID,
      Comment,
      IPAdress,
      ParentID,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_TBID,  --  int (项目简报ID 对应RH_TrainingBriefing)
      i_Comment,  --  nvarchar(Max) (评论内容)
      i_IPAdress,  --  varchar(50) (IP地址)
      i_ParentID,  --  int (评论的父级ID)
      i_CreateBy,  --  int (评论人)
      i_CreateTime  --  datetime (评论时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
