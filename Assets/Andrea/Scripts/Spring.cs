﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andrea
{
    [RequireComponent(typeof(AABB))]
    public class Spring : MonoBehaviour
    {
        public float springiness = 15;
    }
}