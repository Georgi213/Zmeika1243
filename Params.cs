﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika.Koršun
{
    public class Params
    {
        private string resourcesFoler;

        public Params()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StringComparison.Ordinal); // Получить индекс папки bin

            string binFolder = Directory.GetCurrentDirectory().ToString().Substring(0, ind).ToString(); //Путь до указанной d инкесе папки

            resourcesFoler = binFolder + "resources\\";
        }
        public string GetResourceFolder()
        {
            return resourcesFoler;
        }
    }
}
