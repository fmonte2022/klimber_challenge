# Klimber - Challenge
En este documento se detallará como se planteo la solución

#### Contenido

- [Creación del modelo](#creación-del-modelo)
- [Manejo del idioma](#manejo-del-idioma)
  
<br>

## [Creación del modelo][toc]

He usado el patrón Strategy para definir diferentes figuras geometricas, las actuales en la solución inicial y se ha sumado nuevas figuras. La idea con el uso de este patrón es lograr que cada figura sepa como calcular su area y perimetro.
Para esto, se hizo una clase abstracta con los metodos a implementar por cada clase figura y además se definio una Intercace como para saber la firma de cada figura como debe definirse.

<br>

## [Manejo del idioma][toc]

Se ha creado diferentes recursos RESX para cada uno de los idiomas y a traves de una clase de utility se va obteniendo los diferentes textos a imprimir.</br></br>
<b>Nota:</b> Se aplico el patrón Singleton para obtener el ResourceManager durante la ejecución del test.

<br>

[toc]: #contenido "Ir a la tabla de contenidos"
