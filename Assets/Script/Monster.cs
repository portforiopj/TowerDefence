using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Monster 
{
    public int M_num;
    public string M_name;
    public int M_hp;
    public int M_dmg;
    public float M_movs;
    public bool[] M_buff=new bool[2];
    public int M_gold;
    public GameObject M_prefab_ob;
    public enum MonsterType
    {
        Red,
        Blue,
        Green
    }
    public MonsterType M_monsterType;
    public Monster() { }
    public Monster(int num,string name,int hp,int dmg,float movs,int gold,MonsterType monsterType,GameObject ob)
    {
        M_num = num;
        M_name = name;
        M_hp = hp;
        M_dmg = dmg;
        M_movs = movs;
        M_gold = gold;
        M_monsterType = monsterType;
        M_prefab_ob = ob;
    }
   
  
    public Monster getCopy()
    {
        return (Monster)this.MemberwiseClone();
    }
    
    
}
