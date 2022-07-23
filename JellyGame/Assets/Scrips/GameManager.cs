using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Sprite[] JellySpriteList;
    public string[] JellyNameList;
    public int[] JellyJelatineList;
    public int[] JellyGoldList;
     public Vector3[] PointList;
    public RuntimeAnimatorController[] LevelAc; 

      public void ChangeAc(Animator anim, int Level)
     {
        anim.runtimeAnimatorController = LevelAc[Level -1];
     } 
}
