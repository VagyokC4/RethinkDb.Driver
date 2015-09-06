










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

    public class SetDifference : ReqlExpr {

    
    
    
/// <summary>
/// Remove the elements of one array from another and return them as a set (an array with
/// distinct values).
/// </summary>
/// <example><strong>Example:</strong> Check which pieces of equipment Iron Man has, excluding a fixed list.
/// <code>r.table('marvel').get('IronMan')('equipment').setDifference(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetDifference (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// Remove the elements of one array from another and return them as a set (an array with
/// distinct values).
/// </summary>
/// <example><strong>Example:</strong> Check which pieces of equipment Iron Man has, excluding a fixed list.
/// <code>r.table('marvel').get('IronMan')('equipment').setDifference(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetDifference (Arguments args) : this(args, null) {
        }
/// <summary>
/// Remove the elements of one array from another and return them as a set (an array with
/// distinct values).
/// </summary>
/// <example><strong>Example:</strong> Check which pieces of equipment Iron Man has, excluding a fixed list.
/// <code>r.table('marvel').get('IronMan')('equipment').setDifference(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetDifference (Arguments args, OptArgs optargs)
             : this(TermType.SET_DIFFERENCE, args, optargs) {
        }

    protected SetDifference (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
