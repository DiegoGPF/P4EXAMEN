using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private Rigidbody[] rigidbodies;
    [SerializeField] bool isdead;
    [SerializeField] private Transform targetPlayer;
    private NavMeshAgent enemy;
    [SerializeField] private float waitTime;
    
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        targetPlayer = FindObjectOfType<PlayerMovement>().transform;
        rigidbodies = transform.GetComponentsInChildren<Rigidbody>();
        anim = GetComponent<Animator>();
        ActivateRagdoll(false);
        isdead = false;
    }

    void Update()
    {
        
        if(isdead)                                                      //Para activar el ragdoll es necesario que la variable isdead sea True 
        {
            ActivateRagdoll(true);
            StartCoroutine(IsDeath());
        }
        else
        {
            ActivateRagdoll(false);
            enemy.SetDestination(targetPlayer.position);                //El Bot sigue al jugador
        }
    }

    private void ActivateRagdoll(bool enabled)                          //Metodo para la activacion del ragdoll
    {
        bool isKinematic = !enabled;
        foreach(Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = isKinematic;
        }
        anim.enabled = isKinematic;
    }
    IEnumerator IsDeath()                              //Corrutina que se activa cuando se activa el ragdoll
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}
