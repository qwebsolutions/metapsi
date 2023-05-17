using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public static class RelativePath
    {
        /// <summary>
        /// Gets a full path where the git root path (development) has priority over the current execution path searched upfolder (release)
        /// </summary>
        /// <param name="startingPath">Start from this path and try to figure out where you are</param>
        /// <param name="relativePath">After you know where you are, you know where to go</param>
        /// <returns></returns>
        public static string GetFullPath(string startingPath, string relativePath)
        {
            var gitRootPath = GetGitBasePath(startingPath);
            if (!string.IsNullOrEmpty(gitRootPath))
            {
                string fullPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(gitRootPath, relativePath));
                if (System.IO.File.Exists(fullPath))
                    return fullPath;
            }

            return RelativePath.SearchUpfolder(startingPath, relativePath);
        }

        public static string FromExeFolder(string relativeToExeFolder)
        {
            string exeFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string fullPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(exeFolder, relativeToExeFolder));
            return fullPath;
        }

        public static string FromGitRoot(params string[] relativeToGitFolder)
        {
            var gitRootPath = GetGitBasePath(".");

            if (string.IsNullOrWhiteSpace(gitRootPath))
                throw new Exception("Not a git repository!");


            List<string> pathSegments = new List<string>();
            pathSegments.Add(gitRootPath);
            pathSegments.AddRange(relativeToGitFolder);

            string fullPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(pathSegments.ToArray()));
            return fullPath;
        }

        public static string GetAlternatePath(string relativeToExeFolder, string relativeToGitRoot)
        {
            var gitRootPath = GetGitBasePath(".");
            if (!string.IsNullOrEmpty(gitRootPath))
            {
                string fullPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(gitRootPath, relativeToGitRoot));
                return fullPath;
            }
            else
            {
                string exeFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                string fullPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(exeFolder, relativeToExeFolder));
                return fullPath;
            }
        }

        public enum From
        {
            EntryPath,
            CurrentDir
        }

        public static string SearchUpfolder(From from, string relativePath)
        {
            if (System.IO.Path.IsPathRooted(relativePath))
                return relativePath;

            string startingFromDirectory = System.IO.Directory.GetCurrentDirectory();

            if (from == From.EntryPath)
            {
                startingFromDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            }

            return SearchUpfolder(startingFromDirectory, relativePath);
        }

        /// <summary>
        /// Searches upfolder for a path that ends with relativePath. 
        /// </summary>
        /// <param name="startingBasePath"></param>
        /// <param name="relativePath"></param>
        /// <returns>If found, full path is returned. Otherwise, empty string.
        /// </returns>
        public static string SearchUpfolder(string startingBasePath, string relativePath)
        {
            string currentBasePath = startingBasePath; // System.IO.Path.Combine(startingBasePath, relativePath);
            while (true)
            {
                string combinedPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(currentBasePath, relativePath));

                if (System.IO.File.Exists(combinedPath))
                {
                    return combinedPath;
                }

                if(System.IO.Directory.Exists(combinedPath))
                {
                    return combinedPath;
                }

                if (string.IsNullOrWhiteSpace(currentBasePath))
                    return string.Empty;

                string parentPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(currentBasePath, ".."));
                if (currentBasePath == parentPath)
                    return string.Empty;

                currentBasePath = parentPath;
            }
        }

        public static string GetGitBasePath(string fromInnerPath)
        {
            string gitRootFolder = SearchUpfolder(fromInnerPath, ".git");
            if (!string.IsNullOrEmpty(gitRootFolder))
                return System.IO.Path.GetFullPath(System.IO.Path.Combine(gitRootFolder, ".."));

            return string.Empty;
        }
    }
}