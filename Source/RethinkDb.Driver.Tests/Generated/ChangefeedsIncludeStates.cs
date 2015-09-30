




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class ChangefeedsIncludeStates : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #1
                 //ExpectedOriginal: [{'state': 'ready'}]
                 var expected = Arrays.asList(new MapObject().with("state", "ready"));
                 
                 //Original: tbl.changes(squash=true, include_states=true).limit(1)
                 var obtained = runOrCatch( tbl.changes().optArg("squash", true).optArg("include_states", true).limit(1) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #2
                 //ExpectedOriginal: [{'state': 'initializing'}, {'new_val': None}, {'state': 'ready'}]
                 var expected = Arrays.asList(new MapObject().with("state", "initializing"), new MapObject().with("new_val", null), new MapObject().with("state", "ready"));
                 
                 //Original: tbl.get(0).changes(squash=true, include_states=true).limit(3)
                 var obtained = runOrCatch( tbl.get(0).changes().optArg("squash", true).optArg("include_states", true).limit(3) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #3
                 //ExpectedOriginal: [{'state': 'initializing'}, {'state': 'ready'}]
                 var expected = Arrays.asList(new MapObject().with("state", "initializing"), new MapObject().with("state", "ready"));
                 
                 //Original: tbl.order_by(index='id').limit(10).changes(squash=true, include_states=true).limit(2)
                 var obtained = runOrCatch( tbl.orderBy().optArg("index", "id").limit(10).changes().optArg("squash", true).optArg("include_states", true).limit(2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #4
                 //ExpectedOriginal: None
                 var expected = null as object;
                 
                 //Original: tbl.insert({'id':1})
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #5
                 //ExpectedOriginal: [{'state': 'initializing'}, {'new_val': {'id': 1}}, {'state': 'ready'}]
                 var expected = Arrays.asList(new MapObject().with("state", "initializing"), new MapObject().with("new_val", new MapObject().with("id", 1)), new MapObject().with("state", "ready"));
                 
                 //Original: tbl.order_by(index='id').limit(10).changes(squash=true, include_states=true).limit(3)
                 var obtained = runOrCatch( tbl.orderBy().optArg("index", "id").limit(10).changes().optArg("squash", true).optArg("include_states", true).limit(3) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #Templates.YamlTest+DefTest.
             //Original: tblchanges = tbl.changes(squash=true, include_states=true)
             
Changes tblchanges = (Changes) tbl.changes().optArg("squash", true).optArg("include_states", true);             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #7
                 //ExpectedOriginal: None
                 var expected = null as object;
                 
                 //Original: tbl.insert({'id':2})
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 2)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #8
                 //ExpectedOriginal: [{'state': 'ready'}, {'old_val': None, 'new_val': {'id': 2}}]
                 var expected = Arrays.asList(new MapObject().with("state", "ready"), new MapObject().with("old_val", null).with("new_val", new MapObject().with("id", 2)));
                 
                 //Original: fetch(tblchanges, 2)
                 var obtained = runOrCatch( fetch(tblchanges, 2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #Templates.YamlTest+DefTest.
             //Original: getchanges = tbl.get(2).changes(include_states=true)
             
Changes getchanges = (Changes) tbl.get(2).changes().optArg("include_states", true);             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #10
                 //ExpectedOriginal: None
                 var expected = null as object;
                 
                 //Original: tbl.get(2).update({'a':1})
                 var obtained = runOrCatch( tbl.get(2).update(new MapObject().with("a", 1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #11
                 //ExpectedOriginal: [{'state': 'initializing'}, {'new_val': {'id': 2}}, {'state': 'ready'}, {'old_val': {'id': 2}, 'new_val': {'a': 1, 'id': 2}}]
                 var expected = Arrays.asList(new MapObject().with("state", "initializing"), new MapObject().with("new_val", new MapObject().with("id", 2)), new MapObject().with("state", "ready"), new MapObject().with("old_val", new MapObject().with("id", 2)).with("new_val", new MapObject().with("a", 1).with("id", 2)));
                 
                 //Original: fetch(getchanges, 4)
                 var obtained = runOrCatch( fetch(getchanges, 4) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #Templates.YamlTest+DefTest.
             //Original: limitchanges = tbl.order_by(index='id').limit(10).changes(include_states=true)
             
Changes limitchanges = (Changes) tbl.orderBy().optArg("index", "id").limit(10).changes().optArg("include_states", true);             
             
             //JavaDef, changefeeds/include_states.yaml, #Templates.YamlTest+DefTest.
             //Original: limitchangesdesc = tbl.order_by(index=r.desc('id')).limit(10).changes(include_states=true)
             
Changes limitchangesdesc = (Changes) tbl.orderBy().optArg("index", r.desc("id")).limit(10).changes().optArg("include_states", true);             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #14
                 //ExpectedOriginal: None
                 var expected = null as object;
                 
                 //Original: tbl.insert({'id':3})
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 3)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #15
                 //ExpectedOriginal: [{'state': 'initializing'}, {'new_val': {'id': 1}}, {'new_val': {'a': 1, 'id': 2}}, {'state': 'ready'}, {'old_val': None, 'new_val': {'id': 3}}]
                 var expected = Arrays.asList(new MapObject().with("state", "initializing"), new MapObject().with("new_val", new MapObject().with("id", 1)), new MapObject().with("new_val", new MapObject().with("a", 1).with("id", 2)), new MapObject().with("state", "ready"), new MapObject().with("old_val", null).with("new_val", new MapObject().with("id", 3)));
                 
                 //Original: fetch(limitchanges, 5)
                 var obtained = runOrCatch( fetch(limitchanges, 5) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #16
                 //ExpectedOriginal: [{'state': 'initializing'}, {'new_val': {'a': 1, 'id': 2}}, {'new_val': {'id': 1}}, {'state': 'ready'}, {'old_val': None, 'new_val': {'id': 3}}]
                 var expected = Arrays.asList(new MapObject().with("state", "initializing"), new MapObject().with("new_val", new MapObject().with("a", 1).with("id", 2)), new MapObject().with("new_val", new MapObject().with("id", 1)), new MapObject().with("state", "ready"), new MapObject().with("old_val", null).with("new_val", new MapObject().with("id", 3)));
                 
                 //Original: fetch(limitchangesdesc, 5)
                 var obtained = runOrCatch( fetch(limitchangesdesc, 5) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}
