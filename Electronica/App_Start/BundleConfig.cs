﻿using System.Web;
using System.Web.Optimization;

namespace Electronica
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/jquery-1.11.1.min.js",                            
                     "~/Scripts/megamenu.js",
                     "~/Scripts/menu_jquery.js",
                     "~/Scripts/simpleCart.min.js",
                     "~/Scripts/scripts.js",
                     "~/Scripts/modernizr.custom.js",
                     "~/Scripts/move-top.js",
                      "~/Scripts/easing.js",


                      "~/Scripts/bootstrap.js",
                      "~/Scripts/modernizr-2.6.2.js",
                      
                     
                     
                      
                      
                     
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                       "~/Content/megamenu.css",
                      "~/Content/style.css",
                     
                      "~/Content/jasny-bootstrap.min.css",
                      
                      
                      "~/Content/site.css"));



            bundles.Add(new ScriptBundle("~/bundles/admin-js").Include(
                 "~/Scripts/bootstrap.js",                
                                 
                 "~/Scripts/respond.js"));
                 


            bundles.Add(new StyleBundle("~/Content/admin-css").Include(
          "~/Content/bootstrap.css",
          "~/Content/jasny-bootstrap.min.css",         
          "~/Content/admin-style.css",
          "~/Content/site.css"));


        }
    }
}
