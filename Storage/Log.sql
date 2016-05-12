/*
Ne changez pas les variables de nom ou de chemin d'accès.
Toutes variables sqlcmd seront correctement substituées durant 
la génération et le déploiement.
*/
ALTER DATABASE [$(DatabaseName)]
ADD LOG FILE
(
	NAME = [Log],
	FILENAME = '$(DefaultLogPath)$(DefaultFilePrefix)_Log.ldf',
	SIZE = 1024 KB,
	FILEGROWTH = 10%
)
