using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int T_hp;
    public int T_maxhp;
    public string T_name;
    public int T_dmg;
    public float T_Dmr; // 사정거리
    public float T_Ats;// 공격속도
    public bool[] T_buffs = new bool[5];
    public enum TowerState
    {
        idle,
        Attack
    }
    public int T_type;
    void Start()
    {
        
    }

    public void AttackTower()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
