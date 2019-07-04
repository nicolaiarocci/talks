// Learn more about F# at http://fsharp.org

open System

type CheckNumber = int                      // primitive type
type CardNumber = string

type CardType = Visa | Mastercard           // OR type
type CreditCardInfo = CardType * CardNumber // AND type

type PaymentMethod =                        // OR type
    | Cash
    | Check of CheckNumber
    | Card of CreditCardInfo

type PaymentAmount = decimal 
type Currency = EUR | USD                   // OR type

type Payment = {
    Amount: PaymentAmount
    Currency: Currency
    Method: PaymentMethod
    }
    

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let p = {
        Amount = PaymentAmount 100.0;
        Currency = EUR;
        Method = Check 9912345
    }

    0 // return an integer exit code
