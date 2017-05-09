/*
  RH_UserSubjectRule - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_UserSubjectRule_Modify;
CREATE  PROCEDURE sp_SJ_RH_UserSubjectRule_Modify
(
   IN i_ID int,
   IN i_UserID int,
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   IN i_TID int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_UserSubjectRule
  SET
      UserID = i_UserID,
      GradeCode = i_GradeCode,
      SubjectCode = i_SubjectCode,
      TID = i_TID
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
