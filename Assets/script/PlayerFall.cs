using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    public bool fall;
    public float fallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        fall = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fall)
        {
            transform.position = transform.position - new Vector3(0, fallSpeed * Time.deltaTime, 0);
        }
    }
}
