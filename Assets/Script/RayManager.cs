using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayManager : MonoBehaviour
{
    // Spanyan spanyan;
    void Update () 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 1, false);
            if (Physics.Raycast(ray, out hit, 100)) {
                Debug.Log(hit.collider.gameObject.name);
                if(hit.collider.gameObject.tag == "Spanyan")    {   
                    hit.collider.gameObject.GetComponent<Spanyan>().Found();
                    Destroy(hit.collider.gameObject);
                        }
            }
        }
    }
}