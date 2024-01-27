using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShooter : MonoBehaviour
{
    [SerializeField] Camera cam;
    public static float desiredTime = 60;
    public GameObject effect;
    [SerializeField] Transform effectPosition;
    void Update()
    {
        if(Statistics.timer < desiredTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                Instantiate(effect, effectPosition.position, Quaternion.identity);
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    Target target = hit.collider.gameObject.GetComponent<Target>();
                    if (target != null)
                    {
                        target.Hit();
                    }
                }
            }
        }
    }
}
