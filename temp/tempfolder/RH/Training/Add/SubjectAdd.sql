/*
  RH_Subject - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Subject_Add;
CREATE  PROCEDURE sp_SJ_RH_Subject_Add
(
   IN i_SubjectName nvarchar(50),
   IN i_SubCode varchar(50),
   IN i_SubjectSort nvarchar(50),
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Subject
  (
      SubjectName,
      SubCode,
      SubjectSort
  )
  VALUES
  (
      i_SubjectName,  --  nvarchar(50) (SubjectName)
      i_SubCode,  --  varchar(50) (SubCode)
      i_SubjectSort  --  nvarchar(50) (SubjectSort)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
