﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
    public abstract class TV : ISwitchable
    {
        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
