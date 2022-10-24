using System;

namespace Blogz
{
    internal class Garbage
    {
        public string ExtractPath(string _OldPath)
        {
            string NewPath = "";
            Boolean FoundPath = false;
            for (int i = 0; i < _OldPath.Length; i++)
            {
                if (!FoundPath)
                {
                    if (_OldPath[i] == 'f' && _OldPath[i + 1] == 'i' && _OldPath[i + 2] == 'l' && _OldPath[i + 3] == 'e' && _OldPath[i + 4] == ':')
                    {
                        i += 6;
                        FoundPath = true;
                    }
                }
                else
                {
                    NewPath += _OldPath[i];
                }
            }
            return NewPath;
        }
    }
}
