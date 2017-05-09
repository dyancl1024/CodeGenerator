/*
  RH_School - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_School_Modify;
CREATE  PROCEDURE sp_SJ_RH_School_Modify
(
   IN i_ID int,
   IN i_DistrictID int,
   IN i_SchoolName nvarchar(50),
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_School
  SET
      DistrictID = i_DistrictID,
      SchoolName = i_SchoolName,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
