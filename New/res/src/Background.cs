﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace New.res.src
{
    class Background : Entity
    {
        public Background()
        {
            SetGraphic(new Image(@"background.png"));
        }
    }
}
