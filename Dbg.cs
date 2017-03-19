using UnityEngine;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using UnityEngine.UI;
using Vuforia;

public class Dbg : MonoBehaviour
{
	public static  DateTime now = DateTime.Now;
	public static  string timeFormated = string.Format ("{0:yyyyMMMdd-HH-mm-ss-ff}", now);

	// Log file location for Unity Editor testing
	// static public string dir = "/Users/Hamza/Library/Application Support/DefaultCompany/Calibration_Data/";


	// Log file location for Android internal stroge
	static public string dir = "/Users/mohitsatoskar/Desktop/logs/";

	static public string localLogFile = dir + "VirtualHeadDetector_" + timeFormated + ".csv"; 
	public bool EchoToConsole = true;
	public bool AddTimeStamp = true;
	private	StreamWriter	outputStream;
	static Dbg Singleton = null;

	public static Dbg Instance {
		get { return Singleton; }
	}

	void Start ()
	{
		try {
			if (!Directory.Exists (dir)) {
				Directory.CreateDirectory (dir);
				UnityEngine.Debug.Log (dir + " created !!");
			}
			if (Directory.Exists (dir)) {
				if (!File.Exists (localLogFile)) {
					File.Create (dir + localLogFile);
					UnityEngine.Debug.Log (localLogFile + " created !!");
				} 
			}
				
		} catch (Exception e) {
			UnityEngine.Debug.LogError (e.ToString ());
		}
	}

	//-------------------------------------------------------------------------------------------------------------------------
	void Awake ()
	{	
		if (Singleton != null) {
			UnityEngine.Debug.Log ("Multiple Dbg Singletons exist!");
			return;
		}

		Singleton = this;

#if !FINAL

		if (localLogFile != null) {
			outputStream = new System.IO.StreamWriter (localLogFile);
		}
#endif
	}

	//-------------------------------------------------------------------------------------------------------------------------
	void OnDestory ()
	{
#if !FINAL
		if (outputStream != null) {
			outputStream.Close ();
			outputStream = null;
		}
#endif
	}

	//-------------------------------------------------------------------------------------------------------------------------
	private void WriteWithTimeStamp (string message)
	{
#if !FINAL
		if (AddTimeStamp) {
			DateTime now = DateTime.Now;
			message = string.Format ("{0:yyyy/MM/dd HH:mm:ss:ff} {1}", now, message);
		}

		if (outputStream != null) {
			outputStream.WriteLine (message);
			outputStream.Flush ();
		}
			
		if (EchoToConsole) {
			UnityEngine.Debug.Log (message);
		}
#endif
	}

	//-------------------------------------------------------------------------------------------------------------------------
	//[Conditional ("DEBUG"), Conditional ("PROFILE")]
	public static void TraceWithTimeStamp (string Message)
	{
#if !FINAL
		if (Dbg.Instance != null)
			Dbg.Instance.WriteWithTimeStamp (Message);
		else
			// Fallback if the debugging system hasn't been initialized yet.
			UnityEngine.Debug.Log ("Nothing written");
#endif
	}

	private void WriteWithOutTimeStamp (string message)
	{
		#if !FINAL
		if (outputStream != null) {
			outputStream.WriteLine (message);
			outputStream.Flush ();
		}

		if (EchoToConsole) {
			UnityEngine.Debug.Log (message);
		}
		#endif
	}

	public static void TraceWithOutTimeStampe (string Message)
	{
		#if !FINAL
		if (Dbg.Instance != null)
			Dbg.Instance.WriteWithOutTimeStamp (Message);
		else
			// Fallback if the debugging system hasn't been initialized yet.
			UnityEngine.Debug.Log ("Nothing written");
		#endif
	}
}