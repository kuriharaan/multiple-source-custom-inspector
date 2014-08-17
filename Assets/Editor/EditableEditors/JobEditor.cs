using UnityEngine;
using UnityEditor;
using System.Collections;

public class JobEditor : Editor, ITestObjectMemberEdit {
	public void UpdateEdit(TestObjectEdit editor, TestObject target)
	{
		target.m_jobString = EditorGUILayout.TextField(target.m_jobString);
	}
}
