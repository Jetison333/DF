using System.Diagnostics;
using System.Net.Http.Headers;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

using DiscreteParser.grammar;

namespace DiscreteParser;
public class StringParser
{
    readonly string format;
    public Dictionary<string, UtilCollection> map = new();

    public StringParser (string f)
    {
        format = f;
    }

    public void parse(string instance)
    {
        AntlrInputStream stream = new AntlrInputStream(format);
        collLexer lex =  new collLexer(stream);
        CommonTokenStream tokens = new CommonTokenStream(lex);
        collParser parser = new collParser(tokens);

        parser.BuildParseTree = true;
        IParseTree parseTree = parser.start();
        codeGen gen = new codeGen(new UtilCollection(instance));
        ParseTreeWalker.Default.Walk(gen, parseTree);

        map = gen.map; 

    }

    public UtilCollection this[string key]
    {
        get { return map[key]; }
    }
}