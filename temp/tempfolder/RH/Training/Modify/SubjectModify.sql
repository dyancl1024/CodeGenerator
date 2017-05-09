/*
  RH_Subject - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Subject_Modify;
CREATE  PROCEDURE sp_SJ_RH_Subject_Modify
(
   IN i_ID int,
   IN i_SubjectName nvarchar(50),
   IN i_SubCode varchar(50),
   IN i_SubjectSort nvarchar(50),
   OUT o_Result int
)
BEGIN

  UPDATE RH_Subject
  SET
      SubjectName = i_SubjectName,
      SubCode = i_SubCode,
      SubjectSort = i_SubjectSort
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
