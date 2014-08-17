using UnityEngine;
using UnityEditor;
using System.Collections;

public class SpeedEditor : Editor, ITestObjectMemberEdit {
	public void UpdateEdit(TestObjectEdit editor, TestObject target)
	{
		target.m_speed = EditorGUILayout.Vector3Field("speed", target.m_speed);
	}
}
