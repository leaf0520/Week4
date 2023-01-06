using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : ScriptableObject
{
    public new string name;
    public float cooldownTime;
    public float activeTime;

    public virtual void Activate(GameObject parent) { Debug.Log($" Skill {name} activated!"); }
    
    //deactivate ability, undo changes on ability activation
    public virtual void BeginCooldown(GameObject parent) { Debug.Log($"Skill {name} began cooldown"); }
}
