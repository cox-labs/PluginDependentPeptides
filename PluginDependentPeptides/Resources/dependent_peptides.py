"""
Dependent peptides can be extracted from the `allPeptides.txt` table
and are annotated using the `Raw files table`.
"""
import sys
from perseuspy.dependent_peptides import run_dependent_peptides_from_parameters

_, paramfile, outfile = sys.argv
run_dependent_peptides_from_parameters(paramfile, outfile)
