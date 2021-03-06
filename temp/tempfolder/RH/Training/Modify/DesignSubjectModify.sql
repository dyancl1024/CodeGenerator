/*
  RH_DesignSubject - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignSubject_Modify;
CREATE  PROCEDURE sp_SJ_RH_DesignSubject_Modify
(
   IN i_ID int,
   IN i_DesignID int,
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_DesignSubject
  SET
      DesignID = i_DesignID,
      GradeCode = i_GradeCode,
      SubjectCode = i_SubjectCode,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
