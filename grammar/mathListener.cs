//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from math.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="mathParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public interface ImathListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="mathParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] mathParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="mathParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] mathParser.StartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="mathParser.format"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormat([NotNull] mathParser.FormatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="mathParser.format"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormat([NotNull] mathParser.FormatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="mathParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraint([NotNull] mathParser.ConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="mathParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraint([NotNull] mathParser.ConstraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="mathParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject([NotNull] mathParser.ObjectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="mathParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject([NotNull] mathParser.ObjectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="mathParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet([NotNull] mathParser.SetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="mathParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet([NotNull] mathParser.SetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="mathParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList([NotNull] mathParser.ListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="mathParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList([NotNull] mathParser.ListContext context);
}
