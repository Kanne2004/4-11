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
        anim = GetComponent<Animator>();
        move = GetComponent<Move>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && cooldownTimer > attackCD && move.canAttack())
        {
            Attack();
        }
        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[FindFireball()].transform.position = firePoint.position;
        fireballs[FindFireball()].GetComponent<ProjectTile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private int FindFireball()
    {
        for (int i = 0; i < fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}
