using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ct : MonoBehaviour
{
    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HM = Input.GetAxis("Horizontal");
        float VM = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(HM, 0, VM) * speed * Time.deltaTime);
        
    }
}
