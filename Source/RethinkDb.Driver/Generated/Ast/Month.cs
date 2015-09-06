










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

    public class Month : ReqlExpr {

    
    
    
/// <summary>
/// Return the month of a time object as a number between 1 and 12. For your convenience, the terms r.january, r.february etc. are defined and map to the appropriate integer.
/// </summary>
/// <example><strong>Example:</strong> Retrieve all the users who were born in November.
/// <code>r.table("users").filter(
///     r.row("birthdate").month().eq(11)
/// )
/// </code></example>
        public Month (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// Return the month of a time object as a number between 1 and 12. For your convenience, the terms r.january, r.february etc. are defined and map to the appropriate integer.
/// </summary>
/// <example><strong>Example:</strong> Retrieve all the users who were born in November.
/// <code>r.table("users").filter(
///     r.row("birthdate").month().eq(11)
/// )
/// </code></example>
        public Month (Arguments args) : this(args, null) {
        }
/// <summary>
/// Return the month of a time object as a number between 1 and 12. For your convenience, the terms r.january, r.february etc. are defined and map to the appropriate integer.
/// </summary>
/// <example><strong>Example:</strong> Retrieve all the users who were born in November.
/// <code>r.table("users").filter(
///     r.row("birthdate").month().eq(11)
/// )
/// </code></example>
        public Month (Arguments args, OptArgs optargs)
             : this(TermType.MONTH, args, optargs) {
        }

    protected Month (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
