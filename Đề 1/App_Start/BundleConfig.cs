﻿using System.Web;
using System.Web.Optimization;

namespace Đề_1
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new Bundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));
			bundles.Add(new ScriptBundle("~/bundles/myjs").Include(
					"~/Scripts/js/jquery-1.11.1.min.js"));

			bundles.Add(new StyleBundle("~/Content/mycss").Include(
					  "~/Content/css/bootstrap.css",
					  "~/Content/css/font-awesome.css",
					  "~/Content/css/style.css"));
		}
	}
}
