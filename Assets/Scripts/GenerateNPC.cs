using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateNPC : MonoBehaviour {

    Toggle monsterNPC;
    Text npcName, npcRace, npcOccupation, npcAppearance, npcAbilities, npcTalent, 
        npcMannerisms, npcInteractions, npcIdeal, npcBond, npcFlaw;
    NPCJob npcJob;
    NPCBlock block;
    NPCName namer;

    public void Generate()
    {
        Create(ref block);

        npcName.text = block.npcName;
        npcRace.text = block.race;
        npcOccupation.text = block.occupation;
        npcAppearance.text = block.appearance;
        npcAbilities.text = block.abilities;
        npcTalent.text = block.talent;
        npcMannerisms.text = block.mannerisms;
        npcInteractions.text = block.interactions;
        npcIdeal.text = block.ideal;
        npcBond.text = block.bond;
        npcFlaw.text = block.flaw;
    }

    public void Create(ref NPCBlock blocker)
    {
        if (monsterNPC.isOn)
        {
            blocker.race = npcRace.GetComponent<NPCRace>().RaceMonster();
        }
        else
        {
            blocker.race = npcRace.GetComponent<NPCRace>().Race(ref block);
        }

        blocker.npcName = namer.Input(ref block);
        blocker.occupation = npcJob.Occupation();
        blocker.appearance = Appearance();
        blocker.abilities = Abilities();
        blocker.talent = Talent();
        blocker.mannerisms = Mannerisms();
        blocker.interactions = Interactions();
        blocker.ideal = Ideal();
        blocker.bond = Bond();
        blocker.flaw = Flaws();
    }

    public string Appearance() {
        string result = "";

        switch (Random.Range(1, 21)) {
            case 1: result = "Distinctive jewelry"; break;
            case 2: result = "Piercings"; break;
            case 3: result = "Flamboyant clothes"; break;
            case 4: result = "Formal, clean clothes"; break;
            case 5: result = "Ragged, dirty clothes"; break;
            case 6: result = "Pronounced scar"; break;
            case 7: result = "Missing teeth"; break;
            case 8: result = "Missing Fingers"; break;
            case 9: result = "Unusual eye color"; break;
            case 10: result = "Tattoos"; break;
            case 11: result = "Birthmark"; break;
            case 12: result = "Unusual skin color"; break;
            case 13: result = "Bald"; break;
            case 14: result = "Braided beard or hair"; break;
            case 15: result = "Unusual hair color"; break;
            case 16: result = "Nervous eye twitch"; break;
            case 17: result = "Distinctive nose"; break;
            case 18: result = "Distinctive posture"; break;
            case 19: result = "Exceptionally beautiful"; break;
            case 20: result = "Exceptionally ugly"; break;
        }

        return result;
    }

    public string Abilities() {
        string result = "";

        result = "High ability: ";

        int high, low;

        high = Random.Range(1, 7);
        low = Random.Range(1, 7);
        while (high == low) {
            low = Random.Range(1,7);
        }

        switch (high) {
            case 1: result += "Strength - brawny"; break;
            case 2: result += "Dexterity - lithe"; break;
            case 3: result += "Constitution - hardy"; break;
            case 4: result += "Intelligence - inquisitive"; break;
            case 5: result += "Wisdom - insightful"; break;
            case 6: result += "Charisma - persuasive/forceful"; break;
        }

        result += "; Low ability: ";

        switch (low) {
            case 1: result += "Strength - scrawny"; break;
            case 2: result += "Dexterity - clumsy"; break;
            case 3: result += "Constitution - sickly"; break;
            case 4: result += "Intelligence - dim-witted"; break;
            case 5: result += "Wisdom - oblivious"; break;
            case 6: result += "Charisma - dull"; break;
        }

        return result;
    }

    public string Talent() {
        string result = "";

        switch (Random.Range(1, 21)) {
            case 1: result = "Plays a musical instrument"; break ;
            case 2: result = "Speaks several languages fluently"; break;
            case 3: result = "Unbelievably lucky"; break;
            case 4: result = "Perfect Memory"; break;
            case 5: result = "Great with animals"; break;
            case 6: result = "Great with children"; break;
            case 7: result = "Great at solving puzzles"; break;
            case 8: result = "Great at one game"; break;
            case 9: result = "Great at impersonations"; break;
            case 10: result = "Draws beautifully"; break;
            case 11: result = "Paints beautifully"; break;
            case 12: result = "Sings beautifully"; break;
            case 13: result = "Drinks everyone under the table"; break;
            case 14: result = "Expert carpenter"; break;
            case 15: result = "Expert cook"; break;
            case 16: result = "Expert dart thrower and rock skipper"; break;
            case 17: result = "Expert juggler"; break;
            case 18: result = "Skilled actor and master of disguise"; break;
            case 19: result = "Skilled dancer"; break;
            case 20: result = "Knows thieves' cant"; break;
        }

        return result;
    }

    public string Mannerisms() {
        string result = "";

        switch (Random.Range(1, 21)) {
            case 1: result = "Prone to singing, whistling, or humming quietly"; break;
            case 2: result = "Speaks in rhyme or some other peculiar way"; break;
            case 3: result = "Particularly low or high voice"; break;
            case 4: result = "Slurs words, lisps, or stutters"; break;
            case 5: result = "Enunciates overly clearly"; break;
            case 6: result = "Speaks loudly"; break;
            case 7: result = "Whispers"; break;
            case 8: result = "Uses flowery speech or long words"; break;
            case 9: result = "Frequently uses the wrong word"; break;
            case 10: result = "Uses colorful oaths and exclamations"; break;
            case 11: result = "Makes constant jokes or puns"; break;
            case 12: result = "Prone to predictions of doom"; break;
            case 13: result = "Fidgets"; break;
            case 14: result = "Squints"; break;
            case 15: result = "Stares into the distance"; break;
            case 16: result = "Chews something"; break;
            case 17: result = "Paces"; break;
            case 18: result = "Taps fingers"; break;
            case 19: result = "Bites fingernails"; break;
            case 20: result = "Twirls hair or tugs beard"; break;
        }

        return result;
    }

    public string Interactions() {
        string result = "";

        switch (Random.Range(1, 13)) {
            case 1: result = "Argumentative"; break;
            case 2: result = "Arrogant"; break;
            case 3: result = "Blustering"; break;
            case 4: result = "Rude"; break;
            case 5: result = "Curious"; break;
            case 6: result = "Friendly"; break;
            case 7: result = "Honest"; break;
            case 8: result = "Hot tempered"; break;
            case 9: result = "Irritable"; break;
            case 10: result = "Ponderous"; break;
            case 11: result = "Quiet"; break;
            case 12: result = "Suspicious"; break;
        }

        return result;
    }
    
    public string Ideal() {
        string result = "";

        switch (Random.Range(1, 37)) {
            case 1: result = "Beauty (Good)"; break;
            case 2: result = "Charity (Good)"; break;
            case 3: result = "Greater good (Good)"; break;
            case 4: result = "Life (Good)"; break;
            case 5: result = "Respect (Good)"; break;
            case 6: result = "Self-Sacrifice (Good)"; break;
            case 7: result = "Domination (Evil)"; break;
            case 8: result = "Greed (Evil)"; break;
            case 9: result = "Might (Evil)"; break;
            case 10: result = "Pain (Evil)"; break;
            case 11: result = "Retribution (Evil)"; break;
            case 12: result = "Slaughter (Evil)"; break;
            case 13: result = "Community (Lawful)"; break;
            case 14: result = "Fairness (Lawful)"; break;
            case 15: result = "Honor (Lawful)"; break;
            case 16: result = "Logic (Lawful)"; break;
            case 17: result = "Responsibility (Lawful)"; break;
            case 18: result = "Tradition (Lawful)"; break;
            case 19: result = "Change (Chaotic)"; break;
            case 20: result = "Creativity (Chaotic)"; break;
            case 21: result = "Freedom (Chaotic)"; break;
            case 22: result = "Independence (Chaotic)"; break;
            case 23: result = "No Limits (Chaotic)"; break;
            case 24: result = "Whimsy (Chaotic)"; break;
            case 25: result = "Balance (Neutral)"; break;
            case 26: result = "Knowledge (Neutral)"; break;
            case 27: result = "Live and Let Live (Neutral)"; break;
            case 28: result = "Moderation (Neutral)"; break;
            case 29: result = "Neutrality (Neutral)"; break;
            case 30: result = "People (Neutral)"; break;
            case 31: result = "Aspiration (Other)"; break;
            case 32: result = "Discovery (Other)"; break;
            case 33: result = "Glory (Other)"; break;
            case 34: result = "Nation (Other)"; break;
            case 35: result = "Redemption (Other)"; break;
            case 36: result = "Self-knowledge (Other)"; break;
        }

        return result;
    }

    public string Bond() {
        string result = "";

        switch (Random.Range(1, 11)) {
            case 1: result = "Dedicated to fulfilling a life goal"; break;
            case 2: result = "Protective of close family members"; break;
            case 3: result = "Protective of colleagues or compatriots"; break;
            case 4: result = "Loyal to a benefactor, patron, or employer"; break;
            case 5: result = "Captivated by a romantic interest"; break;
            case 6: result = "Drawn to a special place"; break;
            case 7: result = "Protective of a sentimental keepsake"; break;
            case 8: result = "Protective of a valuable possession"; break;
            case 9: result = "Out for revenge"; break;
            case 10: result = Bond2(); break;
        }

        return result;
    }

    public string Bond2() {
        string result = "";

        switch (Random.Range(1, 10)) {
            case 1: result = "Dedicated to fulfilling a life goal"; break;
            case 2: result = "Protective of close family members"; break;
            case 3: result = "Protective of colleagues or compatriots"; break;
            case 4: result = "Loyal to a benefactor, patron, or employer"; break;
            case 5: result = "Captivated by a romantic interest"; break;
            case 6: result = "Drawn to a special place"; break;
            case 7: result = "Protective of a sentimental keepsake"; break;
            case 8: result = "Protective of a valuable possession"; break;
            case 9: result = "Out for revenge"; break;
        }

        result += ", and ";

        switch (Random.Range(1, 10)) {
            case 1: result = "Dedicated to fulfilling a life goal"; break;
            case 2: result = "Protective of close family members"; break;
            case 3: result = "Protective of colleagues or compatriots"; break;
            case 4: result = "Loyal to a benefactor, patron, or employer"; break;
            case 5: result = "Captivated by a romantic interest"; break;
            case 6: result = "Drawn to a special place"; break;
            case 7: result = "Protective of a sentimental keepsake"; break;
            case 8: result = "Protective of a valuable possession"; break;
            case 9: result = "Out for revenge"; break;
        }

        return result;
    }

    public string Flaws() {
        string result = "";

        switch (Random.Range(1, 13)) {
            case 1: result = "Forbidden love or susceptibility to romance"; break;
            case 2: result = "Enjoys decadent pleasures"; break;
            case 3: result = "Arrogance"; break;
            case 4: result = "Envies another creature's pososessions or station"; break;
            case 5: result = "Overpowering greed"; break;
            case 6: result = "Prone to rage"; break;
            case 7: result = "Has a powerful enemy"; break;
            case 8: result = "Specfic phobia"; break;
            case 9: result = "Shameful or scandelous history"; break;
            case 10: result = "Secret crime or misdeed"; break;
            case 11: result = "Possession of forbidden lore"; break;
            case 12: result = "Foolhardy bravery"; break;
        }

        return result;
    }

	void Start () {
        monsterNPC = FindObjectOfType<Toggle>();
        npcName = FindObjectOfType<NPCName>().GetComponent<Text>();
        npcRace = FindObjectOfType<NPCRace>().GetComponent<Text>();
        npcOccupation = FindObjectOfType<NPCOcc>().GetComponent<Text>();
        npcAppearance = FindObjectOfType<NPCApp>().GetComponent<Text>();
        npcAbilities = FindObjectOfType<NPCAbil>().GetComponent<Text>();
        npcTalent = FindObjectOfType<NPCTal>().GetComponent<Text>();
        npcMannerisms = FindObjectOfType<NPCMann>().GetComponent<Text>();
        npcInteractions = FindObjectOfType<NPCInter>().GetComponent<Text>();
        npcIdeal = FindObjectOfType<NPCIdeal>().GetComponent<Text>();
        npcBond = FindObjectOfType<NPCBond>().GetComponent<Text>();
        npcFlaw = FindObjectOfType<NPCFlaw>().GetComponent<Text>();
        npcJob = FindObjectOfType<NPCJob>();
        block = new NPCBlock();
        namer = FindObjectOfType<NPCName>();
    }

    
}
