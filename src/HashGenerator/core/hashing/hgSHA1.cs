﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.core.hashing
{
    internal sealed class hgSHA1 : hgHashAlgorithm
    {
        public String ComputeHash(String filename)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                using (FileStream stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }
    }
}
