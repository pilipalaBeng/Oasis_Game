﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Oasis
{
    [DisallowMultipleComponent]
    public class GameStateCtrl : MonoBehaviour
    {
        private GameStateCtrl()
        {
            //防止它人滥用实例化，导致报错
        }
    }
}