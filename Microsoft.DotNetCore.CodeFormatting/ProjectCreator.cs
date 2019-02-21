using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Text;

namespace Microsoft.DotNetCore.CodeFormatting
{
    public class ProjectCreator
    {
        private readonly char[] s_folderSplitters = new char[] { Path.DirectorySeparatorChar };

        public ProjectInfo Create(string projectName, string language, List<string> documents)
        {
            var projectId = ProjectId.CreateNewId();
            var baseDirectory = Path.GetDirectoryName(Path.GetFullPath(projectName));

            List<DocumentInfo> docsList = new List<DocumentInfo>();

            foreach (var currentDocument in documents)
            {
                StringBuilder absolutePath = new StringBuilder(baseDirectory);
                absolutePath.AppendFormat(@"\" + currentDocument);

                DocumentInfo document = DocumentInfo.Create(
                    DocumentId.CreateNewId(projectId),
                    name: currentDocument,
                    folders: GetFolders(baseDirectory),
                    sourceCodeKind: SourceCodeKind.Regular,
                    loader: new FileTextLoader(absolutePath.ToString(), Encoding.Default),
                    filePath: absolutePath.ToString());

                docsList.Add(document);
            }

            var projectInfo = ProjectInfo.Create(
                projectId,
                VersionStamp.Create(),
                projectName,
                "<anonymous>",
                documents: docsList,
                language: language,
                filePath: projectName);
            return projectInfo;

        }

        private IList<string> GetFolders(string path)
        {
            var directory = Path.GetDirectoryName(path);
            if (string.IsNullOrEmpty(directory))
            {
                return ImmutableArray.Create<string>();
            }
            else
            {
                return directory.Split(s_folderSplitters, StringSplitOptions.RemoveEmptyEntries).ToImmutableArray();
            }
        }
    }
}
