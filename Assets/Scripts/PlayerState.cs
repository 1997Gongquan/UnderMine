﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    private static PlayerState _instance;
    // 角色位置
    public Vector2 PlayerPosition;
    // 角色是否跳跃
    public bool IsJump;
    // 角色朝向
    public Vector2 moveVec;
    
    public static PlayerState Instance => _instance ?? (_instance = new PlayerState());


    PlayerState()
    {
        IsJump = false;
    }
}
