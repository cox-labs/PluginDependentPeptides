"""
Dependent peptides can be extracted from the `allPeptides.txt` table
and are annotated using the `Raw files table`.
"""
try:
	from perseuspy import __version__
except ImportError:
	__version__ = "0.1.0"
expected_version = "0.1.3"
if __version__ != expected_version:
	print("Found unsupported `perseuspy` version {}".format(__version__))
	print("Make sure to install `perseuspy` version {}".format(expected_version))
import sys
from perseuspy.dependent_peptides import run_dependent_peptides_from_parameters

_, paramfile, outfile = sys.argv
run_dependent_peptides_from_parameters(paramfile, outfile)
