










//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Seconds : ReqlExpr {

    
    
    
/// <summary>
/// Return the seconds in a time object as a number between 0 and 59.999 (double precision).
/// </summary>
/// <example><strong>Example:</strong> Return the post submitted during the first 30 seconds of every minute.
/// <code>r.table("posts").filter(function(post) {
///     return post("date").seconds().lt(30)
/// })
/// </code></example>
        public Seconds (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// Return the seconds in a time object as a number between 0 and 59.999 (double precision).
/// </summary>
/// <example><strong>Example:</strong> Return the post submitted during the first 30 seconds of every minute.
/// <code>r.table("posts").filter(function(post) {
///     return post("date").seconds().lt(30)
/// })
/// </code></example>
        public Seconds (Arguments args) : this(args, null) {
        }
/// <summary>
/// Return the seconds in a time object as a number between 0 and 59.999 (double precision).
/// </summary>
/// <example><strong>Example:</strong> Return the post submitted during the first 30 seconds of every minute.
/// <code>r.table("posts").filter(function(post) {
///     return post("date").seconds().lt(30)
/// })
/// </code></example>
        public Seconds (Arguments args, OptArgs optargs)
             : this(TermType.SECONDS, args, optargs) {
        }

    protected Seconds (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
