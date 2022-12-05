using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log($"Collision! @ {collision.gameObject.name}");
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"Trigger! @ {other.gameObject.name}");
    }

    void Start()
    {
        
    }

    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            LayerMask layerMask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");

            //int monsterMask = (1 << 6);
            //int wallMask = (1 << 7);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, layerMask))
            {
                Debug.Log($"RayCast Camera @ {hit.collider.gameObject.tag}");
            }

        }
    }
}
