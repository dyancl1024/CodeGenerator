/*
  RH_School - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_School_Add;
CREATE  PROCEDURE sp_SJ_RH_School_Add
(
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

  INSERT INTO RH_School
  (
      DistrictID,
      SchoolName,
      Status,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_DistrictID,  --  int (DistrictID)
      i_SchoolName,  --  nvarchar(50) (SchoolName)
      i_Status,  --  int (Status)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime,  --  datetime (CreateTime)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
