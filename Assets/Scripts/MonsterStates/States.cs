using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace States{

	public class Aggressive : State_rules
    {
        public override void state_update(Action_state_rules[] substates)
        {
            
            int random_number = Random.Range(0, substates.Length);
            substates[random_number].animate();
        }
    }

    public class Ranged_aggresive : State_rules
    {
        public override void state_update(Action_state_rules[] substates)
        {

        }
    }

    public class Defensive : State_rules
    {
        public override void state_update(Action_state_rules[] substates)
        {

        }
    }

    public class Passive : State_rules
    {
        public override void state_update(Action_state_rules[] substates)
        {

        }
    }

    public class S_aggressive : State_rules
    {
        public override void state_update(Action_state_rules[] substates)
        {

        }
    }

    public class S_defensive : State_rules
    {
        public override void state_update(Action_state_rules[] substates)
        {

        }
    }
}
