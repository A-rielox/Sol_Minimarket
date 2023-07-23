CREATE PROCEDURE USP_Listado_ca
	(
		@cTexto VARCHAR(100) = ''
	)
AS
BEGIN

	SELECT	codigo_ca,
			descripcion_ca
	FROM TB_CATEGORIAS
	WHERE	estado = 1
			AND UPPER( TRIM( CAST( codigo_ca AS CHAR )) + TRIM( descripcion_ca )) LIKE
				'%' + UPPER( TRIM( @cTexto )) + '%';
	-- codigo_ca es int en DB
END
GO
