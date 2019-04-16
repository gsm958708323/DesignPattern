using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Design.Test01;

public class Test01 : MonoBehaviour
{
    /*
     * 角色有国王King，皇后Queen，骑士Knight，妖怪Troll
     * 任何角色可以自由切换武器
     */
    // Start is called before the first frame update
    void Start()
    {
        KingFight();
        QueenFight();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void KingFight()
    {
        King king = new King(new Sword());
        //king.SetWeapon(new Knife());
        king.Fight();
        Debugger.Log("你好");
    }
    void QueenFight()
    {
        Queen king = new Queen(new Knife());
        king.Fight();
    }
}
