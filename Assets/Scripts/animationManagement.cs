using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationManagement : MonoBehaviour
{
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimScale()
    {
        Anim.Play("Scale", -1, 0f);
        Anim.speed = 1f;
    }
    public void AnimRestore()
    {
        Anim.Play("Restore", -1, 0f);
        Anim.speed = 1f;
    }
    public void AnimRotate()
    {
        Anim.Play("Rotate", -1, 0f);
        Anim.speed = 1f;
    }
}
