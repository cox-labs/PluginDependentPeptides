# PluginDependentPeptides

Perseus plugin for importing dependent peptide search results
from [MaxQuant](https://www.biochem.mpg.de/5111795/maxquant).
Requires [PluginInterop](https://github.com/cox-labs/PluginInterop)
and [Python](https://www.python.org/) with
[perseuspy](https://www.github.com/cox-labs/perseuspy) installed.

For questions and bug reports please use the [issue](https://github.com/cox-labs/plugindependentpeptides/issues) system.

## Installation

`PluginDependentPeptides` can be downloaded from the
Perseus [plugin store](http://www.coxdocs.org/doku.php?id=perseus:user:plugins:store#available_plugins), along side its dependency `PluginInterop`.

For latests builds you require to have [Visual Studio](https://www.visualstudio.com/downloads/).

## Verify your installation

1. Download small example files for the [`allPeptides.txt` table](https://raw.githubusercontent.com/cox-labs/perseuspy/master/perseuspy/test/allPeptides.txt.sample)
   and the [Raw files table](https://raw.githubusercontent.com/cox-labs/perseuspy/master/perseuspy/test/rawFilesTable.txt.sample).
2. Run the `Dependent Peptides` upload in Perseus.

## Frequently asked questions

Take a look at the [issues](https://github.com/cox-labs/PluginDependentPeptides/issues?utf8=%E2%9C%93&q=is%3Aissue%20) and
see if your question was already answered. Additionally you can look for help in the [Perseus Help](https://groups.google.com/forum/#!forum/perseus-list) google group.

1. **Where can I find the `rawFilesTable.txt` file?** First load your project in MaxQuant.
   Now in the 'Raw files' tab right click the table and choose `Plain matrix export...`.
   ![rawFilesTable.txt](/img/rawfilestable.png)

## Plugin development guide

You can find a plugin development guide on [github](https://github.com/cox-labs/PluginTutorial).
