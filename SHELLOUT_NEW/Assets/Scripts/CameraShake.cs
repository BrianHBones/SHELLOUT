using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeStrength = 0f;
    
    private void Update()
    {
        transform.position = (Vector3)(Random.insideUnitCircle * shakeStrength);  
        if (shakeStrength > 0)
            Mathf.Clamp(shakeStrength -= Time.deltaTime, 0, 1);
    }
}
