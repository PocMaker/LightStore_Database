/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
--C
IF (NOT EXISTS(SELECT TOP 1 1 FROM Administration.Operator WHERE Login = 'SuperAdmin'))
    EXEC Administration.uspCreateOperator @p_firstName = 'Super', @p_lastName = 'Admin', @p_login = 'SuperAdmin';
GO

DECLARE @schema varchar(255),
        @name varchar(255);
DECLARE routine CURSOR FOR 
    SELECT ROUTINE_SCHEMA, ROUTINE_NAME
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE ROUTINE_TYPE = 'PROCEDURE';
OPEN routine;
FETCH NEXT FROM routine INTO @schema, @name;
WHILE (@@FETCH_STATUS = 0)
BEGIN;
    EXECUTE('GRANT EXECUTE ON OBJECT::[' + @schema + '].[' + @name + '] TO [LightStore];');
    FETCH NEXT FROM routine INTO @schema, @name;
END;
CLOSE routine;
DEALLOCATE routine;
