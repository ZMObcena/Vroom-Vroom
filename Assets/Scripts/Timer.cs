using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float laptime;
    private bool startTimer = false;

    public UnityEngine.UI.Text Ltime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        {
            laptime = laptime + Time.deltaTime;
            Debug.Log(laptime);
            Ltime.text = laptime.ToString("F2");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        startTimer = true;
    }
}
