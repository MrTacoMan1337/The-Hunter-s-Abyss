﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        DontDestroyOnLoad(gameObject); //Do not destroy object when scenes change
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
