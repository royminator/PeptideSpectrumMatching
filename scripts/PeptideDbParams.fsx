#r "nuget: BioFSharp.Mz, 0.1.5-beta"
#r "nuget: Newtonsoft.Json, 12.0.3"
#r "nuget: ProteomIQon, 0.0.5"

open BioFSharp.Mz.SearchDB
open Newtonsoft.Json
open ProteomIQon

let peptideDBParams: Dto.PeptideDBParams = 
    {
    Name                        = "Test"
    ParseProteinIDRegexPattern  = "id"
    Protease                    = Protease.Trypsin
    MinMissedCleavages          = 0
    MaxMissedCleavages          = 2
    MaxMass                     = 15000.0
    MinPepLength                = 4
    MaxPepLength                = 65
    IsotopicMod                 = [IsotopicMod.N15]
    MassMode                    = MassMode.Monoisotopic
    FixedMods                   = []
    VariableMods                = [Modification.Oxidation'Met'; Modification.Acetylation'ProtNTerm']
    VarModThreshold             = 4
    }

let serialized = 
    peptideDBParams
    |> JsonConvert.SerializeObject

System.IO.File.WriteAllText("config/peptideDbParams.json", serialized)
