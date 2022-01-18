open System.Text


let five = 5
let seven = 7 

let cube x = x*x*x

//five |> cube |> printfn "%i"
//seven |> cube |> printfn "%i"


// Nombre a virgule 
//let inline (>=<) a (b,c) = a >= b && a<= c


let interestRate (balance: decimal): single = 
    match balance with 
    | i when i < 0m -> 3.213f
    | i when 0m <= i && i< 1000m -> 0.5f
    | i when 1000m <= i && i< 5000m -> 1.621f
    | _ -> 2.475f

        
let interest (balance: decimal) : decimal =
    System.Convert.ToDecimal(interestRate (balance))*balance /100m

let annualBalanceUpdate(balance: decimal): decimal =
    balance + interest(balance)
    
//let amountToDonate(balance: decimal) (taxFreePercentage: float): int =

//let message(text: char[]): string[] =
 
 


//------------ EXERCICE BASKET --------------------

type Coach = {Name:string; FormerPlayer:bool}
type Stats = {Win:int; Loose:int}
type Team = {Name:string; Coach:Coach;Stats :Stats}

let  createCoach(name:string, player :bool ): Coach =
    printfn "{ Name : %s ; FormerPlayer : %b }" name player
 
    {Name = name;FormerPlayer = player}

let  createStats(win:int, loose :int ): Stats =
    printfn "{ win : %i ; loose : %i }" win loose
 
    {Win = win;Loose= loose}    

let createTeam(name: string, coach: Coach, record: Stats) : Team =
    printfn "{Name : %s" name
    printfn " Coach = { Nom = %s ; FormerPlayer = %b }" coach.Name coach.FormerPlayer
    printfn " Stats = { Victoires = %i ; Défaites = %i } }" record.Win record.Loose
    {Name = name; Coach = coach; Stats = record}

let replaceCoach(equipe:Team, coach:Coach) : Team =
    printfn "{Name : %s" equipe.Name
    printfn " Coach = { Nom = %s ; FormerPlayer = %b }" coach.Name coach.FormerPlayer
    printfn " Stats = { Victoires = %i ; Défaites = %i } }" equipe.Stats.Win equipe.Stats.Loose
    {Name = equipe.Name; Coach = coach ; Stats = equipe.Stats}

let isSameTeam(equipe1:Team,equipe2:Team) : bool =
    equipe1.Coach =equipe2.Coach && equipe1.Name = equipe2.Name

let rootForTeam(equipe:Team): bool =
    match equipe with 
    | equipe when equipe.Coach.Name ="Gregg Popovich"-> true
    | equipe when equipe.Coach.FormerPlayer =true -> true
    | equipe when equipe.Name = "Chicago Bulls" -> true
    | equipe when equipe.Stats.Win >= 60 -> true
    | equipe when equipe.Stats.Win < equipe.Stats.Loose -> true
    | _ -> false




let coach1 = createCoach("Larry Bird", false)
let record1 = createStats(25,24)
let team1 = createTeam("Indiana Pacers",coach1,record1) 
let newCoach1 = createCoach("Isiah Thomas", true)
let team11 = replaceCoach(team1,newCoach1)

let coach2 = createCoach("Larry Bird", true)
let record2 = createStats(58,24)
let team2 = createTeam("KarminCorp",coach2,record2) 
let newCoach2 = createCoach("Isiah Thomas", true)
let team21 = replaceCoach(team2,newCoach2)
isSameTeam(team1,team2) |> printfn("%b")
rootForTeam(team1) |> printfn("%b")



//------------ EXERCICE Saint Valentin --------------------


type Approbation =
    | Oui
    | Non
    | Bof 

type Cuisine =
    | Coréen
    | Turc

type Genre =
    | Crime
    | Horreur
    | Romance
    | Thriller

type Activity =
    | BoardGame
    | Chill
    | Film of genre : Genre
    | Restaurant of cuisine :Cuisine
    | Walk of lenght :int 

let film = Film(Horreur)


let rateActivity (activity:Activity): Approbation =
    match activity with
        | BoardGame -> Non
        | Chill -> Non
        | Film film when Genre.Romance = Romance -> Oui
        //| Film film when  != Romance -> Non
        | Restaurant restaurant when Cuisine.Coréen = Coréen -> Oui
        | Restaurant restaurant when Cuisine.Turc = Turc -> Bof
        | Walk walk when walk < 3 -> Oui
        | Walk walk when walk < 5 -> Bof
        | Walk walk when walk >=5 -> Non
        | _ -> Non


//------------ EXERCICE Magazin --------------------



let lastWeek =
    [|0;2;5;3;7;8|]

let visiteHier(liste:int array): int =
    liste[liste.Length-2]

let total(liste:int array): int =
    Array.sum(liste)

let  joursSansVisite(liste:int array):bool = 
    Array.exists ((=) 0) liste

let incrementsTodaysCount(liste:int array, tdy : int):int array =
    Array.append liste [|tdy|]




visiteHier(lastWeek) |> printfn("%i")
total(lastWeek) |> printfn("%i")
joursSansVisite(lastWeek) |> printfn("%b")
let week = incrementsTodaysCount(lastWeek,1)
total(week) |> printfn("%i")


