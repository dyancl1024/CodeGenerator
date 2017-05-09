/*
  RH_Course - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Course_Add;
CREATE  PROCEDURE sp_SJ_RH_Course_Add
(
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

  INSERT INTO RH_Course
  (
      CourseName,
      CoursePharse,
      CourseCategoryCode,
      CourseDesc,
      CourseUrl,
      TeacherDesc,
      TeacherName,
      TeacherTitle,
      CourseLabel,
      CourseCode,
      IsPractice,
      CourseCompany,
      CourseStyle,
      IsSpecialTeacher,
      VideoDuration,
      IsApp,
      Status,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_CourseName,  --  nvarchar(200) (课程名称)
      i_CoursePharse,  --  int (课程学时)
      i_CourseCategoryCode,  --  varchar(50) (1-通识 2-专业 3-技术 4-科研 5-教研)
      i_CourseDesc,  --  nvarchar(Max) (CourseDesc)
      i_CourseUrl,  --  nvarchar(200) (记录课程文件路径)
      i_TeacherDesc,  --  nvarchar(Max) (讲师简介)
      i_TeacherName,  --  nvarchar(200) (讲师姓名)
      i_TeacherTitle,  --  nvarchar(200) (讲师职称)
      i_CourseLabel,  --  nvarchar(50) (课程标签)
      i_CourseCode,  --  nvarchar(50) (课程代码)
      i_IsPractice,  --  int (是否为实践性课程：1.是 2.否)
      i_CourseCompany,  --  nvarchar(200) (课程单位)
      i_CourseStyle,  --  nvarchar(200) (课程形式)
      i_IsSpecialTeacher,  --  int (是否为一线教师教研员：1.是 2.否)
      i_VideoDuration,  --  int (学习时长)
      i_IsApp,  --  int (是否App： 1.是2.否)
      i_Status,  --  int (状态 1-未发布 2-已发布 3-删除)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;
