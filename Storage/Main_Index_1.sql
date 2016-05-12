/*
Ne changez pas les variables de nom ou de chemin d'accès.
Toutes variables sqlcmd seront correctement substituées durant 
la génération et le déploiement.
*/
ALTER DATABASE [$(DatabaseName)]
	ADD FILE
	(
		NAME = [Main_Index_1],
		FILENAME = '$(DefaultDataPath)$(DefaultFilePrefix)_Main_Index_1.ndf'
	) TO FILEGROUP MAIN_INDEX;
	
