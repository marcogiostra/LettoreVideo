using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettoreVideo.Classi
{
    public static class PathHelper
    {
        #region f()_GESTIONE PATH RELATIVO
        public static string GetRelativeOrDriveTrimmed(string foundPath)
        {
            string appPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            foundPath = Path.GetFullPath(foundPath);

            string foundRoot = Path.GetPathRoot(foundPath);
            string appRoot = Path.GetPathRoot(appPath);

            // CASE 5: UNC -> prefix @ and return full UNC
            if (foundPath.StartsWith("\\\\"))
                return "@" + foundPath;

            // CASE 4: different drive -> return full path
            if (!string.Equals(foundRoot, appRoot, StringComparison.OrdinalIgnoreCase))
                return foundPath;

            // CASE 3: same directory as the app
            if (string.Equals(Path.GetDirectoryName(foundPath)?.TrimEnd('\\'),
                              appPath.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase))
            {
                return "#" + Path.GetFileName(foundPath);
            }

            // CASE 2: subdirectory inside the app path
            if (foundPath.StartsWith(appPath, StringComparison.OrdinalIgnoreCase))
            {
                string relative = foundPath.Substring(appPath.Length)
                                           .TrimStart('\\');
                return "\\" + relative;
            }

            // CASE 1: same drive but OUTSIDE app path
            // return relative to drive root (no prefix)
            return foundPath.Substring(foundRoot.Length).TrimStart('\\');
        }


        public static string RestoreFullPath(string reduced)
        {
            string appPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            string appRoot = Path.GetPathRoot(appPath);

            if (string.IsNullOrWhiteSpace(reduced))
                return appPath;

            // CASE 5: UNC
            if (reduced.StartsWith("@"))
                return reduced.Substring(1);

            // CASE 3: same directory as the app
            if (reduced.StartsWith("#"))
                return Path.Combine(appPath, reduced.Substring(1));

            // CASE 2: inside app (subdirectory)
            if (reduced.StartsWith("\\"))
                return Path.Combine(appPath, reduced.TrimStart('\\'));

            // CASE 4: absolute (drive or UNC)
            if (Path.IsPathRooted(reduced))
                return reduced;

            // CASE 1: same drive, outside app → relative to drive root
            return Path.Combine(appRoot, reduced);
        }

        #endregion f()_GESTIONE PATH RELATIVO
    }
}
