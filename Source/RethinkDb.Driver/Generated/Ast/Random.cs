










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

    public class Random : ReqlExpr {

    
    
    
/// <summary>
/// Generate a random number between given (or implied) bounds. <code>random</code> takes zero, one or two arguments.
/// </summary>
/// <example><strong>Example:</strong> Generate a random number in the range <code>[0,1)</code>
/// <code>r.random().run(conn, callback)
/// </code></example>
        public Random (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// Generate a random number between given (or implied) bounds. <code>random</code> takes zero, one or two arguments.
/// </summary>
/// <example><strong>Example:</strong> Generate a random number in the range <code>[0,1)</code>
/// <code>r.random().run(conn, callback)
/// </code></example>
        public Random (Arguments args) : this(args, null) {
        }
/// <summary>
/// Generate a random number between given (or implied) bounds. <code>random</code> takes zero, one or two arguments.
/// </summary>
/// <example><strong>Example:</strong> Generate a random number in the range <code>[0,1)</code>
/// <code>r.random().run(conn, callback)
/// </code></example>
        public Random (Arguments args, OptArgs optargs)
             : this(TermType.RANDOM, args, optargs) {
        }

    protected Random (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
