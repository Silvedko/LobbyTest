using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	[SerializeField]
	Transform startPointsContainer;

	List <Transform> startPoints;

	void Start () 
	{
		InitPoints ();
	}

	void InitPoints ()
	{
		startPoints = new List <Transform> ();
		for (int i = 0; i < startPointsContainer.childCount; i++)
		{
			startPoints.Add (startPointsContainer.GetChild(i));
		}
	}
	
	public Vector3 GetStartPoint (int id) 
	{
		if (id > startPoints.Count)
			id = startPoints.Count - 1;
		
		return startPoints [id].position;
	}
}
