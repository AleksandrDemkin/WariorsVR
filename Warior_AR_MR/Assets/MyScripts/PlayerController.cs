using System.Collections;
using UnityEngine;
using Vuforia;

public class PlayerController : UnitController, IVirtualButtonEventHandler
{
    private VirtualButtonBehaviour virtualButton;

    void Start () 
	{
        virtualButton = gameObject.transform.parent.GetComponentInChildren<VirtualButtonBehaviour>();
        virtualButton.RegisterEventHandler(this);

    }

   

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (!isDead && UnitManager.enemy != null) 
        {
            combat.Attack(UnitManager.enemy.health);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

    protected override void Die()
    {
        base.Die();
        UnitManager.enemy = null;
    }


}
