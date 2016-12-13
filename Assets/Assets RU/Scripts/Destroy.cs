using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void GroupInit (string groupName)
	{
		List<string> myGroups = GetComponent<StoreGroups>().myGroups;
		foreach(string currentGroup in myGroups)
		{
			if(currentGroup==groupName)
			{
				Destroy(this.gameObject);
			}
		}
	}
}
