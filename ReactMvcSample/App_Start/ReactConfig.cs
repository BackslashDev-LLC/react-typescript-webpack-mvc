using React;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ReactMvcSample.ReactConfig), "Configure")]

namespace ReactMvcSample
{
	public static class ReactConfig
	{
		public static void Configure()
		{
            ReactSiteConfiguration.Configuration
                .AddScriptWithoutTransform("~/wwwroot/dist/vendor.js")
                .AddScriptWithoutTransform("~/wwwroot/dist/runtime.js")
                .AddScriptWithoutTransform("~/wwwroot/dist/components.js");

            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();
        }
	}
}