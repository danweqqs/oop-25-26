using System.Xml.Xsl;

public static class HtmlTransformer
{
    public static void Transform(string xmlFile, string xslFile, string outputFile)
    {
        XslCompiledTransform xslt = new();
        xslt.Load(xslFile);
        xslt.Transform(xmlFile, outputFile);
    }
}