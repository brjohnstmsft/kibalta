#load @"..\.paket\load\netstandard2.0\main.group.fsx"
#load "Kibalta.fs"
 
open Microsoft.Azure.Search
open System
open Microsoft.Spatial
open Filters

type RapBattle = {
    id : string
    title : string
    rating : Nullable<int>
    price : Nullable<float>
    artist : string
    releaseDate : Nullable<DateTimeOffset>
    tags : string array
    email : string
    location : GeographyPoint
    hidden : Nullable<int>
}

let searchMyIndex =
    let client = makeClient "azs-brjohnst-weu" "88475F66DA0798B65326F065442D7A46"
    doSearch<RapBattle> "rapbattles" client

let myQuery =
    azureSearch {
        filter (where "location" Ne null)
        sort [ByDistance ("location", -123.0, 49.0, Ascending)]
    }

let test () =
    let results = searchMyIndex myQuery
    let documents, _, _ = results.Result
    documents
