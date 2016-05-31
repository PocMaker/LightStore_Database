---<summary>
---Select a product from database thanks to its id
---</summary>
---<param name="@p_id" ref="Product.Product.Id">Filter if provided</param>
CREATE PROCEDURE [Product].[uspGetProduct]
	@p_id int = NULL
AS
BEGIN;
	SELECT Pro.Id, Pro.Code, Pro.Label, Pro.Unity, Pro.Weight, Pro.Tare, Pro.GTIN,
		   Pro.ModifiedDate
	FROM Product.Product Pro
	WHERE Pro.Id = ISNULL(@p_id, Pro.Id);

	RETURN 1;
END;