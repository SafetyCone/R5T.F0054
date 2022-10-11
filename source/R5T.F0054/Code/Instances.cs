using System;

using R5T.F0000;


namespace R5T.F0054
{
    public static class Instances
    {
        public static IFileOperator FileOperator { get; } = F0000.FileOperator.Instance;
    }
}