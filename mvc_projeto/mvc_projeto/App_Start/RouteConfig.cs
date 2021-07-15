using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc_projeto
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                 "Produtos",
                 "Produtos",
                 new { controller = "Produtos", action = "Index" }
            );

            routes.MapRoute(
                 "Produtos_novo",
                 "Produtos/Novo",
                 new { controller = "Produtos", action = "Novo" }
            );
            routes.MapRoute(
                "Produtos_editar",
                "Produtos/{id}/Editar",
                new { controller = "Produtos", action = "Editar", id=0}
           );
            routes.MapRoute(
    "Produtos_atualizar",
    "Produtos/{id}/Atualizar",
    new { controller = "Produtos", action = "Atualizar", id = 0 }
);
            routes.MapRoute(
    "Produtos_excluir",
    "Produtos/{id}/Excluir",
    new { controller = "Produtos", action = "Excluir", id = 0 }
);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
