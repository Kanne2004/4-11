using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorExample : MonoBehaviour
{
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator.Play("AnimationStateName");
    }
}
