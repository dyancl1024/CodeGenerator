/*
  RH_Course - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Course_Modify;
CREATE  PROCEDURE sp_SJ_RH_Course_Modify
(
   IN i_ID int,
   IN i_CourseName nvarchar(200),
   IN i_CoursePharse int,
   IN i_CourseCategoryCode varchar(50),
   IN i_CourseDesc nvarchar(Max),
   IN i_CourseUrl nvarchar(200),
   IN i_TeacherDesc nvarchar(Max),
   IN i_TeacherName nvarchar(200),
   IN i_TeacherTitle nvarchar(200),
   IN i_CourseLabel nvarchar(50),
   IN i_CourseCode nvarchar(50),
   IN i_IsPractice int,
   IN i_CourseCompany nvarchar(200),
   IN i_CourseStyle nvarchar(200),
   IN i_IsSpecialTeacher int,
   IN i_VideoDuration int,
   IN i_IsApp int,
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Course
  SET
      CourseName = i_CourseName,
      CoursePharse = i_CoursePharse,
      CourseCategoryCode = i_CourseCategoryCode,
      CourseDesc = i_CourseDesc,
      CourseUrl = i_CourseUrl,
      TeacherDesc = i_TeacherDesc,
      TeacherName = i_TeacherName,
      TeacherTitle = i_TeacherTitle,
      CourseLabel = i_CourseLabel,
      CourseCode = i_CourseCode,
      IsPractice = i_IsPractice,
      CourseCompany = i_CourseCompany,
      CourseStyle = i_CourseStyle,
      IsSpecialTeacher = i_IsSpecialTeacher,
      VideoDuration = i_VideoDuration,
      IsApp = i_IsApp,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;
