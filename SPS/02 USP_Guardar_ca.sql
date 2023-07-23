
CREATE PROCEDURE USP_Guardar_ca
(
	@nOpcion INT = 0, -- indica si es crear o modificar, 1 : crear, 2 : modificar
	@nCodigo_ca INT = 0,
	@cDescripcion_ca VARCHAR(40) = ''
)
AS
BEGIN
	
	IF @nOpcion = 1		-- crear registro
		BEGIN
			INSERT INTO TB_CATEGORIAS(descripcion_ca, estado)
			VALUES(@cDescripcion_ca, 1);
		END;
	ELSE				-- actualizar reg
		BEGIN
			UPDATE TB_CATEGORIAS 
			SET descripcion_ca = @cDescripcion_ca WHERE codigo_ca = @nCodigo_ca;
		END;
	
END
GO

