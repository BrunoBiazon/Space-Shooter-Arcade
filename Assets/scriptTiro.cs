using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTiro : MonoBehaviour
{
    Rigidbody2D rdb;
    public float vel_tiro;
    void Start()
    {

        rdb = GetComponent<Rigidbody2D>();
        vel_tiro = 11;
        rdb.velocity = new Vector2(0, vel_tiro);
    }

    void Update()
    {
        if (transform.position.y > CameraUtils.GetAltura())
        {

            Destroy(this.gameObject);

        }
    }
}
