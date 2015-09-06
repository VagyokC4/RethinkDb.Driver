










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

    public class TypeOf : ReqlExpr {

    
    
    
/// <summary>
/// Gets the type of a value.
/// </summary>
/// <example><strong>Example:</strong> Get the type of a string.
/// <code>r.expr("foo").typeOf().run(conn, callback)
/// </code></example>
        public TypeOf (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// Gets the type of a value.
/// </summary>
/// <example><strong>Example:</strong> Get the type of a string.
/// <code>r.expr("foo").typeOf().run(conn, callback)
/// </code></example>
        public TypeOf (Arguments args) : this(args, null) {
        }
/// <summary>
/// Gets the type of a value.
/// </summary>
/// <example><strong>Example:</strong> Get the type of a string.
/// <code>r.expr("foo").typeOf().run(conn, callback)
/// </code></example>
        public TypeOf (Arguments args, OptArgs optargs)
             : this(TermType.TYPE_OF, args, optargs) {
        }

    protected TypeOf (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
