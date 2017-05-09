/*
  RH_CoursePreSetList - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CoursePreSetList_Modify;
CREATE  PROCEDURE sp_SJ_RH_CoursePreSetList_Modify
(
   IN i_ID int,
   IN i_PreSetID int,
   IN i_CourseID int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_CoursePreSetList
  SET
      PreSetID = i_PreSetID,
      CourseID = i_CourseID
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
