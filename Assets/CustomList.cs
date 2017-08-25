using UnityEngine;
using System;
using System.Collections.Generic; 

public class CustomList : MonoBehaviour {


	[System.Serializable]
	public class Entry {
		public string key; public int value;
	}


	public List<Entry> MyList = new List<Entry>(1);


	void Reset(){
		
		MyList.Add(new Entry());
		MyList.Add(new Entry());
	}


}