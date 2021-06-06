using UnityEngine.Events;
using UnityEngine;

public class Combat : MonoBehaviour
{
	[SerializeField] int damage = 1;
	[SerializeField] float cooldown = 1f;

	float coolDownTimer;

	public UnityEvent OnAttack;
	
	private void Update ()
	{
		if (coolDownTimer > 0)
			coolDownTimer -= Time.deltaTime;
	}

	public void Attack(Health health)
	{
		if (coolDownTimer <= 0) 
		{
			OnAttack.Invoke();
			health.TakeDamage(damage);
			coolDownTimer = cooldown;
		}
	}
}
