










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

    public class Filter : ReqlExpr {

    
    
    
/// <summary>
/// Get all the documents for which the given predicate is true.
/// <code>filter</code> can be called on a sequence, selection, or a field containing an array of
/// elements. The return type is the same as the type on which the function was called on.
/// The body of every filter is wrapped in an implicit <code>.default(false)</code>, which means that
/// if a non-existence errors is thrown (when you try to access a field that does not exist
/// in a document), RethinkDB will just ignore the document.
/// The <code>default</code> value can be changed by passing an object with a <code>default</code> field.
/// Setting this optional argument to <code>r.error()</code> will cause any non-existence errors to
/// return a <code>RqlRuntimeError</code>.
/// </summary>
/// <example><strong>Example:</strong> Get all the users that are 30 years old.
/// <code>r.table('users').filter({age: 30}).run(conn, callback)
/// </code></example>
        public Filter (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// Get all the documents for which the given predicate is true.
/// <code>filter</code> can be called on a sequence, selection, or a field containing an array of
/// elements. The return type is the same as the type on which the function was called on.
/// The body of every filter is wrapped in an implicit <code>.default(false)</code>, which means that
/// if a non-existence errors is thrown (when you try to access a field that does not exist
/// in a document), RethinkDB will just ignore the document.
/// The <code>default</code> value can be changed by passing an object with a <code>default</code> field.
/// Setting this optional argument to <code>r.error()</code> will cause any non-existence errors to
/// return a <code>RqlRuntimeError</code>.
/// </summary>
/// <example><strong>Example:</strong> Get all the users that are 30 years old.
/// <code>r.table('users').filter({age: 30}).run(conn, callback)
/// </code></example>
        public Filter (Arguments args) : this(args, null) {
        }
/// <summary>
/// Get all the documents for which the given predicate is true.
/// <code>filter</code> can be called on a sequence, selection, or a field containing an array of
/// elements. The return type is the same as the type on which the function was called on.
/// The body of every filter is wrapped in an implicit <code>.default(false)</code>, which means that
/// if a non-existence errors is thrown (when you try to access a field that does not exist
/// in a document), RethinkDB will just ignore the document.
/// The <code>default</code> value can be changed by passing an object with a <code>default</code> field.
/// Setting this optional argument to <code>r.error()</code> will cause any non-existence errors to
/// return a <code>RqlRuntimeError</code>.
/// </summary>
/// <example><strong>Example:</strong> Get all the users that are 30 years old.
/// <code>r.table('users').filter({age: 30}).run(conn, callback)
/// </code></example>
        public Filter (Arguments args, OptArgs optargs)
             : this(TermType.FILTER, args, optargs) {
        }

    protected Filter (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
