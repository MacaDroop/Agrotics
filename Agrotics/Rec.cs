using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrotics
{
    public class Rec
    {
        public string recomendacion()
        {
            string recomendacion = "Se sugiere ingresar mas datos para obtener un resultado más preciso";
            return recomendacion;
        }
    
        public string Erwinia()
        {
            string recomendacionErwinia = "Las plantas enfermas no se deben manipular dentro de la plantación. Se debe evitar la entrada a áreas infectadas, para evitar su propagación. Se debe realizar un control adecuado de insectos, con el fin de evitar su diseminación";
            return recomendacionErwinia;
        }

        public string Fusarium()
        {
            string recomendacionFurarium = "Se debe preparar adecuadamente el terreno, con el fin de incorporar en su totalidad los rastrojos de plantación y reducir la humedad. La aplicación del hongo Trichoderma, en la etapa de preparación de terreno o en los primeros meses de desarrollo de la plantación, ";
            return recomendacionFurarium;
        }

        public string Phytophthora()
        {
            string recomendacionPhytophthora = "Se podrían utilizar productos químicos a base de mancozeb y metalaxil. El fosetil-Al y los fosfitos de potasio ayudan como inductores de resistencia, al proporcionar defensas únicamente a la planta. ";
            return recomendacionPhytophthora;
        }

    }
}
