using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

[CustomEditor(typeof(TestObject))] 
public class TestObjectEdit : Editor {

	Dictionary<TestObject.MemberType, ITestObjectMemberEdit> m_dictionary = null;
	
	public override void OnInspectorGUI() {

		TestObject myTarget = (TestObject) target;

		if (null == m_dictionary) 
		{
			m_dictionary = new Dictionary<TestObject.MemberType, ITestObjectMemberEdit>();

			m_dictionary[TestObject.MemberType.Job]      = (JobEditor)CreateInstance("JobEditor");
			m_dictionary[TestObject.MemberType.Speed]    = (SpeedEditor)CreateInstance("SpeedEditor");
			m_dictionary[TestObject.MemberType.Position] = (PositionEditor)CreateInstance("PositionEditor");
		}

		//DrawDefaultInspector();
		//DrawPreview (new Rect (0, 0, 200, 200));
		
		DrawHeader ();
		myTarget.m_type = (TestObject.MemberType)EditorGUILayout.EnumPopup("Edit member:", myTarget.m_type);

		ITestObjectMemberEdit edit = m_dictionary [myTarget.m_type];
		if (null != edit) 
		{
			edit.UpdateEdit(this, myTarget);
		}
	}

}
