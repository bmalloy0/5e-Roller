using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettlementGenerator : MonoBehaviour {

    Dictionary<string, NPCBlock> citizens;
    List<string> citizenNames;
    NPCBlock block;
    GenerateNPCSimple generator;
    Dropdown listOfCitizens;

    void GenerateVillage() {

        int villagers = Random.Range(100, 500);
        Debug.Log("number of villagers: " + villagers);
        for (int i = 0; i < villagers; i++)
        {
            block = new NPCBlock();
            generator.Create(ref block);

            while (citizens.ContainsKey(block.npcName))
            {
                generator.Create(ref block);
            }
            citizenNames.Add(block.npcName);
            citizens.Add(block.npcName, block);
        }

        listOfCitizens.AddOptions(citizenNames);
        Debug.Log("citizenNames count: " + citizenNames.Count);
        Debug.Log("citizens count: " + citizens.Count);
    }

    public void GetNPCInfo() {
        NPCBlock npc = citizens[citizenNames[listOfCitizens.value]];
        Debug.Log(npc.npcName);
        Debug.Log(npc.race);
        Debug.Log(npc.occupation);
        Debug.Log(npc.appearance);
        Debug.Log(npc.abilities);
        Debug.Log(npc.talent);
        Debug.Log(npc.mannerisms);
        Debug.Log(npc.interactions);
        Debug.Log(npc.ideal);
        Debug.Log(npc.bond);
        Debug.Log(npc.flaw);
    }

    // Use this for initialization
    void Start () {
        citizens = new Dictionary<string, NPCBlock>();
        citizenNames = new List<string>();
        generator = GetComponent<GenerateNPCSimple>();
        listOfCitizens = GetComponent<Dropdown>();
        listOfCitizens.ClearOptions();
        GenerateVillage();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
