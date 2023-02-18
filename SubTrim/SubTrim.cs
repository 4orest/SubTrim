namespace SubTrim;
public static class SubTrim
{
    public static string TrimEnd(this string source, string substr) 
    {
        if (source is null)
        {
            throw new ArgumentNullException("source");
        }

        if (substr is null)
        {
            throw new ArgumentNullException("substr");
        }

        int index = source.LastIndexOf(substr);
        
        if (index == -1)
        {
            return source;
        }

        return source.Remove(index, substr.Length);
    }

    public static string TrimStart(this string source, string substr)
    {
        if (source is null)
        {
            throw new ArgumentNullException("source");
        }

        if (substr is null)
        {
            throw new ArgumentNullException("substr");
        }

        int index = source.IndexOf(substr);
        
        if (index == -1)
        {
            return source;
        }

        return source.Remove(index, substr.Length);
    }

    public static string Trim(this string source, string substr)
    {
        if (source is null)
        {
            throw new ArgumentNullException("source");
        }

        if (substr is null)
        {
            throw new ArgumentNullException("substr");
        }

        string ret = source;
        string trimmed = ret.TrimStart(substr);
        while (ret != trimmed)
        {
            ret = trimmed;
            trimmed = ret.TrimStart(substr);
        }

        return ret;
    }
}
