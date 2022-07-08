using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBehavior : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update

    private void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator.name);
        animator.SetBool("isHere", true);
    }

    private void Awake()
    {
        
    }

    private void Update()
    {
        
    }
}
