﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags
{
    public static string WALL = "Wall";
    public static string FRUIT = "Fruit";
    public static string POINTS = "Points";
    public static string TAIL = "Tail";
}

public class Metrics
{
    public static float NODE = 0.7f;
}

public enum PlayerDirection
{
    LEFT = 0,
    UP = 1,
    RIGHT = 2,
    DOWN = 3,
    COUNT = 4
}