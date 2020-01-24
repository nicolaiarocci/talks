- title : F# for the C# Developer
- description : Introduction to F# and functional programming for the C# developer
- author : Nicola Iarocci
- theme : simple
- transition : none

***

# _<span style="font-weight:300">Introduction to F#</span><br/> and functional programming <br/>for the C# developer_

<br/><br/><br/><br/><br/><br/>

**Nicola Iarocci**<br/>
[@nicolaiarocci](https://twitter.com/nicolaiarocci)

***

## Is it worth the effort learning a new language?

<div class="fragment">

> A language that doesn't affect the way you think about programming, is not worth knowing - [Alan Perlis](https://en.wikipedia.org/wiki/Alan_Perlis)

</div>

<div class="fragment">

- You dont really want to invest your time into learning new, marginally important things

</div>

<div class="fragment">

- F# is a language that will change the way you think about programming

</div>

<div class="fragment">

- Don’t trust people who have never looked at it. Don’t bother.

</div>

***

# _Differences between C# and F#_
## From least to most important

<br/>

<div class="fragment">

  - Concise syntax

</div>
<div class="fragment">

- Type inference

</div>
<div class="fragment">

- Different defaults

</div>
<div class="fragment">

- Different philosophy

</div>

' when you learning a new language you always want to compare it with what you already know, I think that’s a bad idea. Especially if you are learning a new paradigm, you shold start with a beginners’ mind so that old stuff does not interfere. ideally when you learning a new (and totally different) language like F# you should forget C# otherwise you get frustated with why can’t I do this or that (like I used to do in C#)

' syntax is very different and tends to put c# people off
' type inference is very different fro c#
' defaults is different. everything defaults to immutability for example
' different philosophy about what is important when you program


***

# _Unique to F#_

<br/>

<div class="fragment">

  - Functional first

</div>
<div class="fragment">

- Algebraic type system

</div>
<div class="fragment">

- Interactivity

</div>

' interactivity like python or ruby, but in a static language

***

# _SYNTAX_

<img src="images/3x.png" class="nb"/>

***

# _Type inference_

---

    let doSomething f x =
        let y = f (x + 1)
        "hello" + y

    // two parameters: f & x

' f# is really strict you can’t add a float to an int, so x must be an int. also because you are passing it into f, f must be a function; y has to be a string for the same reason
' yes less typing, but more importantly less noise, more logic
' if you/ve used python or ruby etc., you already know you dont really need to look at the types all the time
' you can hover over the code and it will tell you the inferred types
' it will also report an error if you mis-match types

---

    let doSomething f x =
        let y = f (x + 1)   // x must be an int
        "hello" + y

---

    let doSomething f x =
        let y = f (x + 1)
        "hello" + y         // y must be a string

---

    let doSomething f x =
        let y = f (x + 1)   // f must be a int -> string function
        "hello" + y

---
    
## Inferred type of doSomething

    f:(int -> string) -> x:int -> string

    // 'f' is a function, it takes an int and returns a string;
    // 'x' is an int;
    // return value is a string

---

## A more complex example

    [lang=cs]
    // C# code
    public IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
        IEnumerable<TSource> source,
        Func<TSource, TKey> keySelector
        )
    {
    ...
    }


    // F# code
    let GroupBy source keySelector = 
        ...

---

# Benefits of type inference

<br/>
<br/>
<br/>
<br/>

<div class="fragment">
- less typing
</div>
<div class="fragment">
- less noise
</div>
<div class="fragment">
- more logic
</div>

***

# _Different defaults_

---

## F# has different defaults

<br/>

<div class="fragment">

- Immutable by default
  - mutable is a special case

</div>
<div class="fragment">

- Non-null types/classes by default
  - nullable is a special case

</div>
<div class="fragment">

- Structural equality by default
  - reference equality is a special case

</div>
<div class="fragment">

- Everything must be initialized
  - *explicit is better than implicit - Zen of Python*

</div>

---

## Immutability by default

    let x = 1

    x <- 2  // Error: this value is not mutable

---

## Immutability by default

    let mutable x = 1

    x <- 2  // OK
    
' because you have to ask for mutability, you tend to use it less

---

## Not nullable by default

    type Person = {
        Name: string
        Birthday: DateTime
        }

    let x : Person = null   // Error: the type Person does not have null as a proper value

' you don’t have to write defensive code because you are guaranted that nothing is gonna be null in the first place

---

## Not nullable by default

    [<AllowNullLiteralAttribute>]
    type Person(name: string, birthday: DateTime) =
        member this.Name = name
        member this.Birthday = birthday


    let x : Person = null   // OK
<div class="fragment">

    // more pain intended
</div>

---

## Structural equality

    type Person = {
        Name: string
        Birthday: DateTime
        }

    let bday = DateTime(1980,1,1)
    let alice1 = {Name="Alice"; Birthday=bday}
    let alice2 = {Name="Alice"; Birthday=bday} 

    alice1 = alice2     // true or false?

<div class="fragment">

    // true.
    // never write GetHashCode $ Equals ever again!
</div>

---

## Everything must be initialized

    type Person = {
        Name: string
        Birthday: DateTime
        }

    let alice : Person          // Error

---

## Everything must be initialized

    type Person = {
        Name: string
        Birthday: DateTime
        }

    let alice = {Name="Alice"}  // Error: Birthday is required

---

## Everything must be initialized

    type Person = {
        Name: string
        Birthday: DateTime
        }

    let alice = {Name="Alice"; Birthday=DateTime(1980,1,1)}  // OK

' everything must be initialized. big difference. 
' if you add a new property all code breaks until you fix it. that’s good.
' you can trust things to be properly initialized

***

# _Different philosophy_

---

## Different philosophy

<div class="fragment">

- C# historically comes from C-like approach

</div>

<div class="fragment">

- F# come from ML, a MetaLanguage for proving things

</div>

' different philosophy ML desgined pretty much as the same time as C. c# imperative, f# goal is predictable code (scientific)
' in OOP world you are not supposed to know behaviour of an object
' for performance you  might prefer mutability alright (array of customer) so there are use cases wher mutability if important, but most of the time given modern hardware and software and compiler optimization, predictability is preferrable over performance
' you dont write defensive code in f#
' that’s another reason why code is shorter
' in f# you should not throw for flow control

---

## Goal: Predictable code

<div class="fragment">

- Can you understand the code using only the information that you have *right in front of you?*

</div>

<div class="fragment">

- You're not allowed to delve into other parts of the codebase.

</div>

---

## Tricky question

    var x = 1;
    DoSomething(x);

    var y = "hello" + x;    // What value is y?

<div class="fragment">

    // The answer is "hello world".

</div>

---

## Tricky question

    function DoSomething (foo)  { x = "world"; }

    var x = 1;
    DoSomething(x);

    var y = "hello" + x;    

    // The code is actually JavaScript.

<div class="fragment">

    // Thanks to static typing, this can never happen in C#.

</div>

---

## Predictable language

- Variables should not be allowed to change their type

---

    // create two customers
    var cust1 = new Customer(99, "J Smith");
    var cust2 = new Customer(99, "J Smith");

    cust1 == cust2;     // true or false?

<div class="fragment">

    // You can't tell. Not predictable.

</div>

---

## Predictable language

- Variables should not be allowed to change their type
- *Objects with the same values should be equal by default.*

---

    // create a customer and an order
    var cust = new Customer(99, "J Smith");
    var order = new Order(99, "J Smith");

    cust.Equals(order);     // true or false?

<div class="fragment">

    // This is probably a bug.
    // Why are you attempting to compare an order to a customer?

</div>

---

## Predictable language

- Variables should not be allowed to change their type
- Objects with the same values should be equal by default.
- *Comparing objects of different types is a compile-time error.*

---

    // create a customer
    var cust = new Customer();

    Console.WriteLine(cust.Address.Country)  // what is the expected output?

<div class="fragment">

    // You can't tell. Not predictable.
    // What if Address is not always required?

</div>

---

## Predictable language

- Variables should not be allowed to change their type
- Objects with the same values should be equal by default.
- Comparing objects of different types is a compile-time error.
- *Objects must always be initialized to a valid state. Not doing so is a compile-time error.*

---

    // create a customer
    var cust = new Customer(99, "J Smith");

    // add it to a set
    var processedCustomers = new HashSet<Customer>();
    processedCustomers.Add(cust);

    // process it
    ProcessCustomer(cust);

    processedCustomers.Contains(cust);  // true or false?

<div class="fragment">

    // You can't tell. Not predictable.
    // If ProcessCustomer mutates the customer, it might change the hash

</div>

---

    // create a customer
    var cust = new ImmutableCustomer(99, "J Smith");

    // add it to a set
    var processedCustomers = new HashSet<ImmutableCustomer>();
    processedCustomers.Add(cust);

    // process it and return the changes
    var changedCustomer = ProcessCustomer(cust);

    processedCustomers.Contains(cust);  // true or false?

<div class="fragment">

    // true.
    // Immutability forces changed values to be returned explicitly.
    // Original value unchanged.

</div>

---

## Predictable language

- Variables should not be allowed to change their type
- Objects with the same values should be equal by default.
- Comparing objects of different types is a compile-time error.
- Objects must always be initialized to a valid state. Not doing so is a compile-time error.
- *Once created, objects and collections must be immutable.*

---

    // create a repository
    var repo = new CustomerRepository();

    // find a customer by id
    var customer = repo.GetById(42);

    Console.WriteLine(customer.Id); // what is the expected output?

<div class="fragment">

    // You can't tell. Not predictable.
    // What happens if the customer is missing?
    // Is the customer null or what?

</div>

---

    // create a repository
    var repo = new CustomerRepository();

    // find a customer by id
    var customerOrError = repo.GetById(42);

    // handle both cases
    if (customerOrError.IsCustomer)
        Console.WriteLine(customerOrError.Customer.Id);

    if (customerOrError.IsError)
        Console.WriteLine(customerOrError.ErrorMessage);

    // Instead, build error cases into the return type.

---

## Predictable language

- Variables should not be allowed to change their type
- Objects with the same values should be equal by default.
- Comparing objects of different types is a compile-time error.
- Objects must always be initialized to a valid state. Not doing so is a compile-time error.
- Once created, objects and collections must be immutable.
- *Missing data or errors must be made explicit. No nulls allowed.*

---

## Predictable language

- Variables should not be allowed to change their type
- Objects with the same values should be equal by default.
- Comparing objects of different types is a compile-time error.
- Objects must always be initialized to a valid state. Not doing so is a compile-time error.
- Once created, objects and collections are *generally* immutable.
- Missing data or errors are *generally* made explicit. *Nulls are a code smell*.

---

# Predictable language
## F# is not perfect. But conventions lead this way.

***

# _Functional first_

---

## Core principles of functional programming

<div class="fragment">

- _Functions_

</div>
<div class="fragment">

- _Composition_

</div>

<div class="fragment">

- _Parameterization_

</div>

---

# Principle
## Functions are things

<div class="fragment">

- Functions are standalone things

</div>

<div class="fragment">

- Hence, they are not attached to a class

</div>

---

<img src="images/function.png" class="nb"/>

---

<img src="images/same-keyword.png" class="nb"/>

---

<img src="images/function-as-output.png" class="nb"/>

---

<img src="images/function-as-input.png" class="nb"/>

---

<img src="images/function-as-parameter.png" class="nb"/>

---

- Functions can be used for inputs and outputs of other functions

<div class="fragment">

- From this simple foundation we can build **complex** things

</div>

---

# Principle
## Functions can be composed together

---

<img src="images/composition1.png" class="nb"/>

---

<img src="images/composition2.png" class="nb"/>

---

<img src="images/composition3.png" class="nb"/>

---

<img src="images/composition4.png" class="nb"/>

---

## Composition in F#

    let add1 x = x + 1
    let double x = x + x

    let add1_double = 
        add1 >> double

    let x = add1_double 5   // Outputs 12

<img src="images/composition5.png" class="nb"/>

---

## Nesting functions

    add1 5                    // = 6
    double (add1 5)           // = 12
    square (double (add1 5))  // = 144

    // Standard way of nesting function calls can be confusing if too deep

---

## Piping in F# (*|>*)

    5 |> add1                     // = 6
    5 |> add1 |> double           // = 12
    5 |> add1 |> double |> square // = 144

    // Pipe operator pipes a value through a set of functions 
    // in sequence and returns the resulting value

<div class="fragment">

<br/>
<br/>
<img src="images/piping.png" class="nb"/>

</div>

## Why we say F# is "functional first"

<div class="fragment">

- F# makes functional programming easy

</div>

<div class="fragment">

- C# makes FP possible
    - but it's awkward and not idiomatic

</div>

---

# Principle
## Parameterization

---

    let printList() = 
        for i in [1..10] do
            printfn "the number is %i"

<div class="fragment">

    // [1..10] is hard-coded data. Yuck!

</div>

---

    let printList aList = 
        for i in aList do
            printfn "the number is %i" i

<div class="fragment">

    // It's second nature to parameterize the data input
    // However...

</div>

---

    let printList aList = 
        for i in aList do
            printfn "the number is %i" i

    // Hard-coded behaviour. Yuck!
    // FPers would parameterize the action as well.

---

    let printList anAction aList = 
        for i in aList do
            anAction i
    
<div class="fragment">

    // We've decoupled the behavior from the data. 
    // Any list, any action!
</div>
<div class="fragment">

    // F# helps by making this trivial to do.
</div>
    
***

# Principle
## Algebraic type system

---

## F# types can be composed

- New types are build from smaller types using:
    - AND 
    - OR 
- Types are executable documentation

---

    type FruitSalad = {
        Apple: AppleVariety
        Banana: BananaVariety
        Cherry: CherryVariety
        }
    
    // FruidSalad = One each of Apple and Banana and Cherry
    // Example: pairs, tuples, records (not yet available in C#)

---

    type Snack =
        | Apple of AppleVariety
        | Banana of BananaVariety 
        | Cherry of CherryVariety
    
    // Snack = Apple or Banana or Cherry
    // Not available in C#

---

## We accept three forms of payment: Check, Cash, Card.

- For Cash we don't need any extra information
- For Checks we need a check number
- For Cards we need a card type and card number

How would you implement this?

---

    [lang=cs]
    // Possible C# implementation

    interface IPaymentMethod 
    {..}

    class Cash() : IPaymentMethod 
    {..}

    class Check(int checkNo): IPaymentMethod
    {..}

    class Card(string cardType, string cardNo) : IPaymentMethod 
    {..}

---

    [lang=fs]
    // Possible F# implementation

    type CheckNumber = int                      // primitive type
    type CardNumber = string                    // primitive type

    type CardType = Visa | Mastercard           // OR type
    type CreditCardInfo = CardType * CardNumber // AND type

    type PaymentMethod =                        // OR type
        | Cash
        | Check of CheckNumber                  // can you guess which payment 
        | Card of CreditCardInfo                // methods are accepted?

---

    type PaymentAmount = decimal                // primitive type
    type Currency = EUR | USD                   // OR type

    type Payment = {                            // final type built from many smaller types
        Amount : PaymentAmount
        Currency: Currency
        Method: PaymentMethod
        }
    
    let payment = {                             // usage example
            Amount = PaymentAmount 100.0;
            Currency = EUR;
            Method = Check 9912345
        }

---

    type CheckNumber = int                      
    type CardNumber = string                    

    type CardType = Visa | Mastercard           
    type CreditCardInfo = CardType * CardNumber 

    type PaymentMethod =                        
        | Cash
        | Check of CheckNumber                  
        | Card of CreditCardInfo                

    type PaymentAmount = decimal                
    type Currency = EUR | USD                   

    type Payment = {                            
        Amount : PaymentAmount
        Currency: Currency
        Method: PaymentMethod
        }

    // F# types are executable documentation

---

# Principle
## Interactivity demo (if time allows)

***

## Suggested reading

<img src="images/get-programming-with-fsharp.jpg" width=25% align=center class="nb"/><img src="images/real-world-functional-programming.jpg" width=25% align=center class="nb"/><img src="images/domain-modeling-made-functional.jpg" width=26% class="nb"/>

---

# Getting started with F#
## Start here

- Official F# Guide: https://docs.microsoft.com/en-us/dotnet/fsharp/
- F# Foundation: https://fsharp.org/
- F# for fun and profit: https://fsharpforfunandprofit.com

***

# _<span style="font-weight:300">Thank you</span><br/>_

<br/><br/><br/><br/><br/><br/>

**Nicola Iarocci**

Software Craftsman, MVP<br/>
[nicolaiarocci.com](https://nicolaiarocci.com) | [@nicolaiarocci](https://twitter.com/nicolaiarocci)
