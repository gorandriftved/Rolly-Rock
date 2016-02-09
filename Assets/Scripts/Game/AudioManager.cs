using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public static AudioManager instance = null;

	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(this.gameObject);

		DontDestroyOnLoad(this.gameObject);
			
	}
		

	void Start () {
		
	
	}
	

	void Update () {
	
	}

}
