﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackEffect : MonoBehaviour
{

    [SerializeField] float effectDuration = 0.5f;
    [SerializeField] AudioClip attackSound;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, effectDuration);
        if(attackSound != null)
            AudioSource.PlayClipAtPoint(attackSound, Camera.main.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
