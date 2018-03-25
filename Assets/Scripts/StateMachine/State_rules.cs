using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State_rules : MonoBehaviour
{
    public abstract void state_update(Action_state_rules[] substates);
}

public abstract class Action_state_rules : MonoBehaviour
{
    public abstract void animate();
    public abstract void exit_state();
}
