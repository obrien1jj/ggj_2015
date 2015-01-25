using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeroCharacter : Character 
{
	public class WayPoint
	{
		public WayPoint(Vector3 loc, GameObject mark = null, int num = 0)
		{
			pos = loc;
			marker = mark;
			count = num;
		}

		public Vector3 pos;
		public GameObject marker;
		public int count;
	}

	WayPoint currWaypoint = null;

	protected Queue<WayPoint> wayPoints = new Queue<WayPoint>();

	override protected bool moving 
	{ 
		get { return _moving; }
		set {
			_moving = value;
			if (moving == false && currWaypoint != null)
			{
				Destroy (currWaypoint.marker);
				currWaypoint = null;
			}

		}
	}

	override protected void OnDestroy()
	{
		if (wayPoints != null)
		{
			wayPoints.Clear();
			wayPoints = null;
		}

		base.OnDestroy();
	}


	// Update is called once per frame
	override protected void Update () {
		base.Update();
		
		if (GameManager.Instance.actionMode && Input.GetKeyDown(KeyCode.Mouse0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if ( Physics.Raycast(ray, out hit, 50, 1<<9) ) // && !UIManager.instance.DidAnyPointerHitUI())
			{
             	int num = 0;
				if (currWaypoint != null)
					num = currWaypoint.count;
				num++;
				if (num <= 9)
				{
					GameObject waypointMarker = Instantiate(GameManager.Instance.wayPointMarker) as GameObject;
					waypointMarker.transform.position = hit.point;
					waypointMarker.GetComponentInChildren<tk2dTextMesh>().text = "" + num;

					currWaypoint = new WayPoint(hit.point, waypointMarker, num);
					wayPoints.Enqueue(currWaypoint);
				}
				// Place a marker to indicate goal
				//PlaceMarker(new Vector3(targetLocation.x, 3, targetLocation.z));			
			}	
		}

		if ( !moving && !GameManager.Instance.actionMode )
		{
			if (wayPoints.Count > 0)
			{

				if (currWaypoint != null && !wayPoints.Contains(currWaypoint) )
				{
					Destroy(currWaypoint.marker); //remove it from the scene
				}
				currWaypoint = wayPoints.Dequeue();
				MoveTo(currWaypoint.pos);
				moving = true;
				GameManager.Instance.disableActionMode = true;
			}
			else
			{
				if ( currWaypoint != null )
				{
					Destroy(currWaypoint.marker); //remove it from the scene
					currWaypoint = null;
				}
				GameManager.Instance.disableActionMode = false;
			}
		}

		
	}

}
