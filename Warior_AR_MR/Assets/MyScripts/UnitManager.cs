using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour 
{
	public static UnitController player, enemy;

	public void SetTargetPlayer(UnitController unit) 
	{
		player = unit;
	}
	public void SetTargetEnemy(UnitController unit)
	{
		enemy = unit;
	}

	public void SertNullPlayer() 
	{
		player = null;
	}
	public void SertNullEnemy()
	{
		enemy = null;
	}

    //private void Update()
    //{
    //    player.LookAt(enemy);

    //    enemy.LookAt(player);
    //}
}
