﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public static class GameLost
    {
        public static void Lost()
        { UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene"); return; }
    }
}
