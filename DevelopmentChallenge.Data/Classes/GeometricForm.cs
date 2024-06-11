/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Classes.enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevelopmentChallenge.Data.Util;

namespace DevelopmentChallenge.Data.Classes
{
    public class GeometricForm
    {
        //method used to print N geometric forms in an specific language
        public static string Print(List<GeometricFormAbstract> forms, Language language)
        {
            var sb = new StringBuilder();

            if (!forms.Any())
            {
                sb.Append(UtilResources.GetValue("EMPTY_LIST", language));
            }
            else
            {
                // HEADER
                sb.Append(UtilResources.GetValue("TITLE", language));

                var groupFormByType = forms
                   .GroupBy(u => u.Type)
                   .Select(grp => grp.ToList())
                   .ToList();

                var totalArea = 0m;
                var totalPerimeter = 0m;
                // CONTENT
                foreach (var group in groupFormByType)
                {
                    var number = 0;
                    var area = 0m;
                    var perimeter = 0m;
                    var type = -1;
                    foreach (var geometricForm in group)
                    {
                        number++;
                        area += geometricForm.CalculateArea;
                        perimeter += geometricForm.CalculatePerimeter;
                        type = geometricForm.Type;
                    }
                    totalArea += area;
                    totalPerimeter += perimeter;
                    var title = UtilResources.GetValue(number > 1 ? "FORM_TITLE_TYPE_PLURAL_" + type : "FORM_TITLE_TYPE_SINGLE_" + type, language);
                    sb.Append(UtilResources.GetValueFormat("GEOMETRIC_RESUME", language, number, title, area.ToString("#.##"), perimeter.ToString("#.##")));
                }

                // FOOTER
                sb.Append(UtilResources.GetValue("TOTAL", language));
                sb.Append(UtilResources.GetValueFormat(forms.Count > 1 ? "FORM_TITLE" : "FORM_SINGLE_TITLE", language, forms.Count));
                sb.Append(UtilResources.GetValueFormat("PERIMETER_TITLE", language, (totalPerimeter).ToString("#.##")));
                sb.Append(UtilResources.GetValueFormat("AREA_TITLE", language, (totalArea).ToString("#.##")));
            }

            return sb.ToString();
        }
    }
}
