using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositioning : MonoBehaviour
{
    public Transform target;
    public float duration;
    float wait;

    // Start is called before the first frame update
    void Start()
    {
        wait = duration;
    }

    // Update is called once per frame
    void Update()
    {
        // Positioning randomly around target after __ seconds
        wait -= Time.deltaTime;
        if (wait < 0.1f)
        {
            transform.position = new Vector3(target.position.x + Random.Range(-5, 5), target.position.y + Random.Range(-5, 5), target.position.z);
            wait = duration;
        }
    }
}
