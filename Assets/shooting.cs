using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class shooting : MonoBehaviour
{
    public GameObject DecalPrefab;
    public AudioSource fire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)), out hit))
            {
                //  GameObject.Instantiate(DecalPrefab,
                //     hit.point+hit.normal * 0.01f, 
                //   Quaternion.FromToRotation
                //      (Vector3.forward, 
                //     -hit.normal)) 
                // as GameObject;

                Quaternion decalRotation = Quaternion.FromToRotation(Vector3.forward, -hit.normal);
                GameObject.Instantiate(DecalPrefab, hit.point + hit.normal * 0.01f, decalRotation);



                fire.Play();
            }
        }
    }
}
