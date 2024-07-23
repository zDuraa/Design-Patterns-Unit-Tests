﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            _state = state;
        }

        public void request()
        {
            _state.StateSpecificBehavior(this);
        }
        public void setState(IState state)
        {
            _state = state;
        }
    }
}
