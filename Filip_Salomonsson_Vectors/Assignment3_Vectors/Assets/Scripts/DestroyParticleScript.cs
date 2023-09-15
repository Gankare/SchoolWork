using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DestroyParticleScript : MonoBehaviour
{
    private float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
            Destroy(this.gameObject);
    }
}
