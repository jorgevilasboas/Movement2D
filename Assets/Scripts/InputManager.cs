using UnityEngine;
using System.Collections;

public enum Buttons
{
	Right,
	Left
}

[System.Serializable]
public class InputAxisState
{
	public string axisName;
	public float offValue;
	public Buttons button;
}

public class InputManager : MonoBehaviour
{
	public InputAxisState[] inputs;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
