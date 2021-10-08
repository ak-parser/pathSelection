using System;
using System.Collections.Generic;
using System.Text;

namespace PathSelect
{
    class PathOperation
    {
        public static string FileNameWithoutExtencion(string path)
        {
            if (path.IndexOf('\\') == -1 || path.IndexOf('.') == -1)
                throw new ArgumentException("Path is incorrect");

            int position = path.LastIndexOf('\\') + 1;
            return path.Substring(position, path.LastIndexOf('.') - position);
        }

        public static string RootFoulderName(string path)
        {
            if (path.IndexOf(":\\") == -1 || path.IndexOf('\\') == -1)
                throw new ArgumentException("Path is incorrect");

            int position = path.IndexOf(":\\") + 2;
            return path.Substring(position, path.IndexOf("\\", position) - position);
        }
    }
}
