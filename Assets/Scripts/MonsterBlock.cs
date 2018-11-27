using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBlock : MonoBehaviour {

    public string monsterName, size, type, alignment, languages, senses, otherSpeed;
    public List<string> abilities, actions;
    public int AC, HP, walkingSpeed, flySpeed, climbSpeed, otherSpeedVal, str, dex, con, INT, wis, cha, exp,
        acrobatics, animalHandling, arcana, athletics, deception, history, insight, intimidation,
        investigation, medicine, nature, perception, performance, persuasion, religion, slightOfHand,
        stealth, survival;


    public MonsterBlock() {
        AC = 10;
        HP = 1;
        walkingSpeed = 30;
        str = 10;
        dex = 10;
        con = 10;
        INT = 10;
        wis = 10;
        cha = 10;
    }

    public MonsterBlock(string name, string size, string type, string alignment, int AC, int HP, int speed,
        int str, int dex, int con, int INT, int wis, int cha, int exp)
    {
        this.monsterName = name;
        this.size = size;
        this.type = type;
        this.alignment = alignment;
        this.AC = AC;
        this.HP = HP;
        this.walkingSpeed = speed;
        this.str = str;
        this.dex = dex;
        this.con = con;
        this.INT = INT;
        this.wis = wis;
        this.cha = cha;
        this.exp = exp;
    }
}
