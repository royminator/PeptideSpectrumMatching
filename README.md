# PeptideSpectrumMatching

Tinkerings with ProteomIQon with the goal of finding peptide matches in a theoretical mass spectrum given an observed tandem mass spec run

## Installation

Installation was a bit cumbersome. The [ProteomIQon installation build instructions](https://csbiology.github.io/ProteomIQon/develop/How_to_build_binaries_or_packages.html)
were a bit vague on how to actually install the dotnet tool.

```
sudo sh build.sh -t BuildProj
```

then type in the name of the project you want to build. However, installing it as a global tool didn't work for me therefore I had to run from bin folder.

## Run

Run scripts from project root

```
// Generate peptide db generation parameters
dotnet fsi scripts/PeptideDbParams.fsx

// Create peptide db
ProteomIQon/src/PeptideDB/bin/Release/net5.0/ProteomIQon.PeptideDB -i /var/data/proteins/prot_274.fasta -o db -p config/peptideDbParams.json
```
