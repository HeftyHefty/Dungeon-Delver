﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    private GameObject sword;
    private Dray dray;

    void Start()
    {
        sword = transform.Find("Sword").gameObject;
        dray = transform.parent.GetComponent<Dray>();
        sword.SetActive(false);//did not work as false before, but changed it to true and now it works??
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 90 * dray.facing);
        sword.SetActive(dray.mode == Dray.eMode.attack);
    }
}


