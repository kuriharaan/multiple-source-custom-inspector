using UnityEngine;
using UnityEditor;
using System.Collections;

public class PositionEditor : Editor, ITestObjectMemberEdit {
	public void UpdateEdit(TestObjectEdit editor, TestObject target)
	{
		target.m_position = EditorGUILayout.Vector3Field("position", target.m_position);
	}
}
