﻿using System.Web;
using System.Web.Optimization;

namespace MyCricketSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/SiteScipts").Include(
                        "~/Scripts/jquery-{version}.js",
                         "~/Scripts/jquery.validate*",
                           "~/Scripts/HomeScripts.js",
                          "~/Scripts/GeneralScipts.js",
                          "~/Scripts/menu.js",
                           "~/Scripts/classie.js",
                            "~/Scripts/popup.js",
                            "~/Scripts/jquery.bxslider.js"
                            
                           ));



            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/menu.css",
                      "~/Content/popup.css",
                      "~/Content/jquery.bxslider.css"
                      
                      ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            // BundleTable.EnableOptimizations = true;
        }
    }
}
