using System;


namespace R5T.F0054
{
	public class TextFileGenerator : ITextFileGenerator
	{
		#region Infrastructure

	    public static ITextFileGenerator Instance { get; } = new TextFileGenerator();

	    private TextFileGenerator()
	    {
        }

	    #endregion
	}
}