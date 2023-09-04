using System;
using System.Collections.Generic;

using R5T.T0172;


namespace R5T.L0058
{
    public class PairedAssemblyXmlDocumentionFilePaths
    {
        /// <summary>
        /// Assembly file-documentation file path pairs.
        /// </summary>
        public Dictionary<IAssemblyFilePath, IDocumentationXmlFilePath> PairedFilePaths { get; set; }

        /// <summary>
        /// Assembly file paths for assemblies without paired documentation file path pairs.
        /// </summary>
        public HashSet<IAssemblyFilePath> UnpairedAssemblyFilePaths { get; set; }
    }
}
