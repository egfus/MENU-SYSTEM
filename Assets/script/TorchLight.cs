using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLight : MonoBehaviour
{
    public GameObject Fire;
    public GameObject Torch;
    public Animator Door;
    public GameObject fpc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                //if (hit != null)
                {
                    if (hit.transform.gameObject.tag == "Torch")
                    {
                        Transform t = hit.transform;
                        for (int i = 0; i < t.childCount; i++)
                        {
                            t.GetChild(i).gameObject.SetActive(true);
                        }
                    }
                    else if (hit.transform.gameObject.tag == "SharedTorch")
                    {
                        Transform p = hit.transform.parent;
                        Transform lights = p.GetChild(0);
                        for (int i = 0; i < lights.childCount; i++)
                        {
                            lights.GetChild(i).gameObject.SetActive(true);
                        }
                    }
                    else if (hit.transform.gameObject.tag == "door")
                    {
                        Door.SetTrigger("open");
                    }
                    else if (hit.transform.gameObject.tag == "quit")
                    {
                        fpc.GetComponent<PlayerFall>().fall = true;
                        fpc.GetComponent<CapsuleCollider>().enabled = false;
                    
                    }
                }

            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    
    }

    
}
