CREATE PROCEDURE [Administration].[uspGetOperator]
	@p_id int = NULL,
	@p_login varchar(255) = NULL
AS
BEGIN;
	SELECT Ope.Id, Ope.FirstName, Ope.LastName, Ope.Login, Ope.Email,
		   CAST(CASE WHEN Ope.Password IS NULL THEN 0 ELSE 1 END AS bit) AS IsPasswordDefined,
		   Ope.ModifiedDate
	FROM Administration.Operator Ope
	WHERE Ope.Id = ISNULL(@p_id, Ope.Id)
	  AND Ope.Login = ISNULL(@p_login, Ope.Login);
END;