using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace OurGames.Club
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/css/bootstrap.css",
                 "~/css/font-awesome.css",
                 "~/css/alertify.core.css",
                 "~/css/alertify.default.css",
                 "~/css/ourgames.club.css"
                 ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/app/app.js",
                "~/app/controller/global.js",
                "~/app/controller/menu.js",
                "~/app/controller/search.js",
                "~/app/controller/login.js",
                "~/app/controller/register.js",
                "~/app/service/auth.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/scripts/bootstrap.js",
                "~/scripts/respond.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
               "~/scripts/angular.js",
               "~/scripts/angular-resource.js",
               "~/scripts/angular-route.js"
               ));

            bundles.Add(new ScriptBundle("~/bundles/components").Include(
                "~/scripts/typeahead.bundle.js",
                "~/scripts/handlebars-v2.0.0.js",
                "~/scripts/alertify.js",
                "~/scripts/ui-bootstrap-tpls-0.12.0.js"
                ));

            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //    "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css"));
        }
    }
}
