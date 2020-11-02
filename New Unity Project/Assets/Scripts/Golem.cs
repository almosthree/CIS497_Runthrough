using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;
    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
    }
    protected override void Attack()
    {
        Debug.Log("Attack");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void TakeDamage(int amount)
    {
        Debug.Log("You took " + amount + "amounts of damage");
    }
}
