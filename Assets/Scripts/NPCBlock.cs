using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBlock : MonoBehaviour {

    public string npcName, race, occupation, abilities, appearance, talent, mannerisms, interactions, ideal, bond, flaw;

    public NPCBlock(string name, string race, string occupation, string abilities, string appearance,
        string talent, string mannerisms, string interactions, string ideal, string bond, string flaw) {
        this.npcName = name;
        this.race = race;
        this.occupation = occupation;
        this.abilities = abilities;
        this.appearance = appearance;
        this.talent = talent;
        this.mannerisms = mannerisms;
        this.interactions = interactions;
        this.ideal = ideal;
        this.bond = bond;
        this.flaw = flaw;
    }

    public NPCBlock() {
        npcName = "";
        race = "";
        occupation = "";
        abilities = "";
        appearance = "";
        talent = "";
        mannerisms = "";
        interactions = "";
        ideal = "";
        bond = "";
        flaw = "";
    }
}
