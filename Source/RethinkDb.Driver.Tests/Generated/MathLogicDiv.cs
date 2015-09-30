




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
    public class MathLogicDiv : GeneratedTest {



        [Test]
        public void YamlTest(){

             
             {
                 //JavaQuery, math_logic/div.yaml, #1
                 //ExpectedOriginal: 2
                 var expected = 2;
                 
                 //Original: (r.expr(4) / 2)
                 var obtained = runOrCatch( r.div(r.expr(4), 2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #1
                 //ExpectedOriginal: 2
                 var expected = 2;
                 
                 //Original: (4 / r.expr(2))
                 var obtained = runOrCatch( r.div(4, r.expr(2)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #1
                 //ExpectedOriginal: 2
                 var expected = 2;
                 
                 //Original: r.expr(4).div(2)
                 var obtained = runOrCatch( r.expr(4).div(2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #2
                 //ExpectedOriginal: 0.5
                 var expected = 0.5;
                 
                 //Original: r.expr(-1) / -2
                 var obtained = runOrCatch( r.div(r.expr(-1), -2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #3
                 //ExpectedOriginal: 4.9 / 0.7
                 var expected = 4.9 / 0.7;
                 
                 //Original: r.expr(4.9) / 0.7
                 var obtained = runOrCatch( r.div(r.expr(4.9), 0.7) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #5
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1])
                 var expected = err("ReqlQueryLogicError", "Cannot divide by zero.", Arrays.asList(1));
                 
                 //Original: r.expr(1) / 0
                 var obtained = runOrCatch( r.div(r.expr(1), 0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #5
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1])
                 var expected = err("ReqlQueryLogicError", "Cannot divide by zero.", Arrays.asList(1));
                 
                 //Original: r.expr(2.0) / 0
                 var obtained = runOrCatch( r.div(r.expr(2.0), 0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #5
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1])
                 var expected = err("ReqlQueryLogicError", "Cannot divide by zero.", Arrays.asList(1));
                 
                 //Original: r.expr(3) / 0.0
                 var obtained = runOrCatch( r.div(r.expr(3), 0.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #5
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1])
                 var expected = err("ReqlQueryLogicError", "Cannot divide by zero.", Arrays.asList(1));
                 
                 //Original: r.expr(4.0) / 0.0
                 var obtained = runOrCatch( r.div(r.expr(4.0), 0.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #5
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1])
                 var expected = err("ReqlQueryLogicError", "Cannot divide by zero.", Arrays.asList(1));
                 
                 //Original: r.expr(0) / 0
                 var obtained = runOrCatch( r.div(r.expr(0), 0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #5
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1])
                 var expected = err("ReqlQueryLogicError", "Cannot divide by zero.", Arrays.asList(1));
                 
                 //Original: r.expr(0.0) / 0.0
                 var obtained = runOrCatch( r.div(r.expr(0.0), 0.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #6
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [0])
                 var expected = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", Arrays.asList(0));
                 
                 //Original: r.expr('a') / 0.8
                 var obtained = runOrCatch( r.div(r.expr("a"), 0.8) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, math_logic/div.yaml, #7
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [1])
                 var expected = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", Arrays.asList(1));
                 
                 //Original: r.expr(1) / 'a'
                 var obtained = runOrCatch( r.div(r.expr(1), "a") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}
