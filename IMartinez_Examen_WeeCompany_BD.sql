SELECT productos.nombre, categorias.categoria
FROM productos 
INNER JOIN categorias  ON (productos.categoria_id = categorias.id)
WHERE categorias.activo = 1;

SELECT*
FROM Ventas
WHERE fecha > '2023-01-01'
AND fecha < '2023-12-31'
ORDER BY fecha DESC, monto DESC;

