using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1attack : MonoBehaviour
{
    [SerializeField] private float attackCD;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;
    private Animator anim;
    private Move move;
    private float cooldownTimer = Mathf.Infinity;
    // Update is called once per frame
    private void Awake()
    {
        move = GetComponent<Move>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && cooldownTimer > attackCD && move.canAttack())
        {
            Attack();
        }
        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[0].transform.position = firePoint.position;
        fireballs[0].GetComponent<ProjectTile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
}
