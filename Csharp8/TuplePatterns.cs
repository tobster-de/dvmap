using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class TuplePatterns
    {
        public State State { get; private set; } = State.NotRunning;

        public void SwitchState(Transition transition)
        {
            switch (State, transition)
            {
                case (State.Running, Transition.Suspend):
                    State = State.Suspended;
                    break;
                case (State.Suspended, Transition.Resume):
                    State = State.Running;
                    break;
                case (State.Suspended, Transition.Terminate):
                    State = State.NotRunning;
                    break;
                case (State.NotRunning, Transition.Activate):
                    State = State.Running;
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }
    }

    internal enum Transition
    {
        Suspend,
        Resume,
        Terminate,
        Activate
    }

    internal enum State
    {
        Running,
        Suspended,
        NotRunning
    }
}
