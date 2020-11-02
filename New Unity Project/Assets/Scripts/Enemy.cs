using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamagable
{
    protected float speed;
    protected int health;
    [SerializeField] protected Weapon weapon;
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();
        speed = .5f;
        health = 100;

        weapon.damageBonus = 10;
    }

    protected abstract void TakeDamage(int amount);

    protected abstract void Attack();

    // Update is called once per frame
    void Update()
    {
        
    }

    void IDamagable.TakeDamage(int amount)
    {
        throw new System.NotImplementedException();
    }
}
