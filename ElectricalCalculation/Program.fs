module Program

let ``Коэффициент спроса`` = 1.0
let ``Uном`` = 230.0
let ``CosF`` = 1.0
let ``Элементы цепи`` =
    [ 100.0; 300.0; 1200; 300.0 ]
    |> List.map(fun x -> x / 1000.0)
//    [ for i in 0..100 -> Random().Next(100, 2500) |> float]
let ``Pуст`` = List.sum ``Элементы цепи``
let ``Pр1`` = ``Pуст`` * ``Коэффициент спроса``
let ``Qр1`` = ``Pр1`` * acos CosF
let ``Sр1`` = sqrt(``Pр1`` ** 2.0 + ``Qр1`` ** 2.0)

let ``Iр`` uNom =
    let U = uNom / 1000.0
    match uNom with
    | 230.0 -> ``Pр1`` / (U * ``CosF``)
    | 400.0 -> ``Pр1`` / (U * ``CosF`` * sqrt 3.0)
    | _     -> 0.0
    
let Result = Iр 400.0
    