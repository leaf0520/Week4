using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpeedUp", menuName = "Speed Up")]
public class SpeedUp : Ability
{
    [SerializeField]
    [Range(1f,5f)]
    private float moveSpeedMultiplier = 1.5f;

    [SerializeField]
    [Range(1f, 5f)]
    private float runSpeedMultiplier = 2.5f;

    public override void Activate(GameObject parent)
    {
        StarterAssets.ThirdPersonController cont = parent.GetComponent<StarterAssets.ThirdPersonController>();
        cont.MoveSpeed *= moveSpeedMultiplier;
        cont.SprintSpeed *= runSpeedMultiplier;
    }

    //undo speed multipliers
    public override void BeginCooldown(GameObject parent)
    {
        StarterAssets.ThirdPersonController cont = parent.GetComponent<StarterAssets.ThirdPersonController>();
        cont.MoveSpeed /= moveSpeedMultiplier;
        cont.SprintSpeed /= runSpeedMultiplier;
    }
}
