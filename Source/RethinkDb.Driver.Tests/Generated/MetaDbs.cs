




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
    public class MetaDbs : GeneratedTest {



        [Test]
        public void YamlTest(){

             
             {
                 //JavaQuery, meta/dbs.yaml, #1
                 //ExpectedOriginal: bag(['rethinkdb', 'test'])
                 var expected = bag(Arrays.asList("rethinkdb", "test"));
                 
                 //Original: r.db_list()
                 var obtained = runOrCatch( r.dbList() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #2
                 //ExpectedOriginal: partial({'dbs_created':1})
                 var expected = partial(new MapObject().with("dbs_created", 1));
                 
                 //Original: r.db_create('a')
                 var obtained = runOrCatch( r.dbCreate("a") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #3
                 //ExpectedOriginal: partial({'dbs_created':1})
                 var expected = partial(new MapObject().with("dbs_created", 1));
                 
                 //Original: r.db_create('b')
                 var obtained = runOrCatch( r.dbCreate("b") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #4
                 //ExpectedOriginal: bag(['rethinkdb', 'a', 'b', 'test'])
                 var expected = bag(Arrays.asList("rethinkdb", "a", "b", "test"));
                 
                 //Original: r.db_list()
                 var obtained = runOrCatch( r.dbList() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #5
                 //ExpectedOriginal: {'name': 'a', 'uuid': uuid()}
                 var expected = new MapObject().with("name", "a").with("uuid", uuid());
                 
                 //Original: r.db('a').config()
                 var obtained = runOrCatch( r.db("a").config() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #6
                 //ExpectedOriginal: partial({'dbs_dropped':1})
                 var expected = partial(new MapObject().with("dbs_dropped", 1));
                 
                 //Original: r.db_drop('b')
                 var obtained = runOrCatch( r.dbDrop("b") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #7
                 //ExpectedOriginal: bag(['rethinkdb', 'a', 'test'])
                 var expected = bag(Arrays.asList("rethinkdb", "a", "test"));
                 
                 //Original: r.db_list()
                 var obtained = runOrCatch( r.dbList() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #8
                 //ExpectedOriginal: partial({'dbs_dropped':1})
                 var expected = partial(new MapObject().with("dbs_dropped", 1));
                 
                 //Original: r.db_drop('a')
                 var obtained = runOrCatch( r.dbDrop("a") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #9
                 //ExpectedOriginal: bag(['rethinkdb', 'test'])
                 var expected = bag(Arrays.asList("rethinkdb", "test"));
                 
                 //Original: r.db_list()
                 var obtained = runOrCatch( r.dbList() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #10
                 //ExpectedOriginal: partial({'dbs_created':1})
                 var expected = partial(new MapObject().with("dbs_created", 1));
                 
                 //Original: r.db_create('bar')
                 var obtained = runOrCatch( r.dbCreate("bar") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #11
                 //ExpectedOriginal: err('ReqlOpFailedError', 'Database `bar` already exists.', [0])
                 var expected = err("ReqlOpFailedError", "Database `bar` already exists.", Arrays.asList(0));
                 
                 //Original: r.db_create('bar')
                 var obtained = runOrCatch( r.dbCreate("bar") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #12
                 //ExpectedOriginal: partial({'dbs_dropped':1})
                 var expected = partial(new MapObject().with("dbs_dropped", 1));
                 
                 //Original: r.db_drop('bar')
                 var obtained = runOrCatch( r.dbDrop("bar") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, meta/dbs.yaml, #13
                 //ExpectedOriginal: err('ReqlOpFailedError', 'Database `bar` does not exist.', [0])
                 var expected = err("ReqlOpFailedError", "Database `bar` does not exist.", Arrays.asList(0));
                 
                 //Original: r.db_drop('bar')
                 var obtained = runOrCatch( r.dbDrop("bar") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}
