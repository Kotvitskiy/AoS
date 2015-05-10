﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace CastleWar.UI
{
    class HPBar : Entity
    {
        private int _hp = 0;
        private int _team = 0;
        public HPBar(float x, float y, int hp, int team, int type)
        {
            if (type == 0)
            {
                X = x - 8;
                Y = y - 30;
                SetGraphic(new Text(10));
            }
            else if (type == 1)
            {
                X = x - 16;
                Y = y - 60;
                SetGraphic(new Text(16));
            }
            else
            {
                X = x - 10;
                Y = y - 40;
                SetGraphic(new Text(14));
            }
            _hp = hp;
            _team = team;
            
            ((Text)Graphic).OutlineColor = Color.Black;
            ((Text)Graphic).OutlineThickness = 2;
            ((Text)Graphic).String = ((int)_hp).ToString();
            if (_team == Team.Blu) ((Text)Graphic).Color = Color.Cyan;
            else ((Text)Graphic).Color = Color.Red;
            LifeSpan = Global.HPBarsUpdateRate;
        }
    }
}