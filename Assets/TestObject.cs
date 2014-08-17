using UnityEngine;
using System.Collections;


[System.Serializable]
public class TestObject : MonoBehaviour {

	public enum MemberType
	{
		Speed,
		Position,
		Job,
	};

#if UNITY_EDITOR
	public MemberType    m_type;
#endif
	public Vector3 m_speed;
	public Vector3 m_position;
	public string  m_jobString;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
