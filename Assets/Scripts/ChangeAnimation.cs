using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    private Animator anim;   

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void RunForwardAnimation()
    {
        anim.Play("RunForward", -1, 0f);
    }

    public void RunBackwardAnimation()
    {
        anim.Play("RunBackward", -1, 0f);
    }

    public void DeathAnimation()
    {
        anim.Play("Death", -1, 0f);
    }

    public void Attack1Animation()
    {
        anim.Play("Attack1", -1, 0f);
    }

    public void TakeDamageAnimation()
    {
        anim.Play("TakeDamage", -1, 0f);
    }

}
