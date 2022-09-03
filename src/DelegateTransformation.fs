module FSharp.Function.Transformers.DelegateTransformation

open System

let toAction0 f = Action(f)
let toAction1 f = Action<'a>(f)
let toAction2 f = Action<'a,'b>(f)
let toAction3 f = Action<'a,'b,'c>(f)
let toAction4 f = Action<'a,'b,'c,'d>(f)

let toFunc0 f = Func<'a>(f)
let toFunc1 f = Func<'a,'b>(f)
let toFunc2 f = Func<'a,'b,'c>(f)
let toFunc3 f = Func<'a,'b,'c,'d>(f)
let toFunc4 f = Func<'a,'b,'c,'d,'e>(f)

let fromAction0 (a: Action) = a.Invoke
let fromAction1 (a: Action<'a>) = a.Invoke
let fromAction2 (a: Action<'a,'b>) = a.Invoke
let fromAction3 (a: Action<'a,'b,'c>) = a.Invoke
let fromAction4 (a: Action<'a,'b,'c,'d>) = a.Invoke

let fromFunc0 (f: Func<'a>) = f.Invoke
let fromFunc1 (f: Func<'a,'b>) = f.Invoke
let fromFunc2 (f: Func<'a,'b,'c>) = Currying.curry2 f.Invoke
let fromFunc3 (f: Func<'a,'b,'c,'d>) = Currying.curry3 f.Invoke
let fromFunc4 (f: Func<'a,'b,'c,'d,'e>) = Currying.curry4 f.Invoke