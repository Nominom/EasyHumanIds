namespace EasyHumanIds

open RandomWords

module HumanIds =

    let private takeOneRandom (rnd : System.Random) (list : _ array)  = 
        list.[rnd.Next(0, list.Length)]

    let Generate (rnd : System.Random) =
        let adjective = takeOneRandom rnd RandomWords.adjectives 
        let noun = takeOneRandom rnd RandomWords.nouns 
        adjective + "-" + noun
