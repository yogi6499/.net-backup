USE [HumanResourceManagement]
GO
/****** Object:  StoredProcedure [dbo].[AppliedDays]    Script Date: 13-10-2021 02:03:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[AppliedDays](
	-- Add the parameters for the stored procedure here
	@EmployeeId int,
	@fromDate date , 
	@ToDate date,
	@fromSession tinyint,
	@toSession tinyInt)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @days int=day(@ToDate)-day(@fromDate)
    -- Insert statements for procedure here
	insert into leave values (@EmployeeId,@FromDate,@ToDate,@fromSession,@toSession,@days)
END
