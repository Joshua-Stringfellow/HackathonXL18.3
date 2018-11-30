using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tbassGenerator : MonoBehaviour {
    public Transform tbassPrefab;
    private double i = 0;
    private double j = 0;

    private void Update()
    {
        i = Time.realtimeSinceStartup;

        if ((i-j) > 1)
        {
            var tbassTransform = Instantiate(tbassPrefab) as Transform;

            tbassTransform.position = new Vector3(Random.Range(-3,3), 0, 0);
            j = i;
        }
    }
}
