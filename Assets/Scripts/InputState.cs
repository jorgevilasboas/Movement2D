using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonState
{
	public bool value;
}

public class InputState : MonoBehaviour
{

	private Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons, ButtonState> ();

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		foreach (KeyValuePair<Buttons, ButtonState> state in buttonStates) {
			Debug.Log ("Button State " + state.Key + " " + state.Value.value);
		}
	}

	public void SetButtonValue (Buttons key, bool value)
	{
		if (!buttonStates.ContainsKey (key))
			buttonStates.Add (key, new ButtonState ());

		var state = buttonStates [key];
		state.value = value;

	}
}