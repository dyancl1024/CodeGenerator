/*
  RH_CoursePreSetList - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CoursePreSetList_Add;
CREATE  PROCEDURE sp_SJ_RH_CoursePreSetList_Add
(
   IN i_PreSetID int,
   IN i_CourseID int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CoursePreSetList
  (
      PreSetID,
      CourseID
  )
  VALUES
  (
      i_PreSetID,  --  int (PreSetID)
      i_CourseID  --  int (CourseID)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
