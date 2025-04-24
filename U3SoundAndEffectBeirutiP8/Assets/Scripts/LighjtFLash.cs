using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighjtFLash : MonoBehaviour
{
    public float interval = 1;
    public Light myLight;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            myLight.enabled = !myLight.enabled;
            timer -= interval;
        }
    }
}
