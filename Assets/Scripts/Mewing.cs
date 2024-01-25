using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mewing : MonoBehaviour
{
    [SerializeField] private Animator anim;
  
    void Update()
    {
        if (Input.GetKey(KeyCode.M)) anim.SetBool("isMewing", true);
        else anim.SetBool("isMewing", false);
    }
}
