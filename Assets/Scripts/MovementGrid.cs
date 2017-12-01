﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGrid : InteractableObject {

    [Header("Variables")]
    public GameObject player;

   public override void IsActivated()
    {
        //moving player
        player.transform.position = transform.position;

    }
}