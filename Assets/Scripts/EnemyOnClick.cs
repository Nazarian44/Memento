using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOnClick : MonoBehaviour
{

    Transform tra;
    void Start()
    {
        tra = GetComponent<Transform>();
    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        //tra.localScale = new Vector2(2, 2);
    }
}
