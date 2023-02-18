using System;
using Xunit;

namespace SubTrim.UnitTests;

public class SubTrim_TrimEndShould
{
    [Fact]
    public void TrimEnd_SourceIsNull_ThrowArgumentException() 
    {
        string source = null;
        try
        {
            source = source.TrimEnd("test");
        }
        catch (ArgumentNullException e)
        {
            Assert.True(e.ParamName == "source");
            return;
        }

        Assert.True(false);

    }

    [Fact]
    public void TrimEnd_SubstrIsNull_ThrowArgumentException()
    {
        string source = "test";
        try
        {
            source = source.TrimEnd((string)null);

        }
        catch (ArgumentNullException e)
        {
            Assert.True(e.ParamName == "substr");
            return;
        }

        Assert.True(false);
    }

    [Fact]
    public void TrimEnd_SubstrIsEmpty_ReturnSource()
    {
        string source = "Quantum Information";

        string ret = source.TrimEnd(string.Empty);

        Assert.True(source == ret);
    }

    [Fact]
    public void TrimEnd_SourceDontContainSubStr_ReturnSource()
    {
        string source = "Quantum Information";

        string ret = source.TrimEnd("xyz");

        Assert.True(source == ret);
    }

    [Fact]
    public void TrimEnd_SourceContainsSingleSubstr_Trimmed()
    {
        string source = "Quantum Information";
        
        string ret = source.TrimEnd("form");

        Assert.True(ret == "Quantum Ination", $"result is {ret}");
    }

    [Fact]
    public void TrimEnd_SourceContainsMultipleSubstr_LastTrimmed()
    {
        string source = "foo IS NULL AND foo = 1 AND foo = 2 AND";

        string ret = source.TrimEnd(" AND");

        Assert.True(ret == "foo IS NULL AND foo = 1 AND foo = 2", $"result is {ret}");
    }
}