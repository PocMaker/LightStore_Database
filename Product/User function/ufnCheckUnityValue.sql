CREATE FUNCTION [Product].[ufnCheckUnityValue]
(
	@p_unityCode varchar(255)
)
RETURNS INT
AS
BEGIN
	RETURN CASE WHEN @p_unityCode IS NULL OR @p_unityCode IN ('CSU', 'CASE', 'LAYER', 'PALETT') THEN 1 ELSE 0 END
END
