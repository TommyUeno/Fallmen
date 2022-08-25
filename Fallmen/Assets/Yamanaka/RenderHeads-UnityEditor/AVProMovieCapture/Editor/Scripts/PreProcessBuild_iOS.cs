#if UNITY_IOS
#if UNITY_2018_1_OR_NEWER
	#define UNITY_SUPPORTS_BUILD_REPORT
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;
using UnityEditor.Build;
#if UNITY_SUPPORTS_BUILD_REPORT
	using UnityEditor.Build.Reporting;
#endif

//-----------------------------------------------------------------------------
// Copyright 2012-2022 RenderHeads Ltd.  All rights reserved.
//-----------------------------------------------------------------------------

namespace RenderHeads.Media.AVProMovieCapture.Editor
{
	public class PreProcessBuild_iOS :
#if UNITY_SUPPORTS_BUILD_REPORT
		IPreprocessBuildWithReport
#else
		IPreprocessBuild
#endif
	{
		public int callbackOrder { get { return 0; } }

#if UNITY_SUPPORTS_BUILD_REPORT
		public void OnPreprocessBuild(BuildReport report)
		{
			OnPreprocessBuild(report.summary.platform, report.summary.outputPath);
		}
#endif

		public void OnPreprocessBuild(BuildTarget target, string path)
		{
			if (target != BuildTarget.iOS)
				return;

			string[] guids = AssetDatabase.FindAssets("libAVProMovieCapture");
			if (guids.Length == 0)
				return;

			Debug.LogWarning("libAVProMovieCapture.a is no longer required and will be removed from your project.");
			Debug.Log("If you selected 'Append' your project will not build in Xcode this time. Please select 'Replace' to refresh the project files.");

			foreach (string guid in guids)
			{
				string libAVProMovieCapturePath = AssetDatabase.GUIDToAssetPath(guid);
				Debug.Log("Deleting " + libAVProMovieCapturePath);
				System.IO.File.Delete(libAVProMovieCapturePath);
				System.IO.File.Delete(libAVProMovieCapturePath + ".meta");
			}
		}
	}
}
#endif // UNITY_IOS
