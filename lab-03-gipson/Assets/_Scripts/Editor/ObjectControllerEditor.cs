using UnityEngine;
using System.Collections;
using UnityEditor;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: ObjectControllerEditor is a custom editor
/// </summary>
[CustomEditor(typeof(ObjectController))]
public class ObjectControllerEditor : Editor {
    #region Fields

    ObjectController controller;

    #endregion

    void Awake() {
         controller = (ObjectController) target;
    }

    public override void OnInspectorGUI(){
			
		//DrawDefaultInspector();

        serializedObject.Update();
        serializedObject.ApplyModifiedProperties();

    } 

}