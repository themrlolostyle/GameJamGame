using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralSpawn : MonoBehaviour
{
    [SerializeField] private Transform[] _square;
    [SerializeField] private float _increaseSpeed;
    [SerializeField] private Vector3 _scale;
    private Vector3 _startScale;

    private Vector3 _speed;

    public float minimum = 0.5504864f;//;
    public float maximum = 8.5F;


    private void Start()
    {
        _startScale = _square[0].localScale;
        //_speed = Vector3.one  *_increaseSpeed;
    }


    private void Update()
    {
        foreach (var item in _square)
        {
            //item.localScale += (Vector3.one * _increaseSpeed) * Time.deltaTime;
            //item.localScale += Vector3.one * Time.fixedDeltaTime;// * Time.deltaTime;
            item.localScale = new Vector2(Mathf.PingPong(Time.time, maximum - minimum) + minimum, Mathf.PingPong(Time.time, maximum - minimum) + minimum);

        }

        //foreach (var item in _square)
        //{
        //    //item.localScale += (Vector3.one * _increaseSpeed) * Time.deltaTime;
        //    item.localScale += Vector3.one;// * Time.deltaTime;

        //}

        //foreach (var item in _square)
        //{
        //    if (item.localScale.x > 8.5f)
        //    {
        //        item.localScale = _startScale;
        //    }
        //}
    }

    //private void FixedUpdate()
    //{
    //    //transform.localScale = new Vector2(Mathf.PingPong(Time.time, maximum - minimum) + minimum, Mathf.PingPong(Time.time, maximum - minimum) + minimum);

    //    foreach (var item in _square)
    //    {
    //        //item.localScale += (Vector3.one * _increaseSpeed) * Time.deltaTime;
    //        //item.localScale += Vector3.one * Time.fixedDeltaTime;// * Time.deltaTime;
    //        item.localScale = new Vector2(Mathf.PingPong(Time.deltaTime, maximum - minimum) + minimum, Mathf.PingPong(Time.deltaTime, maximum - minimum) + minimum);

    //    }
    //}
}
