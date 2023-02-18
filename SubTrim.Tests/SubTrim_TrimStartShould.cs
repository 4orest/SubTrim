using System;
using Xunit;

namespace SubTrim.UnitTests;

public class SubTrim_TrimStartShould
{
    [Fact]
    public void TrimStart_SourceIsNull_ThrowArgumentException() 
    {
        string source = null;
        try
        {
            source = source.TrimStart("test");
        }
        catch (ArgumentNullException e)
        {
            Assert.True(e.ParamName == "source");
            return;
        }

        Assert.True(false);

    }

    [Fact]
    public void TrimStart_SubstrIsNull_ThrowArgumentException()
    {
        string source = "test";
        try
        {
            source = source.TrimStart((string)null);

        }
        catch (ArgumentNullException e)
        {
            Assert.True(e.ParamName == "substr");
            return;
        }

        Assert.True(false);
    }

    [Fact]
    public void TrimStart_SubstrIsEmpty_ReturnSource()
    {
        string source = "Quantum Information";

        string ret = source.TrimStart(string.Empty);

        Assert.True(source == ret);
    }

    [Fact]
    public void TrimStart_SourceDontContainSubStr_ReturnSource()
    {
        string source = "Quantum Information";

        string ret = source.TrimStart("xyz");

        Assert.True(source == ret);
    }

    [Fact]
    public void TrimStart_SourceContainsSingleSubstr_Trimmed()
    {
        string source = "Quantum Information";
        
        string ret = source.TrimStart("form");

        Assert.True(ret == "Quantum Ination", $"result is {ret}");
    }

    [Fact]
    public void TrimStart_SourceContainsMultipleSubstr_FirstTrimmed()
    {
        string source = "AND foo IS NULL AND foo = 1 AND foo = 2";

        string ret = source.TrimStart("AND ");

        Assert.True(ret == "foo IS NULL AND foo = 1 AND foo = 2", $"result is {ret}");
    }
}