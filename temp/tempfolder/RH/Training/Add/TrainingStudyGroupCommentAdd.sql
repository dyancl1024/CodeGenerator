/*
  RH_TrainingStudyGroupComment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyGroupComment_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyGroupComment_Add
(
   IN i_StudyGroupID int,
   IN i_CommentTitile nvarchar(50),
   IN i_Comment nvarchar(Max),
   IN i_IPAdress varchar(50),
   IN i_ParentID int,
   IN i_IsExpert int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingStudyGroupComment
  (
      StudyGroupID,
      CommentTitile,
      Comment,
      IPAdress,
      ParentID,
      IsExpert,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_StudyGroupID,  --  int (StudyGroupID)
      i_CommentTitile,  --  nvarchar(50) (CommentTitile)
      i_Comment,  --  nvarchar(Max) (评论内容)
      i_IPAdress,  --  varchar(50) (IP地址)
      i_ParentID,  --  int (评论的父级ID)
      i_IsExpert,  --  int (1.专家2.非专家)
      i_CreateBy,  --  int (评论人)
      i_CreateTime  --  datetime (评论时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
