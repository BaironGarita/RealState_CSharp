﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
    }
}
