using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
	[SerializeField] protected Combat combat;
	public Health health;

	protected bool isDead = false;

	void Start ()
	{
		
	}
	
	protected virtual void Update ()
	{
		if (isDead)
		{
			if (health.curHealth == 0) Die();
		}
	}

	protected virtual void Die()
	{
		isDead = true;
	}

    internal void LookAt(UnitController enemy)
    {
        throw new NotImplementedException();
    }
}
