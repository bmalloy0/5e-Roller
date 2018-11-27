using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDirectory : MonoBehaviour {

    Dictionary<string, MonsterBlock> monster; 

    // Use this for initialization
    void Start () {
        monster.Add("Aarakocra", new MonsterBlock("Aarakoca", "Medium", "Humanoid", "Neutral Good",
            12, 13, 30, 10, 14, 10, 11, 12, 11, 50));
        monster["Aarakocra"].flySpeed = 50;
        monster["Aarakocra"].perception = 5;
        monster["Aarakocra"].languages = "Auran";
        monster["Aarakocra"].abilities.Add("Dive Attack: If the Aarakoca is flying and dives at least 30 " +
            "feet straight toward a target and then hits it with a melee weapon attack, the attack deals " +
            "an extra 1d6 damage to the target");
        monster["Aarakocra"].actions.Add("Talon. Melee weapon attack: +4 to hit, reach 5 ft, one target. " +
            "Hit: 4 (1d4 + 2) slashing damage.");
        monster["Aarakocra"].actions.Add("Javelin. Melee Ranged weapon attack: +4 to hit, reach 5 ft or " +
            "range 30/120 feet, one target. Hit: 5 (1d6 + 2) piercing damage.");
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
