using System.IO;
using System.Text;
using BaseLib.Graphic;
using BaseLibS.Graph;
using BaseLibS.Param;
using Path = System.IO.Path;

namespace PluginDependentPeptides
{
    public class Upload : PluginInterop.MatrixUpload
    {
        public override string Name => "Dependent peptides";
        public override string Description => "Create the dependent peptides table from the allPeptides.txt and experimentalDesign.txt";

        public override Bitmap2 DisplayImage => GraphUtils.ToBitmap2(Properties.Resources.dependent_peptides_icon);

        protected override string GetCodeFile(Parameters param)
        {
            byte[] code = (byte[])Properties.Resources.ResourceManager.GetObject("dependent_peptides");
            var codeFile = Path.GetTempFileName();
            File.WriteAllText(codeFile, Encoding.Default.GetString(code, 0, code.Length - 1));
            return codeFile;
        }

        protected override bool TryFindExecutable(out string path)
        {
            return PluginInterop.Python.Utils.TryFindPythonExecutable(out path);
        }

        protected override Parameter[] SpecificParameters(ref string errString)
        {
            return new Parameter[]
            {
                new FileParam("allPeptides.txt"), 
                new FileParam("Raw files table"), 
            };
        }
    }
}