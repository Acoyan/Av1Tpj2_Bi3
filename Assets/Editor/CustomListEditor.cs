using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(CustomList))]

public class CustomListEditor : Editor {


	public override void OnInspectorGUI(){
		CustomList X = target as CustomList; 




		for(int i = 0; i < X.MyList.Count; i++)
		{
			X.MyList [i].value = EditorGUILayout.IntField ("papai", X.MyList [i].value);
			
		}
}
}

