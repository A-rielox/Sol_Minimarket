
USE BD_MINIMARKET;
GO

CREATE PROCEDURE USP_Eliminar_ca
(
	@nCodigo_ca INT = 0
)
AS
BEGIN

	UPDATE TB_CATEGORIAS
	SET estado = 0 
	WHERE codigo_ca = @nCodigo_ca;

END
GO
