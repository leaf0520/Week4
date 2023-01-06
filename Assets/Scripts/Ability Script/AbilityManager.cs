using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AbilityManager : MonoBehaviour
{
    [Tooltip("The ability to be activated when actionkey is pressed.")]
    public Ability ability;
    [Tooltip("The key to press to activate ability")]
    public InputActionReference actionKey;
    private float cooldownTime;
    private float activeTime;
    private AbilityState state = AbilityState.READY;
    private bool doPress = false;

    void Start()
    {
        activeTime = ability.activeTime;
        cooldownTime = ability.cooldownTime;
    }

    private void OnEnable()
    {
        actionKey.action.performed += _ =>
        {
            doPress = true;
        };
    }

    void Update()
    {
        switch (state)
        {
            case AbilityState.READY:
                //activate ability once if actionkey is pressed, then change to active state
                if (doPress)
                {
                    doPress = false;
                    ability.Activate(gameObject);
                    state = AbilityState.ACTIVE;
                }
                break;
            case AbilityState.ACTIVE:
                //tick down active time, then change to cooldown state
                if (activeTime > 0) activeTime -= Time.deltaTime;
                else
                {
                    ability.BeginCooldown(gameObject);
                    activeTime = ability.activeTime;
                    state = AbilityState.ONCOOLDOWN;
                }
                break;
            case AbilityState.ONCOOLDOWN:
                //tick down cooldown time, then change back to ready state
                if (cooldownTime > 0) cooldownTime -= Time.deltaTime;
                else
                {
                    cooldownTime = ability.cooldownTime;
                    state = AbilityState.READY;
                }
                break;
        }
    }

    enum AbilityState
    {
        READY,
        ACTIVE,
        ONCOOLDOWN
    }
}
