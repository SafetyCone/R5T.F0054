using System;

using R5T.T0132;


namespace R5T.F0054
{
	[FunctionalityMarker]
	public partial interface ITextFileGenerator : IFunctionalityMarker
	{
		public void CreateAppSettingsJsonFile(
	string filePath)
		{
			var text =
$@"
{{
  ""Logging"": {{
    ""LogLevel"": {{
      ""Default"": ""Information"",
      ""Microsoft.AspNetCore"": ""Warning""
    }}
  }},
  ""AllowedHosts"": ""*""
}}
";

			this.WriteText(
				filePath,
				text);
		}

        public void CreateAppSettingsDevelopmentJsonFile(
    string filePath)
        {
            var text =
$@"
{{
  ""Logging"": {{
    ""LogLevel"": {{
      ""Default"": ""Information"",
      ""Microsoft.AspNetCore"": ""Warning""
    }}
  }}
}}
";

            this.WriteText(
                filePath,
                text);
        }

        public void CreateProjectPlanTextFile(
			string filePath,
			string projectName,
			string projectDescription)
		{
			var text =
$@"
{projectName} - {projectDescription}
";

			this.WriteText(
				filePath,
				text);
		}

		public void CreateLaunchSettingsJsonFile(
			string filePath)
		{
			var text =
$@"
{{
  ""iisSettings"": {{
    ""windowsAuthentication"": false,
    ""anonymousAuthentication"": true,
    ""iisExpress"": {{
      ""applicationUrl"": ""http://localhost:15888"",
      ""sslPort"": 44322
    }}
  }},
  ""profiles"": {{
    ""R5T.E0054"": {{
      ""commandName"": ""Project"",
      ""dotnetRunMessages"": true,
      ""launchBrowser"": true,
      ""applicationUrl"": ""https://localhost:7069;http://localhost:5069"",
      ""environmentVariables"": {{
        ""ASPNETCORE_ENVIRONMENT"": ""Development""
      }}
    }},
    ""IIS Express"": {{
      ""commandName"": ""IISExpress"",
      ""launchBrowser"": true,
      ""environmentVariables"": {{
        ""ASPNETCORE_ENVIRONMENT"": ""Development""
      }}
    }}
  }}
}}
";

			this.WriteText(
				filePath,
				text);
		}

		public void CreateProjectPlanMarkdownFile(
			string filePath,
			string projectName,
			string projectDescription)
		{
			var text =
$@"
# {projectName}
{projectDescription}
";

			this.WriteText(
				filePath,
				text);
		}

		public void WriteText(
			string filePath,
			string text,
			bool trim = true)
		{
			var outputText = trim
				? text.Trim()
				: text
				;

			Instances.FileOperator.WriteText_Synchronous(
				filePath,
				outputText);
		}
	}
}